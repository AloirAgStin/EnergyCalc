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
    public partial class Step5Dlg : ValidateDlg
    {
        public Step5Dlg()
        {
            InitializeComponent();
        }

        private void Step5Dlg_Load(object sender, EventArgs e)
        {
            pbHouse.Image = ResourceImage.GetBuildImageByType(GetPrent().Rec.st2_BuildingType);
        }
    }
}
