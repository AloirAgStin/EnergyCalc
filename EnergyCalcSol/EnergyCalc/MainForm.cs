using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace EnergyCalc
{
    public partial class MainFrame : Form
    {

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mainICO;

            lblINFO.Parent = pbMain;
            lblMainText.Parent = pbMain;
            lblTitle.Parent = pbMain;
            pbLogo.Parent = pbMain;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            CalcForm dlg = new CalcForm();
            dlg.ShowDialog();
        }
    }
}
