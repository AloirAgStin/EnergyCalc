using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyCalc.CoreClass
{
    public class ValidateDlg : Form
    {
        public virtual bool CheckControls() { return true; }

    }
}
