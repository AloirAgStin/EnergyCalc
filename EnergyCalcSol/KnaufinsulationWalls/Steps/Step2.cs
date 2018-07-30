using System;
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


        private List<sWalls> _dataSource;
        private List<sWalls> _dataWork;

        public override void AfterShow()
        {
            var vMainFrom = Parent.Parent as StepFrame;
            _dataSource = Data_WallsType.GetDatabyRW(Data_WallsType.data, vMainFrom.CalcStruct.Rw);

            _dataWork = new List<sWalls>();
            foreach (var item in _dataSource)
                _dataWork.Add((sWalls)item.Clone());

            InitDataForEI(_dataWork);
            InitDataForTp(_dataWork);

            var emptt = new List<sWalls>();
            InitDataForTi(emptt);
            InitDataForN(emptt);
            

            cbEI.DataSource = Data_FillComboBox.cbItem_EI;
            cbEI.DisplayMember = "Name";
            cbEI.ValueMember = "index";

            cbTP.DataSource = Data_FillComboBox.cbItem_TP;
            cbTP.DisplayMember = "Name";
            cbTP.ValueMember = "index";

            cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;
            cbIsolation.DisplayMember = "Name";
            cbIsolation.ValueMember = "index";

            cbCountN.DataSource = Data_FillComboBox.cbItem_N;
            cbCountN.DisplayMember = "Name";
            cbCountN.ValueMember = "index";
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
            var elem = (CBItem)cbEI.SelectedItem;

            if (elem._intValue <= 0)
                return;

            _dataWork = new List<sWalls>();
            foreach (var item2 in _dataSource)
                _dataWork.Add((sWalls)item2.Clone());

            _dataWork = Data_WallsType.GetDatabyEI(_dataWork, elem._intValue);


            var item = cbTP.SelectedItem;

            InitDataForTp(_dataWork);
            cbTP.DataSource = Data_FillComboBox.cbItem_TP;

            cbTP.SelectedItem = item;
        }

        private void onChangeTp(object sender, EventArgs e)
        {            
            var elem = (CBItem)cbTP.SelectedItem;
            
            if (elem._intValue <= 0)
            {
                InitDataForTi(_dataWork);
                cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;

                InitDataForN(_dataWork);
                cbCountN.DataSource = Data_FillComboBox.cbItem_N;
                return;
            }


            var item = cbIsolation.SelectedItem;
            _dataWork = Data_WallsType.GetDatabyTP(_dataWork, elem._intValue);

            InitDataForTi(_dataWork);
            cbIsolation.DataSource = Data_FillComboBox.cbItem_Ti;

            cbIsolation.SelectedItem = item;
        }

        private void onChangeTi(object sender, EventArgs e)
        {            
            var elem = (CBItem)cbIsolation.SelectedItem;

            if (elem._intValue <= 0)
            {
                InitDataForN(_dataWork);
                cbCountN.DataSource = Data_FillComboBox.cbItem_N;
                return;
            }

            var item = cbCountN.SelectedItem;

            var filtrList = Data_WallsType.GetDatabyTi(_dataWork, elem._intValue);
            InitDataForN(filtrList);
            cbCountN.DataSource = Data_FillComboBox.cbItem_N;

            cbCountN.SelectedItem = item;
        }
        

    }
}
