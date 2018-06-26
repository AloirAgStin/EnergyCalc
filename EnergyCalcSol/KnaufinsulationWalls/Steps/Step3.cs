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

        private void Step3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 30; i ++)
            exListBox1.Items.Add("ВАРИАНТ " + i.ToString());

            exListBox1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDownLoadButton("Имя" , 1);
        }

        private void AddDownLoadButton(string name, int fileIndex)
        {
            var btn = new Button();

            btn.TextAlign = ContentAlignment.TopCenter;
            btn.Text = "Значение 1";
            btn.Font = new Font("Lato", 10, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(0, 178, 236);

            btn.Size = new Size(109, 74);
            btn.Image = Properties.Resources.dw_file;
            btn.ImageAlign = ContentAlignment.BottomCenter;
            btn.BackColor = Color.WhiteSmoke;
            btn.Tag = fileIndex;

            btnLayOut.Controls.Add(btn);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            return;
            string fn = @"d:\test_pdf.pdf";
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
                "on any System.Drawing.Graphics object.", font, XBrushes.Black, x, y);
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
            XRect rcImage = new XRect(100, y, 100, 100 * Math.Sqrt(2));
            gfx.DrawRectangle(XBrushes.Snow, rcImage);
         //   gfx.DrawImage(XPdfForm.FromFile("d:\\2.jpg"), rcImage);
            gfx.Restore(state);
            
            /*
            {
                string fn = @"d:\test_pdf.pdf";
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "My First PDF";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

                graph.DrawString("This is my first PDF document",
                    font, XBrushes.Black,
                    new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);

                graph.DrawImage(ImageManager.ResizeImage(Properties.Resources.step1, 100, 100), new Point(10, 10));

                PdfPage pdfPage2 = pdf.AddPage();

                XGraphics graph2 = XGraphics.FromPdfPage(pdfPage2);
                graph2.DrawImage(Properties.Resources.LogoMini, new Point(10, 10));


                string pdfFilename = fn;
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }

            return;
            var d = PDFManager.CreateDocument(fn);
           
            List<string> l = new List<string>();
            l.Insert(0, "test 1");
            l.Insert(1, "test 2");
            l.Insert(2, "test 3");
            l.Insert(3, "test 4");

            d.WriteVariantToPDF(l.ToArray());
            */
        }
    }
}
