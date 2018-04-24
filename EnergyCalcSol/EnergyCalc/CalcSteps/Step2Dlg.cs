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
    public partial class Step2Dlg : ValidateDlg
    {
        public override bool CheckControls()
        {
            return true;
        }
        public Step2Dlg()
        {
            InitializeComponent();
        }
    }
}
