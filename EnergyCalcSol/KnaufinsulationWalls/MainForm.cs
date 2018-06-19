using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Focus();
            bgCheckUpdates.RunWorkerAsync();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Steps.StepFrame d = new Steps.StepFrame();
            d.Show(this);
        }

        private void bgCheckUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            bool IsEnable = IniFileManager.GetBoolKey("updates.enable");

            e.Result = (int)0;
            if (!IsEnable)
                return;

            Thread.Sleep(500);
            var p = IniFileManager.GetStringKey("updates.url");
            
            e.Result = (int)1;
        }

        private void bgCheckUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((int)e.Result == 1)
            {
                newVersion d = new newVersion();
                d.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (bgCheckUpdates.IsBusy) return;

            bgCheckUpdates.RunWorkerAsync();
        }
    }
}
