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
        ValidateDlg[] frm = {
                                new CalcSteps.Step1Dlg(),
                                new CalcSteps.Step2Dlg(),
                                new CalcSteps.Step3Dlg(),
                                new CalcSteps.Step4Dlg(),
                                new CalcSteps.Step5Dlg(),
                                new CalcSteps.Step6Dlg(),
                                new CalcSteps.StepFinish(),
        };

        int top = -1;
        int count;

        public sCalcRec Rec = new sCalcRec();

        public CalcForm()
        {
            Rec.Init();
            count = frm.Count();
            InitializeComponent();

            Icon = Properties.Resources.mainICO;

        }

        private void LoadForm()
        {
            try
            {
                frm[top].TopLevel = false;
                frm[top].Dock = DockStyle.Fill;
                frm[top].Parent = this;
                this.pnlContent.Controls.Clear();
                this.pnlContent.Controls.Add(frm[top]);
                frm[top].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
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
            btnNext.Text = "Далее";
            if(top == count - 2)
            {
                btnNext.Text = "Завершить";
            }

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
//            if (!VerifyPage())
  //            return;
            if(top != -1)
                frm[top].SaveData();

            top++;
            if (top >= count)
            {
                Close();
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "Далее";

                LoadForm();
                if (top + 2 == count)
                {
                    btnNext.Text = "Завершить";
                    btnNext.Enabled = true;
                }
                else
                if (top + 1 == count)
                {
                    btnNext.Text = "Выход";
                    btnNext.Enabled = true;
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
                var ret = MessageBox.Show(this, "Вы уверены, что хотите прервать расчет средст и энергоэффективности?", "Внимание", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ret != DialogResult.Yes)
                    return;
            }
            Close();
        }

        public void NextFocus()
        {
            btnNext.Focus();
        }
    }
}
