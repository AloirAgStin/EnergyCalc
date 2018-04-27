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
    public partial class StepFinish : ValidateDlg
    {
        public StepFinish()
        {
            InitializeComponent();
        }

        private void StepFinish_Load(object sender, EventArgs e)
        {
            pbLogo.Parent = extPictureBox1;
            label1.Parent = extPictureBox1;
            lblMainText.Parent = extPictureBox1;
            linkLabel1.Parent = extPictureBox1;
            label2.Parent = extPictureBox1;
            lblSPS.Parent = extPictureBox1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str = "mailto:" + linkLabel1.Text;
            System.Diagnostics.Process.Start(str);
        }
    }
}
