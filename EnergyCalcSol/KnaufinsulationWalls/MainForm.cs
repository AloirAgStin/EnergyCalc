using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KnaufinsulationWalls.Data;

namespace KnaufinsulationWalls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

     
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        bool showReport = false;
        private WebClient wc = new WebClient();


        private string vVersionNew = "1.0.0";
        private string LinkToDownload = "";




        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalData.InitGlobalData();
            Text += ". Версия ";
            Text += GlobalData.VMain.ToString();
            Text += ".";
            Text += GlobalData.VMajor.ToString();
            Text += ".";
            Text += GlobalData.VMinor.ToString();

            Focus();
            bgCheckUpdates.RunWorkerAsync();
        }

        //start check update
        private void label5_Click(object sender, EventArgs e)
        {
            if (bgCheckUpdates.IsBusy) return;

            showReport = true;
            bgCheckUpdates.RunWorkerAsync();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Steps.StepFrame d = new Steps.StepFrame();
            d.Show(this);
        }


        private void bgCheckUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            bool IsEnable = IniFileManager.GetBoolKey("updates.enable");

            e.Result = (int)0;
            if (!IsEnable && !showReport)
                return;

            var pXmlVersionFile = IniFileManager.GetStringKey("updates.url");
            if (pXmlVersionFile == null)
                return;

            var pLastCheck = IniFileManager.GetStringKey("updates.lastCheck");
            DateTime tm = new DateTime();
            DateTime.TryParse(pLastCheck, out tm);

            if (tm.Day == DateTime.Now.Day && tm.Year == DateTime.Now.Year && tm.Month == DateTime.Now.Month && !showReport)
                return;

            try
            {
                //download file from internet and parse it to xml
                var url = new Uri(pXmlVersionFile);
                var fileData = wc.DownloadData(url);
                var xml = XElement.Parse(Encoding.UTF8.GetString(fileData));
                                
                
                var node = xml.FirstNode;

                var nVersion = xml.Element("Version");
                var nLinkToDownLoad = xml.Element("InstallerLink");

                if (nVersion == null || nLinkToDownLoad == null)
                {
                    throw new Exception("Отсуствует обязательный параметр Version или InstallerLink\r\nXML:\r\n" + xml);
                }
                
                var urlForDownLoad = nLinkToDownLoad.Value;
                if(urlForDownLoad == null)
                {
                    throw new Exception("Отсуствует обязательный параметр InstallerLink\r\nXML:\r\n" + xml);
                }

                var Version = nVersion.Value;
                if (Version == null)
                {
                    throw new Exception("Отсуствует обязательный параметр Version\r\nXML:\r\n" + xml);
                }

                int vM = 1, vMaj = 0 , vMin = 0;
                
                Helper.ParseVersionString(Version, out vM, out vMaj, out vMin);
                
                if (vM < GlobalData.VMain)
                    return;

                if (vMaj < GlobalData.VMajor)
                    return;

                if (vMin <= GlobalData.VMinor)
                    return;
                
                //если версия меньше 
                //Обновим время проверки
                
                LinkToDownload = urlForDownLoad;
                vVersionNew = Version;
            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);

                IniFileManager.WriteStringKey("updates", "lastCheck", DateTime.Today.ToShortDateString());

                return;
            }
            

            e.Result = (int)1;
        }




        private void bgCheckUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if ((int)e.Result == 1)
                {
                    UpdateForms.newVersion d = new UpdateForms.newVersion();
                    d.FileUrl = LinkToDownload;
                    d.lblVersion.Text += vVersionNew;
                    var dResult = d.ShowDialog(this);
                    if (dResult == DialogResult.OK)
                    {
                        UpdateForms.UpdateDownLoad d2 = new UpdateForms.UpdateDownLoad();
                        d2.vers = vVersionNew;
                        d2.link = LinkToDownload;
                        d2.ShowDialog(this);
                    }

                }
                else
                {
                    if (showReport)
                    {
                        showReport = false;
                        MessageBox.Show("У вас установлена последняя версия программы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                Helper.WriteLog(ex.Message);
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    
    }
}
