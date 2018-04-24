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

namespace EnergyCalc
{
    public partial class CalcForm : Form
    {
        ValidateDlg[] frm = { new CalcSteps.Step1Dlg(), new CalcSteps.Step2Dlg(),};
        int top = -1;
        int count;

        public CalcForm()
        {
            count = frm.Count();
            InitializeComponent();
        }

        private void LoadForm()
        {
            frm[top].TopLevel = false;
            frm[top].Dock = DockStyle.Fill;
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(frm[top]);
            frm[top].Show();
        }

        bool VerifyPage()
        {
            if(top >= 0)
                return frm[top].CheckControls();
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }
        
        private void CalcForm_Load(object sender, EventArgs e)
        {
            Next();
        }


        private void Back()
        {
            top--;

            if (top <= -1)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                LoadForm();
                if (top - 1 <= -1)
                {
                    btnBack.Enabled = false;
                }
            }

            if (top >= count)
            {
                btnNext.Enabled = false;
            }
        }
        private void Next()
        {
            if (!VerifyPage())
                return;

            top++;
            if (top >= count)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                LoadForm();
                if (top + 1 == count)
                {
                    btnNext.Enabled = false;
                }
            }

            if (top <= 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (top != count)
            {
                var ret = MessageBox.Show("Вы уверены, что хотите прервать расчет средст и энергоэффективности?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ret != DialogResult.Yes)
                    return;
            }
            Close();
        }
    }
}
