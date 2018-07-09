using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using static KnaufinsulationWalls.Data.Data_WallsType;

namespace KnaufinsulationWalls
{
    public class PDFManager
    {
        private PdfDocument PDF = new PdfDocument();
        private XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
        private PdfPage PAGE;
        public String FileName { get; set; }


        public PDFManager(String filename, String DocTitle)
        {
            FileName = filename;
            PDF.Info.Title = DocTitle;
        }

        public void Save()
        {
            PDF.Save(FileName);
            Process.Start(FileName);
            Application.Exit();
        }
    
        private void DrawLine()
        {

        }
        XGraphics AddPage()
        {
            PAGE = PDF.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(PAGE);
            return gfx;
        }
        void AddLogo(XGraphics gfx,  System.Drawing.Image img,  double xPosition, double yPosition)
        {
            XImage xImage = XImage.FromGdiPlusImage(ImageManager.ResizeImage(img, 255, 72));
            gfx.DrawImage(xImage, xPosition, yPosition, xImage.PixelWidth, xImage.Height);
        }

        void AddImage(XGraphics gfx, String path, double xPosition, double yPosition)
        {
            XImage xImage = XImage.FromGdiPlusImage(ImageManager.ResizeImage(System.Drawing.Image.FromFile(path), 268, 277));
            gfx.DrawImage(xImage, xPosition, yPosition, xImage.PixelWidth, xImage.Height);
        }
            
        public void MakePDF(object obj)
        {
            var gr = AddPage();
            
            String FontFamilyName = "Arial";
            var item = obj as sLineWallsStruct;
            
            var pCurrLine = new XPoint(40, 45);
            
            {
                var font = new XFont(FontFamilyName, 10, XFontStyle.Regular, options);
                var text = "КНАУФ Инсулейшн";
                gr.DrawString(text, font, new XSolidBrush(XColor.FromArgb(0, 178, 236)), pCurrLine);

                pCurrLine.Y += gr.MeasureString(text, font).Height;
                pCurrLine.Y -= 10;

                text = "117513, Москва, Ленинский\r\n" +
                        "проспект, 119а, 5 - й этаж\r\n" +
                        "Тел.  +7(495) 933 - 61 - 30,\r\n" +
                        "факс: +7(495) 933 - 61 - 31\r\n" +
                        "info.russia@knaufinsulation.com";

                XTextFormatter tf = new XTextFormatter(gr);

                var sz = gr.MeasureString(text, font);
                sz.Height += 10;
                XRect rect = new XRect(pCurrLine, sz.ToXVector());
                gr.DrawRectangle(XBrushes.White, rect);
                tf.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                AddLogo(gr, Properties.Resources.logo, PAGE.Width - Properties.Resources.logo.Width, pCurrLine.Y);
                pCurrLine.Y += 72;


                AddImage(gr, FileManager.GetPathToRes(item.WallTypes.ImageName), 10f, 200);
                AddImage(gr, FileManager.GetPathToRes(item.WallTypes.ImageName), 10f, 200);
            }
            

            /*
            var pen = new XPen(XColor.FromArgb(0, 178, 236), 1);
            pen.DashStyle = XDashStyle.Solid;

            XPoint pFrom = pCurrLine;
            XPoint pTo = pCurrLine;
            pTo.X = PAGE.Width;
            gr.DrawLine(pen, pFrom, pTo);
            */

        }
    }
}
