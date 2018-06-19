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
    public partial class Step1 : Form
    {

        public Step1()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void Step1_Load(object sender, EventArgs e)
        {
            InitComboBoxes(1);
        }

        private void InitComboBoxes(int ind)
        {

            if(ind == 1)
            {

                bool IsEnable = false;

                customComboBox1.SelectedIndex = -1;
                customComboBox2.SelectedIndex = -1;
                
                customComboBox1.Enabled = IsEnable;
                customComboBox2.Enabled = IsEnable;
                roundPanel1.Enabled = IsEnable;
                roundPanel2.Enabled = IsEnable;
                
                customComboBox1.DataSource = null;
                customComboBox2.DataSource = null;
                
                roundEdit1.Enabled = !IsEnable;

                roundEdit1.Focus();
                radioButton1.Focus();

            }
            if(ind == 2)
            {
                bool IsEnable = true;
                customComboBox1.Enabled = IsEnable;
                customComboBox2.Enabled = IsEnable;
                roundPanel1.Enabled = IsEnable;
                roundPanel2.Enabled = IsEnable;

                roundEdit1.Enabled = !IsEnable;
                roundEdit1.textbox.Text = "";

                customComboBox1.DataSource = Data_BuildingType.GetData();
                customComboBox1.DisplayMember = "Name";
                customComboBox1.ValueMember = "index";

                customComboBox2.DataSource = Data_BuildingType.GetDataByIndex(0);

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

        private void Step1_Resize(object sender, EventArgs e)
        {
            btnNext.Invalidate();
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
            if(cm.SelectedIndex > 0)
            {
                var item = (sBuildingWall)customComboBox2.SelectedItem;
                richTextBox1.Text = item.Description;
            }
            else
            {
                richTextBox1.Text = "";
            }
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



    }
}
