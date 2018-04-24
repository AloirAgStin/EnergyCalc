namespace EnergyCalc.CalcSteps
{
    partial class Step2Dlg
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
            this.extGropBox1 = new XCtrl.ExtGropBox();
            this.extGropBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // extGropBox1
            // 
            this.extGropBox1.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox1.DropZone
            // 
            this.extGropBox1.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox1.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox1.DropZone.Name = "DropZone";
            this.extGropBox1.DropZone.Size = new System.Drawing.Size(188, 65);
            this.extGropBox1.DropZone.TabIndex = 0;
            this.extGropBox1.LineW = 4;
            this.extGropBox1.Location = new System.Drawing.Point(235, 187);
            this.extGropBox1.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox1.Name = "extGropBox1";
            this.extGropBox1.Size = new System.Drawing.Size(188, 65);
            this.extGropBox1.TabIndex = 0;
            // 
            // Step2Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 393);
            this.Controls.Add(this.extGropBox1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step2Dlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Step2Dlg";
            this.extGropBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XCtrl.ExtGropBox extGropBox1;
    }
}