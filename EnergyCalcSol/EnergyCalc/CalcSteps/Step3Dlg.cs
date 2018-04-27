using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyCalc.CoreClass;

namespace EnergyCalc.CalcSteps
{
    public struct heatingType
    {
        public string Name { get; set; }
        public int ItemIndex { get; set; }
    }
    public partial class Step3Dlg : ValidateDlg
    {
        public List<heatingType> heatingTypeList = new List<heatingType>();
        public BindingSource cbHeatingTypeBindingSource = new BindingSource();

        public Step3Dlg()
        {
            InitializeComponent();
            pbLogo.Parent = extPictureBox1;
        }

        private void Step3Dlg_Load(object sender, EventArgs e)
        {
            heatingTypeList.Add(new heatingType() { ItemIndex = 0, Name = "Газовое отопление" });
            heatingTypeList.Add(new heatingType() { ItemIndex = 1, Name = "Угольное отопление" });
            heatingTypeList.Add(new heatingType() { ItemIndex = 2, Name = "Электрическое отопление" });
            heatingTypeList.Add(new heatingType() { ItemIndex = 3, Name = "Жидкотопливное отопление" });
            heatingTypeList.Add(new heatingType() { ItemIndex = 4, Name = "Центральное отопление" });
            heatingTypeList.Add(new heatingType() { ItemIndex = 5, Name = "Дровяное  отопление" });

            cbHeatingTypeBindingSource.DataSource = heatingTypeList;
            cbHeatingType.DataSource = cbHeatingTypeBindingSource;
            cbHeatingType.DisplayMember = "Name";
            cbHeatingType.ValueMember = "ItemIndex";

            onChangeHeatingType(null, null);


        }

        private void onChangeHeatingType(object sender, EventArgs e)
        {
            if (cbHeatingType.SelectedIndex != -1)
            {
                int hValue = (int)cbHeatingType.SelectedValue;
                pbHeatingType.Image = imlHeatingType.Images[hValue];

                string val = "Тариф, ";
                if (hValue == 0)
                    lblTarif.Text = val + "грн./м3";
                else
                if (hValue == 1)
                    lblTarif.Text = val + "грн./тонна";
                else
                if (hValue == 2)
                    lblTarif.Text = val + "грн./кВт*час";
                else
                if (hValue == 3)
                    lblTarif.Text = val + "грн./тонна";
                else
                if (hValue == 4)
                    lblTarif.Text = val + "грн./Гкал.";
                else
                if (hValue == 5)
                    lblTarif.Text = val + "грн./м3";
            }
        }


        string previousInput = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^-{0,1}\d+\.{0,2}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(textBox1.Text);
            if (m.Success || textBox1.Text.Length == 0)
            {
                previousInput = textBox1.Text;
            }
            else
            {
                textBox1.Text = previousInput;
            }
        }
 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }


    }

}