using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KnaufinsulationWalls.UpdateForms
{
    public partial class UpdateDownLoad : Form
    {
        private WebClient wb = new WebClient();
        public UpdateDownLoad()
        {
            vers = "1.0.0";
            InitializeComponent();
            wb.DownloadProgressChanged += Wb_DownloadProgressChanged;
            wb.DownloadFileCompleted += Wb_DownloadFileCompleted;
        }

      

        public String vers { get; set; }
        public String link { get; set; }



        private String valueUpdate = "Идет загрузка обновления\r\nверсия ";

        private void UpdateDownLoad_Load(object sender, EventArgs e)
        {
            pgBar.Value = 0;
            lblStatus.Text = "Подготовка к скачиванию..";
            Text = "Загрузка обновления программы версии " + vers;

            saveFileDialog1.FileName += "_" + vers;
        }

        private void UpdateDownLoad_Shown(object sender, EventArgs e)
        {
            valueUpdate += vers + "\r\n";
            if (wb.IsBusy)
                return;

            var ret = saveFileDialog1.ShowDialog(Application.OpenForms[0]);

            if(ret != DialogResult.OK)
                Close();


            Helper.WriteLog("Загрука обновления: " + link);
            wb.DownloadFileAsync(new Uri(link), saveFileDialog1.FileName);
        }

        private void Wb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblStatus.Text = valueUpdate + (e.BytesReceived/1024).ToString() + " из " + (e.TotalBytesToReceive/1024).ToString() + " мегабайт";
            pgBar.Value = e.ProgressPercentage;

        }

        private void Wb_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null )
                {
                    lblStatus.Text = "Ошибка при загрузке обновления";
                    throw e.Error;
                }

                lblStatus.Text = "Обновление загружено";
                pgBar.Value = 100;
                

                roundButton1.Text = "Готово";
                var ret = MessageBox.Show("Обновление загружено.\r\nЗапустить установку новой версии?\r\n\r\n" +
                    "ВНИМАНИЕ! Текущий экзмепляр программы будет закрыт!\r\n", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {

                    Process.Start(saveFileDialog1.FileName);
                    Application.Exit();
                }

            }
            catch (WebException ew)
            {
                if (ew.Status == WebExceptionStatus.RequestCanceled)
                {
                    Helper.WriteLog(ew.Message);
                    File.Delete(saveFileDialog1.FileName);
                    Close();
                }
                else
                    throw ew;

            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
                var ret = MessageBox.Show(ex.Message + "\r\n\r\nПовторить загрузку?", "Ошибка при сохранении файла", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                if (ret == DialogResult.Retry)
                {
                    UpdateDownLoad_Shown(sender, e);
                }
                else
                {
                    Close();
                }
            }
        }

 
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (wb.IsBusy)
            {
                wb.CancelAsync();
            }
            Close();
        }
    }
}
