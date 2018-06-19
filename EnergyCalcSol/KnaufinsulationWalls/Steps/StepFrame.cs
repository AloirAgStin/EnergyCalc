using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls.Steps
{
    public partial class StepFrame : Form
    {
        int top = 0;
        int count;

        Form[] frm = {
                              new Step1(),
                              new Step2(),
                              new Step3(),
          };
        public StepFrame()
        {
            count = frm.Count();
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void StepFrame_Load(object sender, EventArgs e)
        {
            frm[top].TopLevel = false;
            frm[top].Dock = DockStyle.Fill;
            frm[top].Parent = this;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm[top]);
            frm[top].Show();
        }
    
        public void BackStep()
        {
            
            top--;
            
            if (top <= -1)
            {
                top = 0;
                return;
            }
            else
            {
                LoadForm();
            }
            
        }
        public void NextStep()
        {
            top++;
            if (top >= count)
            {
                top = count - 1;
                return;
            }
            else
            {
                LoadForm();          
            }

           
        }

        private void LoadForm()
        {
            try
            {
                frm[top].TopLevel = false;
                frm[top].Dock = DockStyle.Fill;
                frm[top].Parent = this;
                panelMain.Controls.Clear();
                stepCounter1.StepCurrent = top + 1;
                panelMain.Controls.Add(frm[top]);

                frm[top].Show();
                panelMain.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void StepFrame_Resize(object sender, EventArgs e)
        {
            frm[top].Invalidate(true);
        }
    }
}
