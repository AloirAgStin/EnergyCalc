namespace EnergyCalc.CalcSteps
{
    partial class Step6Dlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step6Dlg));
            this.cmPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйПросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNameHouse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.extGropBox2 = new XCtrl.ExtGropBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.extGropBox1 = new XCtrl.ExtGropBox();
            this.lbBaseData = new System.Windows.Forms.ListView();
            this.lblHeatType = new System.Windows.Forms.Label();
            this.pbHouse = new XCtrl.ExtPictureBox();
            this.cmPrint.SuspendLayout();
            this.extGropBox2.DropZone.SuspendLayout();
            this.extGropBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.extGropBox1.DropZone.SuspendLayout();
            this.extGropBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // cmPrint
            // 
            this.cmPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem,
            this.предварительныйПросмотрToolStripMenuItem});
            this.cmPrint.Name = "contextMenuStrip1";
            this.cmPrint.Size = new System.Drawing.Size(234, 48);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            this.предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            this.предварительныйПросмотрToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйПросмотрToolStripMenuItem.Text = "Предварительный просмотр";
            this.предварительныйПросмотрToolStripMenuItem.Click += new System.EventHandler(this.предварительныйПросмотрToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.ContextMenuStrip = this.cmPrint;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(639, 90);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(187, 52);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "распечатать результаты";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNameHouse
            // 
            this.lblNameHouse.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.lblNameHouse.Location = new System.Drawing.Point(313, 262);
            this.lblNameHouse.Name = "lblNameHouse";
            this.lblNameHouse.Size = new System.Drawing.Size(320, 46);
            this.lblNameHouse.TabIndex = 25;
            this.lblNameHouse.Text = "Здание без подвала. Неотапливаемая мансарда.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 18F);
            this.label3.Location = new System.Drawing.Point(200, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Экономия: 13066450  грн./год";
            // 
            // extGropBox2
            // 
            this.extGropBox2.ArrowType = 0;
            this.extGropBox2.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox2.DropZone
            // 
            this.extGropBox2.DropZone.AutoScroll = true;
            this.extGropBox2.DropZone.Controls.Add(this.label9);
            this.extGropBox2.DropZone.Controls.Add(this.label8);
            this.extGropBox2.DropZone.Controls.Add(this.label7);
            this.extGropBox2.DropZone.Controls.Add(this.label6);
            this.extGropBox2.DropZone.Controls.Add(this.label5);
            this.extGropBox2.DropZone.Controls.Add(this.label4);
            this.extGropBox2.DropZone.Controls.Add(this.label1);
            this.extGropBox2.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox2.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox2.DropZone.Name = "DropZone";
            this.extGropBox2.DropZone.Size = new System.Drawing.Size(621, 232);
            this.extGropBox2.DropZone.TabIndex = 0;
            this.extGropBox2.LineW = 4;
            this.extGropBox2.Location = new System.Drawing.Point(12, 324);
            this.extGropBox2.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox2.Name = "extGropBox2";
            this.extGropBox2.Size = new System.Drawing.Size(621, 232);
            this.extGropBox2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.label9.Location = new System.Drawing.Point(60, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Рекомендуемый материал: ТЕПЛОрулон 040, толщина 50 мм";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.label8.Location = new System.Drawing.Point(60, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Рекомендуемый материал: ТЕПЛОстена 037, толщина 150 мм";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.label7.Location = new System.Drawing.Point(60, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Рекомендуемый материал: ТЕПЛОрулон 040, толщина 250 мм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Underline);
            this.label6.Location = new System.Drawing.Point(60, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Полы и перекрытия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Underline);
            this.label5.Location = new System.Drawing.Point(60, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Стены ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(60, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Чердак:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Исходные данные:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(90, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 65);
            this.label2.TabIndex = 22;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::EnergyCalc.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(639, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(187, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // extGropBox1
            // 
            this.extGropBox1.ArrowType = 0;
            this.extGropBox1.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox1.DropZone
            // 
            this.extGropBox1.DropZone.Controls.Add(this.lbBaseData);
            this.extGropBox1.DropZone.Controls.Add(this.lblHeatType);
            this.extGropBox1.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox1.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox1.DropZone.Name = "DropZone";
            this.extGropBox1.DropZone.Size = new System.Drawing.Size(295, 284);
            this.extGropBox1.DropZone.TabIndex = 0;
            this.extGropBox1.LineW = 4;
            this.extGropBox1.Location = new System.Drawing.Point(12, 24);
            this.extGropBox1.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox1.Name = "extGropBox1";
            this.extGropBox1.Size = new System.Drawing.Size(295, 284);
            this.extGropBox1.TabIndex = 1;
            // 
            // lbBaseData
            // 
            this.lbBaseData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBaseData.BackColor = System.Drawing.Color.White;
            this.lbBaseData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBaseData.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lbBaseData.Location = new System.Drawing.Point(28, 66);
            this.lbBaseData.Name = "lbBaseData";
            this.lbBaseData.Size = new System.Drawing.Size(248, 206);
            this.lbBaseData.TabIndex = 21;
            this.lbBaseData.UseCompatibleStateImageBehavior = false;
            this.lbBaseData.View = System.Windows.Forms.View.List;
            // 
            // lblHeatType
            // 
            this.lblHeatType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeatType.AutoSize = true;
            this.lblHeatType.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHeatType.Location = new System.Drawing.Point(52, 23);
            this.lblHeatType.Name = "lblHeatType";
            this.lblHeatType.Size = new System.Drawing.Size(170, 24);
            this.lblHeatType.TabIndex = 12;
            this.lblHeatType.Text = "Исходные данные:";
            // 
            // pbHouse
            // 
            this.pbHouse.Location = new System.Drawing.Point(313, 24);
            this.pbHouse.Name = "pbHouse";
            this.pbHouse.Size = new System.Drawing.Size(320, 284);
            this.pbHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHouse.TabIndex = 0;
            this.pbHouse.TabStop = false;
            // 
            // FinishDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 673);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblNameHouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.extGropBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.extGropBox1);
            this.Controls.Add(this.pbHouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishDlg";
            this.Text = "FinishDlg";
            this.Load += new System.EventHandler(this.FinishDlg_Load);
            this.cmPrint.ResumeLayout(false);
            this.extGropBox2.DropZone.ResumeLayout(false);
            this.extGropBox2.DropZone.PerformLayout();
            this.extGropBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.extGropBox1.DropZone.ResumeLayout(false);
            this.extGropBox1.DropZone.PerformLayout();
            this.extGropBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XCtrl.ExtPictureBox pbHouse;
        private XCtrl.ExtGropBox extGropBox1;
        private System.Windows.Forms.Label lblHeatType;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListView lbBaseData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XCtrl.ExtGropBox extGropBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNameHouse;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip cmPrint;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйПросмотрToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}