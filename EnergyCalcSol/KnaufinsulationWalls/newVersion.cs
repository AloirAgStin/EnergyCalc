using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls
{
    public partial class newVersion : Form
    {
        public string FileUrl;
        public newVersion()
        {
            InitializeComponent();
            label2.MouseEnter += Label2_MouseEnter;
            label2.MouseLeave += Label2_MouseLeave;

            FileUrl = IniFileManager.GetStringKey("updates.downloadURL");
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 178, 236);
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = (SystemColors.Highlight);
        }

     
        private void newVersion_Paint(object sender, PaintEventArgs e)
        {
            roundButton1.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(FileUrl);               
            }
            catch (Exception)
            {
            }
            Close();
        }
    }
}
