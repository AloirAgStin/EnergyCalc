using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnaufinsulationWalls
{
    public class PDFManager
    {

//        private Document _doc;
        private string _filename;
        private PDFManager()
        {
           // _doc = null;
            _filename = "";
        }

        ~PDFManager()
        {
           // if(_doc != null)
            //    _doc.Close();
        }
        public static PDFManager CreateDocument(string FileName)
        {
            var pdf = new PDFManager();

            pdf._filename = FileName;

            pdf.InitPrintA4(FileName);
            
            return pdf;
        }


        private void InitPrintA4(string filename)
        {
            string fn = filename;
            File.Delete(filename);

         //   _doc = new Document(PageSize.A4);

        }


        public void WriteVariantToPDF(string []items)
        {/*
            try
            {
                PdfWriter.GetInstance(_doc, new FileStream(_filename, FileMode.Create));

                _doc.Open();

                for (int i = 0; i < items.Length; i++)
                {


                    string val6 = (string)items.GetValue(i);
                    var el = new Paragraph(val6);
                    _doc.Add(el);_doc.Add(el);


                    var vvs = ImageManager.ResizeImage(Properties.Resources.step1, 200, 200);
                    Image pic = Image.GetInstance(vvs, System.Drawing.Imaging.ImageFormat.Png);
                    _doc.Add(pic);


                    _doc.NewPage();
                }


                if (_doc != null)
                    _doc.Close();

          

            }
            catch (DocumentException de)
            {
                throw new Exception(de.Message);
            }
            catch (IOException ioe)
            {
                throw new Exception(ioe.Message);
            }*/
        }

        protected string GetAutoPrintJs()
        {
            var script = new StringBuilder();
            script.Append("var pp = getPrintParams();");
            script.Append("pp.interactive= pp.constants.interactionLevel.full;");
            script.Append("pp.NumCopies=eval(2);");
            script.Append("print(pp);");
            return script.ToString();
        }
    }
}
