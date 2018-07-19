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
        public String FileName { get; set; }


        public PDFManager(String filename, String DocTitle)
        {
            FileName = filename;
            PDF.Info.Title = DocTitle;

            PDF.Info.Author = "KnaufInsulation";
            PDF.Info.CreationDate = DateTime.Now;
            PDF.Info.Subject = DocTitle;
        }

        public void Save()
        {
            PDF.Save(FileName);
       }
 
        PdfPage AddPage()
        {
            return PDF.AddPage();
        }

        public void MakePDF(object obj)
        {
            var item = obj as sLineWallsStruct;

            var PAGE = AddPage();
            var gr = XGraphics.FromPdfPage(PAGE);
            var backColor = XBrushes.White;

            String FontFamilyName = "Arial";
            
            var pCurrLine = new XPoint(40, 45);

            {
                var font = new XFont(FontFamilyName, 10, XFontStyle.Regular, options);
                var text = "КНАУФ Инсулейшн";
                gr.DrawString(text, font, new XSolidBrush(XColor.FromArgb(0, 178, 236)), pCurrLine);

                pCurrLine.Y += gr.MeasureString(text, font).Height;
                pCurrLine.Y -= 7;

                {
                    text = "117513, Москва, Ленинский\r\n" +
                           "проспект, 119а, 5 - й этаж\r\n" +
                           "Тел.  +7(495) 933 - 61 - 30,\r\n" +
                           "факс: +7(495) 933 - 61 - 31\r\n" +
                           "info.russia@knaufinsulation.com";

                    XTextFormatter tf = new XTextFormatter(gr);
                    var sz = gr.MeasureString(text, font);
                    sz.Height += 10;
                    XRect rect = new XRect(pCurrLine, sz.ToXVector());
                    gr.DrawRectangle(backColor, rect);
                    tf.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                    var logo = XImage.FromGdiPlusImage(Properties.Resources.logo);
                    gr.DrawImage(logo, 370, pCurrLine.Y, 180, 50);

                    pCurrLine.Y += 75;

                }

            }

            gr.DrawLine(new XPen(XColor.FromArgb(0, 178, 236)), new Point(40, (int)pCurrLine.Y), new Point((int)(PAGE.Width.Point - pCurrLine.X), (int)pCurrLine.Y));
            pCurrLine.Y += 50;

            {
                var f = new XFont(FontFamilyName, 16, XFontStyle.Regular | XFontStyle.Bold, options);
                var ResultText = "РЕЗУЛЬТАТ ПОДБОРА ПЕРЕГОРОДОК ПОД ОБЪЕКТ";
                gr.DrawString(ResultText, f, XBrushes.Black, new Point((int)pCurrLine.X * 2, (int)pCurrLine.Y));

            }

            pCurrLine.Y += 20;

            {
                var br = new XSolidBrush(XColor.FromArgb(220, 220, 220));
                XRect rect = new XRect(pCurrLine.X, pCurrLine.Y, (int)(PAGE.Width.Point - pCurrLine.X * 2), 50);
                gr.DrawRectangle(br, rect);
                
                br = new XSolidBrush(XColor.FromArgb(0, 178, 236));
                pCurrLine.Y += 5;
                var f = new XFont(FontFamilyName, 14, XFontStyle.Regular, options);
                var ResultText = "ИСХОДНЫЕ ДАННЫЕ";
                gr.DrawString(ResultText, f, br, new Point((int)pCurrLine.X + 10, (int)pCurrLine.Y + (int)gr.MeasureString(ResultText, f).Height + 2));

                pCurrLine.Y += gr.MeasureString(ResultText, f).Height + 5;

                StringBuilder str = new StringBuilder();
                str.AppendFormat("Rw={0}дБ, EI={1}; Толщина перегородки Тп={2}мм", item.WallTypes.Rw, item.WallTypes.EI, item.WallTypes.Tp);

                ResultText = str.ToString();

                br = new XSolidBrush(XColor.FromArgb(140, 145, 149));
                gr.DrawString(ResultText, f, br, new Point((int)pCurrLine.X + 10, (int)pCurrLine.Y + (int)gr.MeasureString(ResultText, f).Height + 2));

                pCurrLine.Y += 40;
            }

            var img = ImageManager.LoadImageFromFile(FileManager.GetPathToRes(item.WallTypes.ImageName));

            var mainImg = XImage.FromGdiPlusImage(img);
            gr.DrawImage(mainImg, pCurrLine.X, pCurrLine.Y, 228, 237);

            {
                var pointP = pCurrLine;
                pointP.Y += 10;
                pointP.X += 240;
                var pointX = pointP.X;

                var ResultText = item.Name;
                var br = Brushes.Black;
                {
                    var f = new XFont(FontFamilyName, 12, XFontStyle.Bold | XFontStyle.Underline, options);
                    gr.DrawString(ResultText, f, br, new Point((int)pointP.X, (int)pointP.Y));

                    pointP.Y += (int)gr.MeasureString(ResultText, f).Height / 2;
                }



                {
                    var f = new XFont(FontFamilyName, 11, XFontStyle.Regular, options);
                    ResultText = item.Description;

                    var tf = new XTextFormatter(gr);
                    var sz = gr.MeasureString(ResultText, f, XStringFormats.TopLeft);
                    
                    var rect2 = new XRect(pointP, new XPoint((int)(PAGE.Width.Point - pCurrLine.X), pointP.Y + sz.Height ));

                    int coef = (int)Math.Ceiling(sz.Width / rect2.Width) + 1;

                    rect2.Height *= 1.1;
                    rect2.Height *= coef;

                    gr.DrawRectangle(backColor, rect2);
                    tf.DrawString(ResultText, f, XBrushes.Black, rect2, XStringFormats.TopLeft);
                    
                    pointP.Y += rect2.Height;

                }

                {
                    var f = new XFont(FontFamilyName, 11, XFontStyle.Regular, options);
                    StringBuilder strB = new StringBuilder();
                    strB.AppendFormat("В соответствии с СП 51.1330.2011 «Защита от\r\nшума»," +
                        "требуемый индекс изоляции шума для конструкции составляет {0} дБ"
                        , item.WallTypes.Rw);
                    ResultText = strB.ToString();

                    XTextFormatter tf = new XTextFormatter(gr);
                    var sz = gr.MeasureString(ResultText, f);
                    sz.Height += 10;
                    XRect rect = new XRect(pointP, new XPoint((int)(PAGE.Width.Point - pCurrLine.X), pointP.Y + sz.Height * 1.2));

                    gr.DrawRectangle(backColor, rect);
                    tf.DrawString(ResultText, f, XBrushes.Black, rect, XStringFormats.TopLeft);


                    pointP.Y += rect.Height;
                }

                {
                    var f = new XFont(FontFamilyName, 11, XFontStyle.Regular, options);

                    var strB = new StringBuilder();

                    strB.AppendFormat(
                        "- Толщина перегородки: {0} мм\r\n" +
                        "- Толщина изоляции: {1} мм\r\n" +
                        "- Кол-во листов с одной стороны  - {2} {3}\r\n" +
                        "- Материал изоляции перегородки: минеральная вата"
                        , item.WallTypes.Tp, item.WallTypes.Ti, item.WallTypes.N, item.GetNameExtVal());
                    ResultText = strB.ToString();

                    XTextFormatter tf = new XTextFormatter(gr);
                    var sz = gr.MeasureString(ResultText, f);
                    sz.Height += 10;
                    XRect rect = new XRect(pointP, sz);
                    gr.DrawRectangle(XBrushes.White, rect);
                    tf.DrawString(ResultText, f, XBrushes.Black, rect, XStringFormats.TopLeft);
                    pointP.Y += sz.Height;
                }

                {
                    var f = new XFont(FontFamilyName, 11, XFontStyle.Regular | XFontStyle.Underline, options);
                    gr.DrawString("KnaufInsulation AS Акустическая перегородка", f, XBrushes.Black, pointP);

                }
            }
            
            //bottom page
            pCurrLine.Y = 750;
            gr.DrawLine(new XPen(XColor.FromArgb(0, 178, 236)), new Point(40, (int)pCurrLine.Y), new Point((int)(PAGE.Width.Point - pCurrLine.X), (int)pCurrLine.Y));
            pCurrLine.Y += 15;

            {
                pCurrLine.Y += 5;
                var f = new XFont(FontFamilyName, 14, XFontStyle.Regular, options);
                var ResultText = "ГОРЯЧАЯ ЛИНИЯ";
                gr.DrawString(ResultText, f, Brushes.Black, PAGE.Width - pCurrLine.X - gr.MeasureString(ResultText, f).Width, (int)pCurrLine.Y);

                pCurrLine.Y += gr.MeasureString(ResultText, f).Height;
                pCurrLine.Y += 5;

                var br = new XSolidBrush(XColor.FromArgb(0, 178, 236));
                f = new XFont(FontFamilyName, 16, XFontStyle.Regular, options);
                ResultText = "8-800-700-600-5";
                gr.DrawString(ResultText, f, br, PAGE.Width - pCurrLine.X - gr.MeasureString(ResultText, f).Width, (int)pCurrLine.Y);

                pCurrLine.Y += gr.MeasureString(ResultText, f).Height * 0.75;
                f = new XFont(FontFamilyName, 10, XFontStyle.Regular, options);
                ResultText = "Звонок бесплатный";
                gr.DrawString(ResultText, f, Brushes.Black, PAGE.Width - pCurrLine.X - gr.MeasureString(ResultText, f).Width, (int)pCurrLine.Y);
            }

        }
       

    }
}
