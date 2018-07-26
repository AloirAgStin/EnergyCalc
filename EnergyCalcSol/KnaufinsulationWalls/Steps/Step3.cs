using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using static KnaufinsulationWalls.Data.Data_WallsType;

namespace KnaufinsulationWalls.Steps
{
    public partial class Step3 : Form
    {
        private sLineWallsStruct GetCurrItem()
        {
            int ind = exListBox1.SelectedIndex;
            if (ind < 0) return null;

            return m_variants[ind];
        }

        private String HeaderUserData;
        private Font coreFont;
        public Step3()
        {
            InitializeComponent();
            coreFont = richTextBox1.Font;

        }
        
        private void Step3_Load(object sender, EventArgs e)
        {
          //  FiltrData();
        }



        private List<sLineWallsStruct> m_variants = new List<sLineWallsStruct>(); 
        public void FiltrData()
        {
            try
            {
                exListBox1.Items.Clear();

                var vMainFrom = Parent.Parent as StepFrame;
                var userData = vMainFrom.CalcStruct;
                
                HeaderUserData = MakeUserChoiseText(userData);
                lblUserData.Text = HeaderUserData;

                var filtredData = Data_WallsType.GetFilerData(userData);
                m_variants = Data_WallsType.GetLineStruct(filtredData);

                bool emptyVariants = true;
                if(m_variants.Count != 0)
                {
                    emptyVariants = false;
                    int num = 1;
                    foreach (var item in m_variants)
                    {
                        String text = "ВАРИАНТ " + num.ToString();
                        num++;


                        exListBox1.Items.Add(text);
                    }

                    if (exListBox1.Items.Count > 0)
                        exListBox1.SelectedIndex = 0;
                }

                lblEmptyVar.Visible = emptyVariants;
                btndw.Visible = !emptyVariants;
                btnEI.Visible = !emptyVariants;
                btnNG.Visible = !emptyVariants;
                btnRW.Visible = !emptyVariants;
                btnPDF.Visible = !emptyVariants;
                btnTex.Visible = !emptyVariants;


            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private String MakeUserChoiseText(CalcItem itm)
        {
            StringBuilder Text = new StringBuilder();
            Text.AppendFormat("Rw={0} дБ, EI={1}; Толщина перегродки Tп={2} мм", itm.Rw, itm.EI, itm.Tp);            
            return Text.ToString();
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                cp.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return cp;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            StepFrame vMainFrom = null;

            if (Parent == null)
                return;
            if (Parent.Parent == null)
                return;

            vMainFrom = Parent.Parent as StepFrame;

            vMainFrom.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                if (Parent.Parent != null)
                {
                    var MainFrom = Parent.Parent as StepFrame;
                    MainFrom.BackStep();
                }
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if(exListBox1.Items.Count == 0)
                    return;

                var itm = GetCurrItem();
                saveFDPDF.FileName = itm.Name + " " + itm.WallTypes.Rw.ToString() + " " + itm.WallTypes.EI.ToString() + " " + itm.WallTypes.Tp.ToString();
     
                if (saveFDPDF.ShowDialog() != DialogResult.OK)
                    return;

                String flName = saveFDPDF.FileName;
                PDFManager mng = new PDFManager(flName, "KnaufInsulation");
                mng.MakePDF(itm);
                mng.Save();

                var ret = MessageBox.Show("Документ успешно сохранен.\r\nОткрыть файл?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret == DialogResult.Yes)
                    Process.Start(flName);
            }
            catch(Exception ex)
            {
                Helper.WriteLog("Ошибка печати" + ex.Message);
                MessageBox.Show(ex.Message);
            }      
        }

        private void RichTextAddNewLine()
        {
            richTextBox1.SelectionCharOffset = -3;
            richTextBox1.SelectionFont = new Font(new Font(coreFont.FontFamily, 3), FontStyle.Regular);
            richTextBox1.AppendText("\r\n \r\n");
            richTextBox1.SelectionCharOffset = 0;

            richTextBox1.SelectionFont = coreFont;
        }

        private void exListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = GetCurrItem();
                var oldCharOffset = richTextBox1.SelectionCharOffset;

                var imgName = FileManager.GetPathToRes(item.WallTypes.ImageName);

                var img = ImageManager.LoadImageFromFile(imgName);


                pictureBox1.Image = img;


                richTextBox1.Clear();
                richTextBox1.SelectionFont = new Font(new Font(coreFont.FontFamily, 14), FontStyle.Bold | FontStyle.Underline);
                
                richTextBox1.AppendText(item.Name);
                
                richTextBox1.SelectionFont = new Font(new Font(coreFont.FontFamily, 12), FontStyle.Bold | FontStyle.Underline);
                richTextBox1.AppendText(" " + item.Description);

                RichTextAddNewLine();
                
                StringBuilder strB = new StringBuilder();
                strB.AppendFormat("В соответствии с СП 51.1330.2011 «Защита от шума», " +
                    "требуемый индекс изоляции шума для конструкции составляет {0} дБ"
                    , item.WallTypes.Rw);
                richTextBox1.AppendText(strB.ToString());

                RichTextAddNewLine();

                richTextBox1.AppendText("Для удовлетворения требований рекомендуется следующая конструкция перегородки:");

                RichTextAddNewLine();
                
                
                richTextBox1.SelectionFont = coreFont;
                richTextBox1.SelectionCharOffset = 2;
                strB = new StringBuilder();
                strB.AppendFormat(
                    "- Толщина перегородки: {0} мм\r\n" +
                    "- Толщина изоляции: {1} мм\r\n" +
                    "- Кол-во листов с одной стороны  - {2} {3}\r\n" +
                    "- Материал изоляции перегородки: минеральная вата\t\n   "

                    ,  item.WallTypes.Tp, item.WallTypes.Ti, item.WallTypes.N, item.GetNameExtVal());


                richTextBox1.AppendText(strB.ToString());
                
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                richTextBox1.AppendText("Knauf Insulation AS Акустическая перегородка");
                

                richTextBox1.Invalidate();
            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
            }
        }

        //download file
        private void onBtnFileDownLoadClick(object sender, EventArgs e)
        {
            var obj = sender as Button;

            int num = 0;
            Int32.TryParse((string)obj.Tag, out num);

            var item = GetCurrItem();
            if (item == null) return;

            if (num >= item.WallTypes._files.Count)
                return;

            var file = item.WallTypes._files.ElementAt(num);

            if (file.type == sFile._type.FileDescription)
                MessageBox.Show(file.ExtInfo, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                saveFileDialog1.FileName = obj.Text + " (" + item.Name + ")";

                var ret = saveFileDialog1.ShowDialog();
                if (ret != DialogResult.OK)
                    return;

                try
                {
                    var pathToDoc = FileManager.GetPathToDocs(file.FileName);
                    File.Copy(pathToDoc, saveFileDialog1.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Helper.WriteLog("Ошибка при сохранении файла " + file.FileName + " " + ex.Message);
                }

            }
        }


    }
}
