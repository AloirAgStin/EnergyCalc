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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                cp.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return cp;
            }
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            btnNext.offsettextX = -5;
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
            Control focusItem = customComboBox1;
            try
            {
                StepFrame vMainFrom = null;

                if (Parent == null)
                    return;
                if (Parent.Parent == null)
                    return;

                vMainFrom = Parent.Parent as StepFrame;

                if (vMainFrom.IsEnableCheck)
                {
                    if (customComboBox1.SelectedIndex < 1)
                    {
                        focusItem = customComboBox1;
                        throw new Exception("Выберите \"Предел огнестойкости EI\"");
                    }

                    if (customComboBox2.SelectedIndex < 1)
                    {
                        focusItem = customComboBox2;
                        throw new Exception("Выберите \"Толщина перегородки, Тп\"");
                    }


                }

                vMainFrom.NextStep();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                focusItem.Focus();
                return;
            }
        }

        public void label4_Click(object sender, EventArgs e)
        {
            StepFrame vMainFrom = null;

            if (Parent == null)
                return;
            if (Parent.Parent == null)
                return;

            vMainFrom = Parent.Parent as StepFrame;
            vMainFrom.BackStep();
        }

        private void Step2_Resize(object sender, EventArgs e)
        {
            btnNext.Invalidate();
        }


    }
}
