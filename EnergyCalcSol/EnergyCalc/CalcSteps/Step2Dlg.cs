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
        public Step2Dlg()
        {
            DoubleBuffered = true;
            InitializeComponent();
            pbLogo.Parent = pbMainImg;

            err1.Icon = Properties.Resources.apply;
            err2.Icon = Properties.Resources.reject;

            cbBuildingType.SetDataSource(Step2Manager.GetBuilingList());
        }

        private void Step2Dlg_Load(object sender, EventArgs e)
        {
            InitBuildInfo();
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

            List<Control> focusCtr = new List<Control>();

            if (!CheckEditVale(tbBLenght))
            {
                focusCtr.Add(tbBLenght);
                lRet = false;
            }

            if (!CheckEditVale(tbBWight))
            {
                focusCtr.Add(tbBWight);
                lRet = false;
            }

            if (!CheckEditVale(tbBHeight))
            {
                focusCtr.Add(tbBHeight);
                lRet = false;
            }

            if (!CheckEditVale(tbBSkat))
            {
                focusCtr.Add(tbBSkat);
                lRet = false;
            }

            if (TypeBuild != 0 && TypeBuild != 1)
            {
                if (!CheckEditVale(tbBHBasement))
                {
                    lRet = false;
                    focusCtr.Add(tbBHBasement);
                }
            }

            if (!CheckEditVale(tbBCountFloor, false))
            {
                focusCtr.Add(tbBCountFloor);
                lRet = false;
            }

            if (!CheckEditVale(tbTemp))
            {
                focusCtr.Add(tbTemp);
                lRet = false;
            }

            if (focusCtr.Count > 0)
                focusCtr[0].Focus();
            return lRet;
        }

        public override void SaveData()
        {
            GetPrent().Rec.st2_BuildingType = (int)cbBuildingType.SelectedValue;

            GetPrent().Rec.st2_Lenght     = SafeConvert.ToDouble(tbBLenght.Text);
            GetPrent().Rec.st2_Wight      = SafeConvert.ToDouble(tbBWight.Text);
            GetPrent().Rec.st2_Height     = SafeConvert.ToDouble(tbBHeight.Text);
            GetPrent().Rec.st2_Konek      = SafeConvert.ToDouble(tbBSkat.Text);
            GetPrent().Rec.st2_basement   = SafeConvert.ToDouble(tbBHBasement.Text);
            GetPrent().Rec.st2_level      = SafeConvert.toInt32(tbBCountFloor.Text);
            GetPrent().Rec.st2_temperature = SafeConvert.toInt32(tbTemp.Text);
        }


        private bool CheckEditVale(Control item, bool IsDouble = true)
        {
            string errorText = "Введите значение";
            if(IsDouble)
            {
                if (SafeConvert.ToDouble(item.Text) == 0)
                {
                    err1.SetError(item, "");
                    err2.SetError(item, errorText);
                    return false;
                }
            }
            else
            {
                if (SafeConvert.toInt32(item.Text) == 0)
                {
                    err1.SetError(item, "");
                    err2.SetError(item, errorText);
                    return false;
                }
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int val = 15;
            val = SafeConvert.toInt32(tbTemp.Text);
            
            if (val > trackBar1.Maximum)
                trackBar1.Value = trackBar1.Maximum;
            else
            if (val < trackBar1.Minimum)
                trackBar1.Value = trackBar1.Minimum;
            else
                trackBar1.Value = val;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbTemp.Text = trackBar1.Value.ToString();
        }

        private void KeyPressTextBod2(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void KeyPressTextBod(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void tbTemp_Leave(object sender, EventArgs e)
        {
            GetPrent().NextFocus();
            //Parent.Parent.SelectNextControl(null, true, true, true, true);
        }
    }
}
