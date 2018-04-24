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
        private void Step1Dlg_Load(object sender, EventArgs e)
        {
            errorPageRegion.SetIconPadding(cbRegionType, 3);
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

        private void cbRegionType_Leave(object sender, EventArgs e)
        {
            CheckControls();
        }
    }



    
}
