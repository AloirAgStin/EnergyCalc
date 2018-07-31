﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;
using XCotrols;
using static KnaufinsulationWalls.Data.Data_FillComboBox;

namespace KnaufinsulationWalls.Steps
{
    public partial class Step2 : FormExt
    {
        public Step2()
        {
            InitializeComponent();
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


        private List<sWalls> dataSource;
        private List<sWalls> data = new List<sWalls>();

        public override void AfterShow()
        {
            cbEI.DisplayMember = "Name";
            cbEI.ValueMember = "index";

            cbTP.DisplayMember = "Name";
            cbTP.ValueMember = "index";

            cbIsolation.DisplayMember = "Name";
            cbIsolation.ValueMember = "index";

            cbCountN.DisplayMember = "Name";
            cbCountN.ValueMember = "index";

            var vCalcStruct = (Parent.Parent as StepFrame).CalcStruct;
            dataSource = Data_WallsType.GetDatabyRW(Data_WallsType.data, vCalcStruct.Rw);
            
            FiltrData();
            
            cbEI.DataSource = Data_FillComboBox.cbItem_EI;
            cbTP.DataSource = Data_FillComboBox.cbItem_TP;
            cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;
            cbCountN.DataSource = Data_FillComboBox.cbItem_N;
        }

        void FiltrData(int EI = 0, int TP = 0, int TI = 0)
        {
            data.Clear();
            foreach (var item in dataSource)
                data.Add((sWalls)item.Clone());
            InitDataForEI(data);

            if (EI > 0)
                data = Data_WallsType.GetDatabyEI(data, EI);
            InitDataForTp(data);

            if (TP > 0)
                data = Data_WallsType.GetDatabyTP(data, TP);
            InitDataForTi(data);

            if (TI > 0)
                data = Data_WallsType.GetDatabyTi(data, TI);
            InitDataForN(data);
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            btnNext.offsettextX = -5;
            cbEI.Focus();
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

        private void lbl_Back(object sender, EventArgs e)
        {
            StepFrame vMainFrom = null;

            if (Parent == null)
                return;
            if (Parent.Parent == null)
                return;

            vMainFrom = Parent.Parent as StepFrame;
            vMainFrom.BackStep();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Control focusItem = cbEI;
            try
            {
                StepFrame vMainFrom = null;

                if (base.Parent == null)
                    return;
                if (base.Parent.Parent == null)
                    return;

                vMainFrom = base.Parent.Parent as StepFrame;

                if (vMainFrom.IsEnableCheck)
                {
                    if (cbEI.SelectedIndex < 1)
                    {
                        focusItem = cbEI;
                        throw new Exception("Выберите \"Предел огнестойкости EI\"");
                    }

                    var elem = (CBItem)cbEI.SelectedItem;
                    vMainFrom.CalcStruct.EI = elem._intValue;

                    elem = (CBItem)cbTP.SelectedItem;
                    vMainFrom.CalcStruct.Tp = elem._intValue;

                    if (cbIsolation.SelectedIndex > 0)
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

        private void onFocusCombo(object sender, EventArgs e)
        {
            var item = sender as CustomComboBox;
            var name = item.Name;

            if (cbEI.Name == name)
            {
                dbPictureBox1.Image = Properties.Resources.stepImageEI;
            }
            else
            if (cbTP.Name == name)
            {
                dbPictureBox1.Image = Properties.Resources.stepImageTp;
            }
            else
            if (cbIsolation.Name == name)
            {
                dbPictureBox1.Image = Properties.Resources.stepImageTi;
            }
            else
            if (cbCountN.Name == name)
            {
                dbPictureBox1.Image = Properties.Resources.stepImageN;
            }
            else
            {
                dbPictureBox1.Image = Properties.Resources.stepImage;
            }


        }

        private void onLeaveCombo(object sender, EventArgs e)
        {
            dbPictureBox1.Image = Properties.Resources.stepImage;
        }

        private void onChangeEI(object sender, EventArgs e)
        {
            var elemEI = (CBItem)cbEI.SelectedItem;
            FiltrData(elemEI._intValue);

            CBItem elemTp = new CBItem() { _intValue = 0 };
            if (cbTP.SelectedIndex > 0)
                elemTp = (CBItem)cbTP.SelectedItem;

            cbTP.DataSource = Data_FillComboBox.cbItem_TP;
            if (elemTp._intValue > 0)
                cbTP.SelectedItem = elemTp;


            cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;
          //  cbCountN.DataSource = Data_FillComboBox.cbItem_N;
            
            return; 
        }

        private void onChangeTp(object sender, EventArgs e)
        {
            var elemEI = (CBItem)cbEI.SelectedItem;
            var elemTp = (CBItem)cbTP.SelectedItem;
            FiltrData(elemEI._intValue, elemTp._intValue);


            CBItem elemTi = new CBItem() { _intValue = 0 };
            if (cbIsolation.SelectedIndex > 0)
                elemTi = (CBItem)cbIsolation.SelectedItem;

            cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;
            cbIsolation.SelectedItem = elemTi;
        }

        private void onChangeTi(object sender, EventArgs e)
        {
            var elemEI = (CBItem)cbEI.SelectedItem;
            var elemTp = (CBItem)cbTP.SelectedItem;
            var elemTi = (CBItem)cbIsolation.SelectedItem;

            FiltrData(elemEI._intValue, elemTp._intValue, elemTi._intValue);


            CBItem elemN = new CBItem() { _intValue = 0 };
            if (cbCountN.SelectedIndex > 0)
                elemN = (CBItem)cbCountN.SelectedItem;

            cbCountN.DataSource = Data_FillComboBox.cbItem_N;
            cbCountN.SelectedItem = elemN;
        }
        

    }
}
