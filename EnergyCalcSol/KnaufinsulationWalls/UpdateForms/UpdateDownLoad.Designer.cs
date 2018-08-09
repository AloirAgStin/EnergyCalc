namespace KnaufinsulationWalls.UpdateForms
{
    partial class UpdateDownLoad
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgBar = new XCotrols.ExtProgressBar();
            this.roundButton1 = new XControl.RoundButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(3, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(261, 60);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Идет загрузка обновления\r\n1000 из 123123";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgBar
            // 
            this.pgBar.IsDrawText = true;
            this.pgBar.Location = new System.Drawing.Point(7, 75);
            this.pgBar.Name = "pgBar";
            this.pgBar.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.pgBar.ProgressColor2 = System.Drawing.SystemColors.Highlight;
            this.pgBar.ProgressText = "";
            this.pgBar.Size = new System.Drawing.Size(435, 24);
            this.pgBar.TabIndex = 1;
            this.pgBar.TextColor = System.Drawing.SystemColors.Highlight;
            this.pgBar.TextFont = new System.Drawing.Font("Arial", 12F);
            this.pgBar.Value = 100;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.roundButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.roundButton1.ButtonBorderWidth = 1;
            this.roundButton1.ButtonHighlightColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 20;
            this.roundButton1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(140, 100);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.offsettextX = 0;
            this.roundButton1.Size = new System.Drawing.Size(168, 37);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "Отмена";
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KnaufinsulationWalls.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(270, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "KnaufinsulationWalls";
            this.saveFileDialog1.Filter = "Приложения|*.exe";
            this.saveFileDialog1.Title = "Укажите место сохранения файла";
            // 
            // UpdateDownLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 138);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDownLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновление программы";
            this.Load += new System.EventHandler(this.UpdateDownLoad_Load);
            this.Shown += new System.EventHandler(this.UpdateDownLoad_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private XCotrols.ExtProgressBar pgBar;
        private XControl.RoundButton roundButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}