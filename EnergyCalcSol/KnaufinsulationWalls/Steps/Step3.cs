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

        public Step3()
        {
            InitializeComponent();
            coreFont = richTextBox1.Font;

        }

        private String HeaderUserData;



        Font coreFont;
        private void Step3_Load(object sender, EventArgs e)
        {
            FiltrData();            
        }

        private List<sLineWallsStruct> m_variants = new List<sLineWallsStruct>(); 
        private void FiltrData()
        {
            try
            {
                exListBox1.Items.Clear();

                var vMainFrom = Parent.Parent as StepFrame;
                var userData = vMainFrom.CalcStruct;

                //todo del
                userData.Tp = 125;
                userData.EI = 30;
                userData.Rw = 45;
                //====================

                HeaderUserData = MakeUserChoiseText(userData);
                lblUserData.Text = HeaderUserData;

                var filtredData = Data_WallsType.GetFilerData(userData);
                m_variants = Data_WallsType.GetLineStruct(filtredData);
                

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
            return;
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);

            XRect rect;
            XPen pen;
            double x = 50, y = 100;
            XFont fontH1 = new XFont("Times", 18, XFontStyle.Bold);
            XFont font = new XFont("Times", 12);
            XFont fontItalic = new XFont("Times", 12, XFontStyle.BoldItalic);
            double ls = font.GetHeight(gfx);
            

            // Draw some text
            gfx.DrawString("Create PDF on the fly with PDFsharp",
                fontH1, XBrushes.Black, x, x);



            gfx.DrawString("With PDFsharp you can use the same code to draw graphic, " +
                "text and images on different targets.", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("The object used for drawing is the XGraphics object.",
                font, XBrushes.Black, x, y);
            y += 2 * ls;

            // Draw an arc
            pen = new XPen(XColors.Red, 4);
            pen.DashStyle = XDashStyle.Dash;
            gfx.DrawArc(pen, x + 20, y, 100, 60, 150, 120);

            // Draw a star
            XGraphicsState gs = gfx.Save();
            gfx.TranslateTransform(x + 140, y + 30);
            for (int idx = 0; idx < 360; idx += 10)
            {
                gfx.RotateTransform(10);
                gfx.DrawLine(XPens.DarkGreen, 0, 0, 30, 0);
            }
            gfx.Restore(gs);

            // Draw a rounded rectangle
            rect = new XRect(x + 230, y, 100, 60);
            pen = new XPen(XColors.DarkBlue, 2.5);
            XColor color1 = XColor.FromKnownColor(KnownColor.DarkBlue);
            XColor color2 = XColors.Red;
            XLinearGradientBrush lbrush = new XLinearGradientBrush(rect, color1, color2,
              XLinearGradientMode.Vertical);
            gfx.DrawRoundedRectangle(pen, lbrush, rect, new XSize(10, 10));

            // Draw a pie
            pen = new XPen(XColors.DarkOrange, 1.5);
            pen.DashStyle = XDashStyle.Dot;
            gfx.DrawPie(pen, XBrushes.Blue, x + 360, y, 100, 60, -130, 135);

            // Draw some more text
            y += 60 + 2 * ls;
            gfx.DrawString("With XGraphics you can draw on a PDF page as well as " +
                "on any System.Drawing.Graphics object. asdf sadf asdf asdf asdf asdf ", font, XBrushes.Black, x, y);
            y += ls * 1.1;
            gfx.DrawString("Use the same code to", font, XBrushes.Black, x, y);
            x += 10;
            y += ls * 1.1;
            gfx.DrawString("• draw on a newly created PDF page", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("• draw above or beneath of the content of an existing PDF page",
                font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("• draw in a window", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("• draw on a printer", font, XBrushes.Black, x, y);
            y += ls;
            gfx.DrawString("• draw in a bitmap image", font, XBrushes.Black, x, y);
            x -= 10;
            y += ls * 1.1;
            gfx.DrawString("You can also import an existing PDF page and use it like " +
                "an image, e.g. draw it on another PDF page.", font, XBrushes.Black, x, y);
            y += ls * 1.1 * 2;
            gfx.DrawString("Imported PDF pages are neither drawn nor printed; create a " +
                "PDF file to see or print them!", fontItalic, XBrushes.Firebrick, x, y);
            y += ls * 1.1;
            gfx.DrawString("Below this text is a PDF form that will be visible when " +
                "viewed or printed with a PDF viewer.", fontItalic, XBrushes.Firebrick, x, y);
            y += ls * 1.1;
            XGraphicsState state = gfx.Save();

            XRect rcImage = new XRect(100, y, 200, 132);
            gfx.DrawRectangle(XBrushes.Snow, rcImage);

            var pt = FileManager.GetPathToRes("43.jpg");
            var im2 = XImage.FromFile(pt);
                
            gfx.Restore(state);
            gfx.DrawImage(im2, 100, 100);
            
            string fn = @"d:\testPageDocument.pdf";
            pdf.Save(fn);
            Process.Start(fn);
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

                var img = Image.FromFile(FileManager.GetPathToRes(item.WallTypes.ImageName));
                pictureBox1.Image = img;


                richTextBox1.Clear();
                richTextBox1.SelectionFont = new Font(new Font(coreFont.FontFamily, 14), FontStyle.Bold | FontStyle.Underline);

                //richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);

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
                    //  "Материал изоляции перегородки: минеральная вата"

                    ,  item.WallTypes.Tp, item.WallTypes.Ti, item.WallTypes.N, item.GetNameExtVal());


                richTextBox1.AppendText(strB.ToString());
                
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
                richTextBox1.AppendText("KnaufInsulation AS Акустическая перегородка");
                

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
