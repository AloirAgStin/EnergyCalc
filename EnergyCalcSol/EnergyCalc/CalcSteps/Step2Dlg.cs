using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EnergyCalc.CoreClass;
using XCtrl;

namespace EnergyCalc.CalcSteps
{
    public partial class Step2Dlg : ValidateDlg
    {
        List<sExtDataSource> buildingTypeList = new List<sExtDataSource>();
        public Step2Dlg()
        {
            DoubleBuffered = true;
            InitializeComponent();
            pbLogo.Parent = pbMainImg;

            err1.Icon = Properties.Resources.apply;
            err2.Icon = Properties.Resources.reject;

            buildingTypeList.Add(new sExtDataSource() { Code = 1, Name = "Здание без подвала. Неотапливаемая мансарда." });
            buildingTypeList.Add(new sExtDataSource() { Code = 2, Name = "Здание без подвала. Отапливаемая мансарда." });
            buildingTypeList.Add(new sExtDataSource() { Code = 3, Name = "Здание с неотапливаемым подвалом. Неотапливаемая мансарда." });
            buildingTypeList.Add(new sExtDataSource() { Code = 4, Name = "Здание с неотапливаемым подвалом. Отапливаемая мансарда." });
            buildingTypeList.Add(new sExtDataSource() { Code = 5, Name = "Здание с отапливаемым подвалом. Неотапливаемая мансарда." });
            buildingTypeList.Add(new sExtDataSource() { Code = 6, Name = "Здание с отапливаемым подвалом. Отапливаемая мансарда." });
            
            cbBuildingType.SetDataSource(buildingTypeList);
        }

        private void Step2Dlg_Load(object sender, EventArgs e)
        {
            InitBuildInfo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckControls();
        }

        public override bool CheckControls()
        {
            bool lRet = true;

            int TypeBuild = (int)cbBuildingType.SelectedValue;
            if (cbBuildingType.SelectedIndex == -1)
            {
                err1.SetError(cbBuildingType, "");
                err2.SetError(cbBuildingType, "Введите значение");
                lRet = false;
            }
            else
            {
                err1.SetError(cbBuildingType, "OK");
                err2.SetError(cbBuildingType, "");
            }

            if (!CheckEditVale(tbBLenght))
                lRet = false;

            if (!CheckEditVale(tbBWight))
                lRet = false;

            if (!CheckEditVale(tbBHeight))
                lRet = false;

            if (!CheckEditVale(tbBHSkat))
                lRet = false;

            if (TypeBuild != 0 && TypeBuild != 1)
            {
                if (!CheckEditVale(tbBHBasement))
                    lRet = false;
            }

            if (!CheckEditVale(tbBCountFloor))
                lRet = false;

            if (!CheckEditVale(tbTemp))
                lRet = false;

            //if (!lRet)
            //  MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return lRet;
        }

        public override void SaveData()
        {
            sCalcRec.BuildingType = (int)cbBuildingType.SelectedValue;
        }


        private bool CheckEditVale(Control item)
        {
            string errorText = "Введите значение";
            if (item.Text.Length == 0)
            {
                err1.SetError(item, "");
                err2.SetError(item, errorText);
                return false;
            }
            err2.SetError(item, "");
            err1.SetError(item, "OK");

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitBuildInfo();
        }


        private void InitBuildInfo()
        {
            
            int index = cbBuildingType.SelectedIndex;
            if (index == -1)
            {
                cbBuildingType.SelectedIndex = 0;
                index = cbBuildingType.SelectedIndex;
            }

            int type = (int)cbBuildingType.SelectedValue;

            pbHeatingType.Image = imlBuildsType.Images[type - 1];

            pbMainImg.Image = ResourceImage.GetBuildImageByType(type);
            if (type == 0 || type == 1)
            {
                tbBHBasement.Enabled = false;
                tbBHBasement.Text = "";
            }
            else
                tbBHBasement.Enabled = true;
        }


        private void cbHeatingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBuildInfo();
        }

        private void KeyPressTextBod(object sender, KeyPressEventArgs e)
        {
            if (tbBLenght.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }


        private string prevTempVal;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(tbTemp.Text);
                if (val > trackBar1.Maximum)
                    trackBar1.Value = trackBar1.Maximum;
                else
                if (val < trackBar1.Minimum)
                    trackBar1.Value = trackBar1.Minimum;
                else
                    trackBar1.Value = val;

            }
            catch (Exception ex)
            {
                //todo
                //MessageBox.Show()
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbTemp.Text = trackBar1.Value.ToString();
        }

        private void OnKillLastControlFocus(object sender, EventArgs e)
        {
/*            var f = (CalcForm)Parent.Parent;

            try
            {
                f.Focus();
                f.pnlNavigation.SelectNextControl(null, true, true, true, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  */       

        }

    }
}
