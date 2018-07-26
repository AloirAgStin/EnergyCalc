namespace KnaufinsulationWalls.Steps
{
    partial class StepFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepFrame));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.stepCounter1 = new XCotrols.StepCounter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.stepCounter1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 67);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::KnaufinsulationWalls.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(755, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 67);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1026, 544);
            this.panelMain.TabIndex = 2;
            // 
            // stepCounter1
            // 
            this.stepCounter1.Font = new System.Drawing.Font("Lato", 26F);
            this.stepCounter1.Location = new System.Drawing.Point(18, 10);
            this.stepCounter1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.stepCounter1.Name = "stepCounter1";
            this.stepCounter1.Size = new System.Drawing.Size(461, 47);
            this.stepCounter1.StepColorCurrent = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.stepCounter1.StepColorFuture = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.stepCounter1.StepCount = 3;
            this.stepCounter1.StepCurrent = 1;
            this.stepCounter1.TabIndex = 1;
            this.stepCounter1.TabStop = false;
            // 
            // StepFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StepFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Подбор перегородок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StepFrame_FormClosing);
            this.Load += new System.EventHandler(this.StepFrame_Load);
            this.SizeChanged += new System.EventHandler(this.StepFrame_SizeChanged);
            this.Move += new System.EventHandler(this.StepFrame_Move);
            this.Resize += new System.EventHandler(this.StepFrame_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XCotrols.StepCounter stepCounter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
    }
}