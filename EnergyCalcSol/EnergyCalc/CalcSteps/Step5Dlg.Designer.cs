namespace EnergyCalc.CalcSteps
{
    partial class Step5Dlg
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.extPictureBox1 = new XCtrl.ExtPictureBox();
            this.pbHouse = new XCtrl.ExtPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::EnergyCalc.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(742, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(187, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(865, 66);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Шаг 5. Результаты расчетов необходимой толщины теплоизоляции и экономии:";
            // 
            // extPictureBox1
            // 
            this.extPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extPictureBox1.Image = global::EnergyCalc.Properties.Resources.floor_money;
            this.extPictureBox1.Location = new System.Drawing.Point(572, 62);
            this.extPictureBox1.Name = "extPictureBox1";
            this.extPictureBox1.Size = new System.Drawing.Size(359, 447);
            this.extPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.extPictureBox1.TabIndex = 19;
            this.extPictureBox1.TabStop = false;
            // 
            // pbHouse
            // 
            this.pbHouse.Location = new System.Drawing.Point(17, 69);
            this.pbHouse.Name = "pbHouse";
            this.pbHouse.Size = new System.Drawing.Size(540, 440);
            this.pbHouse.TabIndex = 20;
            this.pbHouse.TabStop = false;
            // 
            // Step5Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 528);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbHouse);
            this.Controls.Add(this.extPictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step5Dlg";
            this.Text = "Step5";
            this.Load += new System.EventHandler(this.Step5Dlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
        private XCtrl.ExtPictureBox extPictureBox1;
        private XCtrl.ExtPictureBox pbHouse;
    }
}