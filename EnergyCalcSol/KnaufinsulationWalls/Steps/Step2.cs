using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCotrols;

namespace KnaufinsulationWalls.Steps
{
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();

            DoubleBuffered = true;

        }

      
        private void Step2_Load(object sender, EventArgs e)
        {
            customComboBox1.Focus();
            roundEdit2.Focus();
            roundEdit3.Focus();
            roundEdit4.Focus();

                      

            customComboBox1.DataSource = Data.Data_BuildingType.GetDataByIndex(0);
            customComboBox1.DisplayMember = "Name";
            customComboBox1.ValueMember = "index";


            customComboBox2.DataSource = Data.Data_BuildingType.GetDataByIndex(0);
            customComboBox2.DisplayMember = "Name";
            customComboBox2.ValueMember = "index";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                if (Parent.Parent != null)
                {
                    if (Parent.Parent.Parent != null)
                    {
                        var MainFrom = Parent.Parent.Parent as StepFrame;
                        MainFrom.NextStep();
                    }
                }
            }
        }

        private void Step2_Resize(object sender, EventArgs e)
        {
            btnNext.Invalidate();
        }

        public void label4_Click(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                if (Parent.Parent != null)
                {
                    if (Parent.Parent.Parent != null)
                    {
                        var MainFrom = Parent.Parent.Parent as StepFrame;
                        MainFrom.BackStep();
                    }
                }
            }
        }


    }
}
