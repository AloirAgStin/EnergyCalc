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
using XCtrl;

namespace EnergyCalc.CalcSteps
{
    public partial class Step4Dlg : ValidateDlg
    {
        public Step4Dlg()
        {
            DoubleBuffered = true;

            loftItems.Add(new sExtDataSource() { Code = 1, Name = "Перекрытие по балкам" });
            loftItems.Add(new sExtDataSource() { Code = 2, Name = "Полы на лагах" });

            lWalls.Add(new sExtDataSource() { Code = 1, Name = "Колодезная кладка" });
            lWalls.Add(new sExtDataSource() { Code = 2, Name = "Вент фасад. (сайдинг)" });
            lWalls.Add(new sExtDataSource() { Code = 3, Name = "Каркасная система" });
            lWalls.Add(new sExtDataSource() { Code = 4, Name = "Мокрый метод" });
                        
            lFloor.Add(new sExtDataSource() { Code = 1, Name = "Полы на лагах" });
            lFloor.Add(new sExtDataSource() { Code = 2, Name = "Наливные полы" });

            InitializeComponent();

        }

        //1 группа
        List<sExtDataSource> loftItems = new List<sExtDataSource>();
        List<sExtDataSource> loftType  = new List<sExtDataSource>();

        //2 граппа
        List<sExtDataSource> lWalls = new List<sExtDataSource>();
        List<sExtDataSource> lWallsType = new List<sExtDataSource>();
        List<sExtDataSource> lWallsFundament = new List<sExtDataSource>();


        //3 группа
        List<sExtDataSource> lFloor = new List<sExtDataSource>();
        List<sExtDataSource> lFloorType = new List<sExtDataSource>();



        private void Step4Dlg_Load(object sender, EventArgs e)
        {
            lblLoftName.Parent = pbLoft;

            cbLoft.SetDataSource(loftItems);
            cbLoftType.SetDataSource(loftType);

            cbWall.SetDataSource(lWalls);
            cbFloor.SetDataSource(lFloor);


        }

        public override bool CheckControls()
        {
            bool lRet = true;

            if(cbWall.SelectedIndex != -1)
            {
                int xCode = (int)cbWall.SelectedValue;
                if (xCode != 3)
                {
                    if(!CheckEditVale(tbFundamentH))
                        lRet = false;
                }
                else
                    err1.SetError(tbFundamentH, "");
            }

            //if (!lRet)
            //  MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return lRet;
        }
        private bool CheckEditVale(Control item)
        {
            string errorText = "Введите значение";
            if (item.Text.Length == 0)
            {
                err1.SetError(item, "");
                err2.SetError(item, errorText);
                return false;
            }
            err2.SetError(item, "");
            err1.SetError(item, "OK");

            return true;
        }

        private void cbLoft_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitLoftItems();
        }
        private void InitLoftItems()
        {
            try
            {

                if (cbLoft.SelectedIndex == -1)
                    cbLoft.SelectedIndex = 0;

                int xCode = (int)cbLoft.SelectedValue;
                lblLoftName.Text = "Утеплитель Knauf Insultion";
                Image img = pbLoft.Image;

                if (xCode == 1)
                {
                    loftType.Clear();
                    loftType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОрулон 040" });
                    loftType.Add(new sExtDataSource() { Code = 2, Name = "ТЕПЛОрулон 041" });
                    loftType.Add(new sExtDataSource() { Code = 3, Name = "ТЕПЛОрулон 037" });

                    loftType.Add(new sExtDataSource() { Code = 4, Name = "ТЕПЛОкровля 037" });
                    loftType.Add(new sExtDataSource() { Code = 5, Name = "ТЕПЛОкровля 034" });
                    loftType.Add(new sExtDataSource() { Code = 6, Name = "ТЕПЛОрулон  041" });

                    img = Properties.Resources.loft_lags;
                }
                else
                if (xCode == 2)
                {
                    loftType.Clear();
                    loftType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОрулон 040" });
                    loftType.Add(new sExtDataSource() { Code = 2, Name = "ТЕПЛОплита 041" });
                    loftType.Add(new sExtDataSource() { Code = 3, Name = "ТЕПЛОплита 037" });
                    loftType.Add(new sExtDataSource() { Code = 6, Name = "ТЕПЛОрулон 041" });

                    img = Properties.Resources.loft_beam;
                }

                pbLoft.Image = img;
                cbLoftType.BeginUpdate();
                cbLoftType.DataSource = null;
                cbLoftType.Items.Clear();
                cbLoftType.SetDataSource(loftType);
                cbLoftType.EndUpdate();
            }
            catch (Exception ex)
            {

            }
        }


