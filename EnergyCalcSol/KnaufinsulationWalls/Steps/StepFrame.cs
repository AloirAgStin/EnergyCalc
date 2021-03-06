﻿using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using KnaufinsulationWalls.Data;
using KnaufinsulationWalls.Properties;

 
namespace KnaufinsulationWalls.Steps
{
    public partial class StepFrame : Form
    {
        int top = 0;
        int count = 0;

        FormExt[] frm = {
                              new Step1(),
                              new Step2(),
                              new Step3(),
          };
        
        public StepFrame()
        {
            count = frm.Count();

            InitializeComponent();

            CalcStruct = new CalcItem();

            IsEnableCheck = true;
            
            Helper.WriteLog("Load selection form");
            Helper.WriteLog("Load step 1");
        }
        
        private void StepFrame_Resize(object sender, EventArgs e)
        {
            frm[top].Invalidate(true);
            Settings.Default.SZWindows = Size;
        }

        private void StepFrame_SizeChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void StepFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void StepFrame_Move(object sender, EventArgs e)
        {
            Settings.Default.STPoint = Location;
        }



        public bool IsEnableCheck;
        public CalcItem CalcStruct;
        
        private void StepFrame_Load(object sender, EventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panelMain, new object[] { true });

            frm[top].TopLevel = false;
            frm[top].Dock = DockStyle.Fill;
            frm[top].Parent = this;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm[top]);
            frm[top].Show();


            if(Settings.Default.SZWindows.Height != 0 && Settings.Default.SZWindows.Width != 0)
            {
                Size = Settings.Default.SZWindows;                
            }
            else
            {
                Settings.Default.SZWindows = Size;
                Settings.Default.Save();
            }

            if (Settings.Default.STPoint != new System.Drawing.Point(0,0))
            {
                Location = Settings.Default.STPoint;
            }
            else
            {
                Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
                Settings.Default.STPoint = Location;
                Settings.Default.Save();
            }

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
                panelMain.Focus();
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
                frm[top].AfterShow();
                panelMain.Focus();
            }

           
        }

        private void LoadForm()
        {
            try
            {

                Helper.WriteLog("Load step " + (top + 1).ToString());
                frm[top].TopLevel = false;
                frm[top].Dock = DockStyle.Fill;
                frm[top].Parent = this;
                panelMain.Controls.Clear();
                stepCounter1.StepCurrent = top + 1;
                panelMain.Controls.Add(frm[top]);

                frm[top].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stepCounter1_Enter(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
    }
}
