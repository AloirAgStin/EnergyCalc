using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace KnaufinsulationWalls.Steps
{
    public partial class Step3 : Form
    {
        public Step3()
        {
            InitializeComponent();
        }
        
        private String HeaderUserData;

        private void Step3_Load(object sender, EventArgs e)
        {
            try
            {
                exListBox1.Items.Clear();
                
                var vMainFrom = Parent.Parent as StepFrame;      
                var userData = vMainFrom.CalcStruct;

                HeaderUserData = MakeUserChoiseText(userData);
                lblUserData.Text = HeaderUserData;
                
                var filtredData = Data_WallsType.GetFilerData(userData);
                



                int num = 1;
                foreach(var item in filtredData)
                {
                    String text = "ВАРИАНТ " + num.ToString();
                    num++;


                    exListBox1.Items.Add(text);
                }

                if(exListBox1.Items.Count > 0)
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
            Text.AppendFormat("Rw={0} дБ, EI={2}; Толщина перегродки Tп={2} мм", itm.Rw, itm.EI, itm.Tp);            
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
        
    }
}