        private void cbWalls_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitWallsItems();
        }
        private void InitWallsItems()
        {
            try
            {
                if (cbWall.SelectedIndex == -1)
                    cbWall.SelectedIndex = 0;

                int xCode = (int)cbWall.SelectedValue;
                lblWallsType.Text = "Утеплитель Knauf Insultion";
                Image img = pbLoft.Image;

                lWallsFundament.Clear();
                
                cbWallsFundament.SelectedIndex = -1;
                cbWallsFundament.Enabled = true;
                tbFundamentH.Enabled = true;

                err1.SetError(tbFundamentH, "");
                err2.SetError(tbFundamentH, "");

                if (xCode != 4)
                {
                    loftType.Clear();
                    lWallsType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОСтена 037" });
                    lWallsType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОСтена 034" });
                    lWallsType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОСтена 032" });
                    lWallsType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОПлитв 037" });
                }
                if (xCode == 1)
                {
                    img = Properties.Resources.kolKladka;

                    lWallsFundament.Add(new sExtDataSource() { Code = 1, Name = "Кирпич" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 2, Name = "Ячеистый бетон" });

                }
                else
                if (xCode == 2)
                {
                    img = Properties.Resources.saiding;

                    lWallsFundament.Add(new sExtDataSource() { Code = 1, Name = "Кирпич" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 2, Name = "Ячеистый бетон" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 3, Name = "Бетон" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 4, Name = "Деревянный брус" });
                }
                else
                if (xCode == 3)
                {
                    img = Properties.Resources.karkas;
                    cbWallsFundament.Enabled = false;
                    tbFundamentH.Enabled = false;
                    tbFundamentH.Text = "";
                }
                else
                if (xCode == 4)
                {
                    lWallsFundament.Add(new sExtDataSource() { Code = 1, Name = "Кирпич" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 2, Name = "Ячеистый бетон" });
                    lWallsFundament.Add(new sExtDataSource() { Code = 3, Name = "Бетон" });

                    loftType.Clear();
                    loftType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОрулон 040" });
                    img = Properties.Resources.mork;
                }


                pbWalls.Image = img;
                
                //утеплитель
                cbWallsType.BeginUpdate();
                cbWallsType.DataSource = null;
                cbWallsType.Items.Clear();
                cbWallsType.SetDataSource(lWallsType);
                cbWallsType.EndUpdate();

                //фундамент
                cbWallsFundament.BeginUpdate();
                cbWallsFundament.DataSource = null;
                cbWallsFundament.SetDataSource(lWallsFundament);
                cbWallsFundament.EndUpdate();
            }
            catch(Exception ex)
            {

            }
            
        }
  
        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitFloor();


        }

        private void InitFloor()
        {
            try
            {
                if (cbFloor.SelectedIndex == -1)
                    cbFloor.SelectedIndex = 0;

                int xCode = (int)cbFloor.SelectedValue;
                lblFloorLabel.Text = "Утеплитель Knauf Insultion";
                Image img = pbFloor.Image;

                lFloorType.Clear();
                if (xCode == 1)
                {
                    img = Properties.Resources.fl_log;                    
                    lFloorType.Add(new sExtDataSource() { Code = 1, Name = "ТЕПЛОрулон 040" });
                    lFloorType.Add(new sExtDataSource() { Code = 2, Name = "ТЕПЛОплита 041" });
                    lFloorType.Add(new sExtDataSource() { Code = 3, Name = "ТЕПЛОплита 037" });
                    lFloorType.Add(new sExtDataSource() { Code = 4, Name = "ТЕПЛОрулон 041" });
                }
                else
               if (xCode == 2)
                {
                    img = Properties.Resources.fl_beam;
                    lFloorType.Add(new sExtDataSource() { Code = 1, Name = "PVT" });
                }


                pbFloor.Image = img;

                //фундамент
                cbFloorType.BeginUpdate();
                cbFloorType.DataSource = null;
                cbFloorType.SetDataSource(lFloorType);
                cbFloorType.EndUpdate();
            }
            catch (Exception ex)
            {

            }

        }

        private void KeyPressTextBod(object sender, KeyPressEventArgs e)
        {
            if (tbFundamentH.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
    }
}
