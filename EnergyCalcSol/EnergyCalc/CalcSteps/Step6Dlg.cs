using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyCalc.CoreClass;

namespace EnergyCalc.CalcSteps
{
    public partial class Step6Dlg : ValidateDlg
    {
        public Step6Dlg()
        {
            InitializeComponent();
        }

        private void FinishDlg_Load(object sender, EventArgs e)
        {
            string textRegion = "Район строительства: "  + GetPrent().Rec._region.Name;
            pbHouse.Image = ResourceImage.GetBuildImageByType(GetPrent().Rec.st2_BuildingType);


            var Record = GetPrent().Rec;
            try
            {
                lbBaseData.Items.Add(textRegion);
                lbBaseData.Items.Add("Параметры здания:");

                //load step 2
                lbBaseData.Items.Add("      длина: " + Record.st2_Lenght.ToString() + " м");
                lbBaseData.Items.Add("      ширина: " + Record.st2_Wight.ToString() + " м");
                lbBaseData.Items.Add("      высота до ската: " + Record.st2_Height  + " м");
                lbBaseData.Items.Add("      высота до конька: " + Record.st2_Konek.ToString() + " м");
                lbBaseData.Items.Add("      высота подвала: " + Record.st2_basement.ToString() +" м");
                lbBaseData.Items.Add("      количество этажей: " + Record.st2_level.ToString() + " м");
                lbBaseData.Items.Add("      температурный режим: " + Record.st2_temperature.ToString() + "°С");

                //load step 3
                lbBaseData.Items.Add("      отопление: Газовое отопление");
                lbBaseData.Items.Add("      тариф: 0.7254 грн./м3");
            }
            catch (Exception)
            {

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cmPrint.Show(btnPrint, new Point(0, btnPrint.Size.Height));
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument;
            printDialog1.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font drawFont = new Font("Sitka Small", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("Тестовая печать", drawFont, drawBrush, 10, 10);
            e.Graphics.DrawImage(ResourceImage.GetBuildImageByType(GetPrent().Rec.st2_BuildingType), 10, 40);
        }
    }
}
