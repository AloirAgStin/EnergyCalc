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
using static KnaufinsulationWalls.Data.Data_FillComboBox;

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

            customComboBox1.DataSource = Data.Data_FillComboBox.cbItem_EI;
            customComboBox1.DisplayMember = "Name";
            customComboBox1.ValueMember = "index";
            
            customComboBox2.DataSource = Data.Data_FillComboBox.cbItem_TP;
            customComboBox2.DisplayMember = "Name";
            customComboBox2.ValueMember = "index";

            cbIsolation.DataSource = Data.Data_FillComboBox.cbItem_Ti;
            cbIsolation.DisplayMember = "Name";
            cbIsolation.ValueMember = "index";

            cbCountN.DataSource = Data.Data_FillComboBox.cbItem_N;
            cbCountN.DisplayMember = "Name";
            cbCountN.ValueMember = "index";

            customComboBox1.Focus();
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
                    
                    var elem = (CBItem)customComboBox1.SelectedItem;
                    vMainFrom.CalcStruct.EI = elem._intValue;

                    elem = (CBItem)customComboBox2.SelectedItem;
                    vMainFrom.CalcStruct.Tp = elem._intValue;
                    
                    if(cbIsolation.SelectedIndex > 0)
                    {
                        var itm = (CBItem)cbIsolation.SelectedItem;
                        vMainFrom.CalcStruct.Ti = itm._intValue;
                    }
                    else
                        vMainFrom.CalcStruct.Ti = 0;

                    if (cbCountN.SelectedIndex > 0)
                    {

                        var itm = (CBItem)cbCountN.SelectedItem;
                        vMainFrom.CalcStruct.N = itm._intValue;
                    }
                    else
                        vMainFrom.CalcStruct.N = 0;

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

        private bool IsShowExtParam = true;
        private void onClickExtParams(object sender, EventArgs e)
        {
            IsShowExtParam = !IsShowExtParam;
   
            label8.Visible = IsShowExtParam;
            label9.Visible = IsShowExtParam;

            roundPanel3.Visible = IsShowExtParam;
            roundPanel4.Visible = IsShowExtParam;

            cbIsolation.Visible = IsShowExtParam;
            cbCountN.Visible = IsShowExtParam;
        }
    }
}
