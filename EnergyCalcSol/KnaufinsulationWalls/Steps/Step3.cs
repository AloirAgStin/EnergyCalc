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
            listBox1.SelectedIndex = 0;
        }

      
        private void label4_Click(object sender, EventArgs e)
        {
            var MainFrom = Parent.Parent.Parent as StepFrame;
            MainFrom.BackStep();
        }

        private void Step3_Load(object sender, EventArgs e)
        {

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
            string fn = @"d:\test_pdf.pdf";
                 PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            graph.DrawString("This is my first PDF document", 
                font, XBrushes.Black, 
                new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);

            graph.DrawImage(ImageManager.ResizeImage(Properties.Resources.step1, 100, 100),  new Point(10,10 ) );

            PdfPage pdfPage2 = pdf.AddPage();

            XGraphics graph2 = XGraphics.FromPdfPage(pdfPage2);
            graph2.DrawImage(Properties.Resources.LogoMini, new Point(10, 10));


            string pdfFilename = fn;
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);


            return;
            var d = PDFManager.CreateDocument(fn);
           
            List<string> l = new List<string>();
            l.Insert(0, "test 1");
            l.Insert(1, "test 2");
            l.Insert(2, "test 3");
            l.Insert(3, "test 4");

            d.WriteVariantToPDF(l.ToArray());

        }
    }
}
