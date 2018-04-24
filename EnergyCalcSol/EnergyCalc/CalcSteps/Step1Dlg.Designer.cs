namespace EnergyCalc.CalcSteps
{
    partial class Step1Dlg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step1Dlg));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pgRegion = new System.Windows.Forms.PictureBox();
            this.cbRegionType = new System.Windows.Forms.ComboBox();
            this.errorPageRegion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pgRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPageRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Шаг 1. Выберите регион постройки:";
            // 
            // pgRegion
            // 
            this.pgRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgRegion.BackColor = System.Drawing.Color.Transparent;
            this.pgRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pgRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgRegion.Image = global::EnergyCalc.Properties.Resources.logo;
            this.pgRegion.Location = new System.Drawing.Point(17, 40);
            this.pgRegion.Name = "pgRegion";
            this.pgRegion.Size = new System.Drawing.Size(696, 371);
            this.pgRegion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pgRegion.TabIndex = 2;
            this.pgRegion.TabStop = false;
            // 
            // cbRegionType
            // 
            this.cbRegionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbRegionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegionType.FormattingEnabled = true;
            this.cbRegionType.Items.AddRange(new object[] {
            "привет",
            "минск",
            "как дела"});
            this.cbRegionType.Location = new System.Drawing.Point(428, 16);
            this.cbRegionType.MaxDropDownItems = 10;
            this.cbRegionType.Name = "cbRegionType";
            this.cbRegionType.Size = new System.Drawing.Size(285, 21);
            this.cbRegionType.TabIndex = 3;
            this.cbRegionType.Leave += new System.EventHandler(this.cbRegionType_Leave);
            // 
            // errorPageRegion
            // 
            this.errorPageRegion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPageRegion.ContainerControl = this;
            this.errorPageRegion.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPageRegion.Icon")));
            this.errorPageRegion.RightToLeft = true;
            // 
            // Step1Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 423);
            this.Controls.Add(this.cbRegionType);
            this.Controls.Add(this.pgRegion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step1Dlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Step1Dlg";
            this.Load += new System.EventHandler(this.Step1Dlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPageRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private XCtrl.CategoryComboBox categoryComboBox1;
        private System.Windows.Forms.PictureBox pgRegion;
        private System.Windows.Forms.ComboBox cbRegionType;
        private System.Windows.Forms.ErrorProvider errorPageRegion;
    }
}