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
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel2.Size = new System.Drawing.Size(1066, 70);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1066, 541);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::KnaufinsulationWalls.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(805, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stepCounter1
            // 
            this.stepCounter1.BackColor = System.Drawing.Color.White;
            this.stepCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepCounter1.Location = new System.Drawing.Point(27, 15);
            this.stepCounter1.Name = "stepCounter1";
            this.stepCounter1.Size = new System.Drawing.Size(395, 40);
            this.stepCounter1.StepColorCurrent = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.stepCounter1.StepColorFuture = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.stepCounter1.StepCount = 3;
            this.stepCounter1.StepCurrent = 1;
            this.stepCounter1.TabIndex = 3;
            // 
            // StepFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1082, 610);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XCotrols.StepCounter stepCounter1;
    }
}