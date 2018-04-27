using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace EnergyCalc
{
    public partial class MainFrame : Form
    {
      
        public MainFrame()
        {
            InitializeComponent();

            foreach (var item in RegionList.GetRegionList())
                cbS1Region.Items.Add(item);
        }
        
        private void SetButtonState()
        {
            int tabNum = tabControl.SelectedIndex;

            bool IsBtnActionEnable = btnAction.Visible;
            bool IsBtnActionEnable1 = btnAction1.Visible;
            bool IsBtnActionEnable2 = btnAction2.Visible;
            
            //имена кнопок
            if(tabNum == 0)
                btnAction2.Text = "Подтвердить";
            else
            if(tabNum == 4)
                btnAction2.Text = "Рассчитать";
            else
            if(tabNum == 5)
                btnAction2.Text = "Печать результатов";

            //видимость кнопок
            if (tabNum == 0)
            {
                IsBtnActionEnable = true;
                IsBtnActionEnable1 = false;
                IsBtnActionEnable2 = false;
            }           
            else
            {
                IsBtnActionEnable = false;
                IsBtnActionEnable1 = true;
                IsBtnActionEnable2 = true;
            }

            btnAction.Visible  = IsBtnActionEnable;
            btnAction1.Visible = IsBtnActionEnable1;
            btnAction2.Visible = IsBtnActionEnable2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonState();
        }
              
        private void btnAction1_Click(object sender, EventArgs e)
        {
            //кнопка слева (назад)
            if (tabControl.SelectedIndex != 0)
                tabControl.SelectedIndex--;
            SetButtonState();
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex++;
            SetButtonState();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            //Больша я кнопка
            tabControl.SelectedIndex++;
            SetButtonState();
        }
        
        private void onChangeTabPage(object sender, EventArgs e)
        {
            SetButtonState();
        }
    }
}
