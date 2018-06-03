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
    public partial class Step1Dlg : ValidateDlg
    {
        public Step1Dlg()
        {
            InitializeComponent();

        }
        List<XCtrl.sGroupComboBoxItem> dt = new List<XCtrl.sGroupComboBoxItem>()
        {
            new XCtrl.sGroupComboBoxItem(){ DisplayName = "qwe", GroupName = "qqq", GroupCode = 1, lValue = 1, sValue = "12"},
            new XCtrl.sGroupComboBoxItem(){ DisplayName = "edfsfgdfgfdgdgf", GroupName = "qqq", GroupCode = 1, lValue = 1, sValue = "12"},
            new XCtrl.sGroupComboBoxItem(){ DisplayName = "edfsfgdfgfdgdgf", GroupName = "qqq", GroupCode = 1, lValue = 1, sValue = "12"},
            new XCtrl.sGroupComboBoxItem(){ DisplayName = "XZCVXCVZXV", GroupName = "1qqq", GroupCode = 1, lValue = 1, sValue = "12"},
            new XCtrl.sGroupComboBoxItem(){ DisplayName = "edfsfgdfgfdgdgf", GroupName = "qqq", GroupCode = 1, lValue = 1, sValue = "12"},
        };
    

private void Step1Dlg_Load(object sender, EventArgs e)
        {
            foreach (var s in RegionController.GetRegionsGroupName())
                cbRegionType.Items.Add(s);
            pbRegion.Image = Properties.Resources.rg_base;

            pbVitebsk.Parent = pbRegion;
            pbVitebsk2.Parent = pbRegion;

            pbMinsk2.Parent = pbRegion;
            pbMinsk.Parent = pbRegion;

            pbBrest.Parent = pbRegion;
            pbGomel.Parent = pbRegion;
            pbGomel2.Parent = pbRegion;
            pbGrodno.Parent = pbRegion;
            pbMogilev.Parent = pbRegion;

            groupComboBox1.DataSource = dt;
            groupComboBox1.ValueMember = "sValue";
            groupComboBox1.DisplayMember = "DisplayName";
            groupComboBox1.GroupMember = "GroupName";


        }
        public override bool CheckControls()
        {
            if (cbRegionType.SelectedIndex == -1)
            {
                errorPageRegion.Icon = Properties.Resources.reject;
                errorPageRegion.SetError(cbRegionType, "Выбирите регион");
                return false; 
            }
            else
            {
                errorPageRegion.Icon = Properties.Resources.apply;
                errorPageRegion.SetError(cbRegionType, "ОК");
            }


            return true;
        }
        public override void SaveData()
        {
            GetPrent().Rec._region.Name = cbRegionType.Text;
            GetPrent().Rec._region.Code = cbRegionType.SelectedIndex;
        }


        private void cbRegionType_Leave(object sender, EventArgs e)
        {
            CheckControls();
        }

        private void cbRegionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRegionType.SelectedIndex == -1)
                pbRegion.Image = Properties.Resources.rg_base;
            else
            if (cbRegionType.SelectedIndex == 0)
                pbRegion.Image = Properties.Resources.rg_minsk;
            else
            if (cbRegionType.SelectedIndex == 1)
                pbRegion.Image = Properties.Resources.rg_vitebsk;
            else
            if (cbRegionType.SelectedIndex == 2)
                pbRegion.Image = Properties.Resources.rg_mogilev;
            else
            if (cbRegionType.SelectedIndex == 3)
                pbRegion.Image = Properties.Resources.rg_brest;
            else
            if (cbRegionType.SelectedIndex == 4)
                pbRegion.Image = Properties.Resources.rg_gomel;
            else
            if (cbRegionType.SelectedIndex == 5)
                pbRegion.Image = Properties.Resources.rg_grodno;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 1;
        }
        private void pbVitebsk2_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 1;
        }
        private void OnLeaveRegion(object sender, EventArgs e)
        {
//            cbRegionType_SelectedIndexChanged(sender, e);       

        }


        private void pbMinsk_Click(object sender, EventArgs e)
        {

            cbRegionType.SelectedIndex = 0;
        }
        private void pbMinsk2_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 0;
        }


        private void pbGrodno_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 5;
        }

        private void pbBrest_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 3;
        }

        private void pbGomel_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 4;
        }

        private void pbGomel2_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 4;
        }

        private void pbMogilev_Click(object sender, EventArgs e)
        {
            cbRegionType.SelectedIndex = 2;
        }

        private void pbRegion_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            CheckControls();
        }
    }



    
}
