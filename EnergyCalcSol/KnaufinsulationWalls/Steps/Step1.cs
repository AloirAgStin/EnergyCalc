using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;
using XCotrols;

namespace KnaufinsulationWalls.Steps
{
    public partial class Step1 : FormExt
    {

        public Step1()
        {
            InitializeComponent();
            originalExStyle = CreateParams.ExStyle;
            DoubleBuffered = true;

            Shown += Step1_Shown;
        }


        private void DebugChoise()
        {
            return;
            int n = 2;
            if (n == 1)
            {
                roundEdit1.textbox.Text = "50";
            }
            else
            {
                radioButton2.Checked = true;
                customComboBox1.SelectedIndex = 1;
                customComboBox2.SelectedIndex = 4;
            }


            btnNext_Click(this, new EventArgs());
        }

        private void Step1_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }

        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        private void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            this.MaximizeBox = true;
        }
 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        private void Step1_Load(object sender, EventArgs e)
        {
            InitComboBoxes(1);
            btnNext.offsettextX = -5;
            richTextBox1.Visible = false;

            DebugChoise();
        }
       

        private void InitComboBoxes(int ind)
        {

            if(ind == 1)
            {

                bool IsEnable = false;

                roundEdit1.textbox.Enabled = !IsEnable;
                roundEdit1.Enabled = !IsEnable;


                customComboBox1.SelectedIndex = -1;
                customComboBox2.SelectedIndex = -1;
                
                customComboBox1.Enabled = IsEnable;
                customComboBox2.Enabled = IsEnable;
                roundPanel1.Enabled = IsEnable;
                roundPanel2.Enabled = IsEnable;
                
                customComboBox1.DataSource = null;
                customComboBox2.DataSource = null;

                roundEdit1.Focus();
                radioButton1.Focus();
                
            }
            if(ind == 2)
            {
                bool IsEnable = true;

                roundEdit1.textbox.Enabled = !IsEnable;
                roundEdit1.Enabled = !IsEnable;
                roundEdit1.textbox.Text = "";

                customComboBox1.Enabled = IsEnable;
                customComboBox2.Enabled = IsEnable;
                roundPanel1.Enabled = IsEnable;
                roundPanel2.Enabled = IsEnable;



                customComboBox1.DataSource = Data_BuildingType.GetData();
                customComboBox1.DisplayMember = "Name";
                customComboBox1.ValueMember = "index";
                customComboBox1.SelectedIndex = 0;


                customComboBox2.DataSource = Data_BuildingType.GetDataByIndex(0);

                customComboBox1.Focus();
            }

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                InitComboBoxes(1);
            else
            if (radioButton2.Checked)
                InitComboBoxes(2);
        }

        private void customComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (sBuildingType)customComboBox1.SelectedItem;
            if(item != null)
            {
                customComboBox2.DataSource = Data_BuildingType.GetDataByIndex(item.index);
                customComboBox2.DisplayMember = "Name";
                customComboBox2.ValueMember = "index";
            }
 
        }

        private void customComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cm = sender as CustomComboBox;
            
            richTextBox1.Visible = cm.SelectedIndex > 0 ? true : false;
            richTextBox1.Text = "";

            if (cm.SelectedIndex > 0)
            {
                var item = (sBuildingWall)customComboBox2.SelectedItem;
                richTextBox1.Text = item.Description;
            }
            
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            Control focusItem = roundEdit1;
            try
            {
                StepFrame vMainFrom = null;

                if (Parent == null)
                    return;
                if (Parent.Parent == null)
                    return;

                vMainFrom = Parent.Parent as StepFrame;
                int UserIndex = 0;

                if (vMainFrom.IsEnableCheck)
                {
                    if (radioButton1.Checked)
                    {
                        Helper.WriteLog("Manual input: " + roundEdit1.textbox.Text);

                        int nDb = 0;
                        Int32.TryParse(roundEdit1.textbox.Text, out nDb);

                        if (!Int32.TryParse(roundEdit1.textbox.Text, out nDb) || nDb <= 0 || nDb > Data_WallsType.maxRW)
                        {
                            focusItem = roundEdit1;
                            throw new Exception("Значение поля \"Индекс изоляции воздушного шума, Rw\" " +
                                "должно быть заполнено и не может быть больше " + Data_WallsType.maxRW.ToString() + " Дб");
                        }


                        UserIndex = nDb;
                    }
                    else
                    if (radioButton2.Checked)
                    {
                        if(customComboBox1.SelectedIndex  < 1)
                        {
                            focusItem = customComboBox1;
                            throw new Exception("Необходимо выбрать значение поля \"Тип здания\"");
                        }

                        var itemType = customComboBox1.SelectedItem as sBuildingType; 

                        if (customComboBox2.SelectedIndex < 1)
                        {
                            focusItem = customComboBox2;
                            throw new Exception("Необходимо выбрать значение поля \"Тип конструкции\"");
                        }

                        var itemS = customComboBox2.SelectedItem as sBuildingWall;
                        UserIndex = itemS.Db;

                        Helper.WriteLog("ComboBox Choise: " + itemType.Name +  " - " + itemS.Name);
                    }
                }

                Helper.WriteLog("Rw = " + UserIndex);
                vMainFrom.CalcStruct.Rw = UserIndex;
                vMainFrom.NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                focusItem.Focus();
                return;
            }            
        }
    }
}
