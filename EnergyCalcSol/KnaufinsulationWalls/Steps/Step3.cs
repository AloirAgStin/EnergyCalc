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
    public partial class Step3 : FormExt
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

        private Size defImgSize = new Size();
        private Size defImgMinSz= new Size();


        private Size defRichSize = new Size();


        private void Step3_Load(object sender, EventArgs e)
        {
            defRichSize = richTextBox1.Size;
            defImgSize = pictureBox1.Size;
            PointStart = pictureBox1.Location;
            defImgMinSz = pictureBox1.MinimumSize;

            var szRich = richTextBox1.Size;
            szRich.Width = 0;
            richTextBox1.Size = szRich;

            var szPict = pictureBox1.Size;
            szPict.Width = 0;
            pictureBox1.Size = szPict;
        }
        private void exListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var szRich = richTextBox1.Size;
            szRich.Width = 0;
            richTextBox1.Size = szRich;

            var szPict = pictureBox1.Size;
            szPict.Width = 0;
            pictureBox1.Size = szPict;

            timer1.Start();
        }

        int stepCount = 0;
        int stepDrawR = 50;
        int stepDrawP = 50;

        private void onTimer(object sender, EventArgs e)
        {
            if(stepCount == 0)
            {
                richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
               // richTextBox1.WordWrap = false;

                var maxSize = defRichSize;
                if (defImgSize.Width >= maxSize.Width)
                    maxSize = defImgSize;

                stepCount = 8;


                stepDrawP = defImgSize.Width/ stepCount;
                stepDrawR = defRichSize.Width / stepCount;

                OnChangeContex();
            }

            int intOK = 0;
            if(pictureBox1.Size.Width < defImgSize.Width)
            {
                var s = pictureBox1.Size;
                s.Width += stepDrawR;
                pictureBox1.Size = s;
            }
            else
            {
                pictureBox1.Size = defImgSize;
                intOK++;
            }

            if (richTextBox1.Size.Width < defRichSize.Width)
            {
                var s = richTextBox1.Size;
                s.Width += stepDrawP;
                richTextBox1.Size = s;
            }
            else
            {
                richTextBox1.Size = defRichSize;
                intOK++;
            }

            if(intOK == 2)
            {

                //pictureBox1.MinimumSize = defImgMinSz;
                stepCount = 0;
                timer1.Stop();
                richTextBox1.WordWrap = true;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;

            }
        }

        public override void AfterShow()
        {
            FiltrData();
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
            Text.AppendFormat("={0} дБ, EI={1}", itm.Rw, itm.EI);

            if(itm.Tp > 0)
                Text.AppendFormat("; Толщина перегродки Tп={0} мм",itm.Tp);

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
            richTextBox1.SelectionFont = new Font(new Font(coreFont.Name, 3), FontStyle.Regular);
            richTextBox1.AppendText("\r\n\r\n");
            richTextBox1.SelectionCharOffset = 0;

            richTextBox1.SelectionFont = coreFont;
            
        }

        

        private void OnChangeContex()
        {
            try
            {
                var item = GetCurrItem();
                var oldCharOffset = richTextBox1.SelectionCharOffset;

                var imgName = FileManager.GetPathToRes(item.WallTypes.ImageName);

                var img = ImageManager.LoadImageFromFile(imgName);


                pictureBox1.Image = img;


                richTextBox1.Clear();
                richTextBox1.SelectionFont = new Font(new Font(coreFont.Name, 14), FontStyle.Bold | FontStyle.Underline);

                richTextBox1.AppendText(item.Name);

                richTextBox1.SelectionFont = new Font(new Font(coreFont.Name, 12), FontStyle.Bold | FontStyle.Underline);
                richTextBox1.AppendText(" " + item.Description);



                RichTextAddNewLine();


                richTextBox1.SelectionFont = new Font(coreFont.Name, 11);

                StringBuilder strB = new StringBuilder();
                strB.AppendFormat("В соответствии с СП 51.1330.2011 «Защита от шума», " +
                    "индекс изоляции шума конструкции составляет {0} дБ"
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
                    "- Материал изоляции перегородки: минеральная вата\r\n   "
                    , item.WallTypes.Tp, item.WallTypes.Ti, item.WallTypes.N, item.GetNameExtVal());


                richTextBox1.AppendText(strB.ToString());

                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                richTextBox1.AppendText("Knauf Insulation AS Акустическая перегородка");
                
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
                var nm = obj.Text;

                var charsToRemove = new string[] { "\r", "\n"};
                foreach (var c in charsToRemove)
                {
                    nm = nm.Replace(c, string.Empty);
                }
                nm = nm.Replace("-", string.Empty);


                saveFileDialog1.FileName = nm + " (" + item.Name + ")";

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var rect = panelLeftSide.ClientRectangle;
            rect.Inflate(-2, -2);
            ControlPaint.DrawBorder(e.Graphics, rect,
                Color.FromArgb(208, 211, 212), 0, ButtonBorderStyle.Solid,
                Color.FromArgb(208, 211, 212), 1,
                ButtonBorderStyle.Solid, Color.FromArgb(208, 211, 212), 1,
                ButtonBorderStyle.Solid, Color.FromArgb(208, 211, 212), 0, ButtonBorderStyle.Solid
                                    );

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panelLeftSide.Invalidate();
        }

        public Point PointStart;

        private void Step3_Resize(object sender, EventArgs e)
        {
            if(pictureBox1.Size.Width > 50)
                defImgSize = pictureBox1.Size;
            else
            {
                pictureBox1.Size = defImgSize;

            }

            if (richTextBox1.Size.Width > 50)
            {
                defRichSize = richTextBox1.Size;
            }
            else
            {
                richTextBox1.Size = defRichSize;

            }
            int border = 6;
            int imgW = pictureBox1.Size.Width < defImgSize.Width ? defImgSize.Width : pictureBox1.Width;

            var pt = new Point(pictureBox1.Location.X + imgW + border, 85);

            if (pt.X < PointStart.X - border)
            {
                richTextBox1.Location = PointStart;
            }
            else
                richTextBox1.Location = pt;
            richTextBox1.Width = Width - richTextBox1.Location.X - 25;
        }

        private void Step3_ResizeBegin(object sender, EventArgs e)
        {
            int n = 4;

        }
    }
}
