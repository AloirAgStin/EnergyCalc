using XControl;

namespace KnaufinsulationWalls.Steps
{
    partial class Step3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step3));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFDPDF = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRW = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnTex = new System.Windows.Forms.Button();
            this.btnNG = new System.Windows.Forms.Button();
            this.btnEI = new System.Windows.Forms.Button();
            this.btndw = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblClose = new XControl.SelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDWG = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserData = new System.Windows.Forms.Label();
            this.lblBack = new XControl.SelectableLabel();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.exListBox1 = new XControl.ExListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new XControl.RoundButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnDWG.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "zip";
            this.saveFileDialog1.Filter = "Файлы архива zip|*.zip";
            // 
            // saveFDPDF
            // 
            this.saveFDPDF.DefaultExt = "pdf";
            this.saveFDPDF.Filter = "PDF файл|*.PDF";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnRW, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPDF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTex, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNG, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEI, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btndw, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(313, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 88);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // btnRW
            // 
            this.btnRW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRW.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnRW.Image = global::KnaufinsulationWalls.Properties.Resources.btnRW;
            this.btnRW.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRW.Location = new System.Drawing.Point(245, 4);
            this.btnRW.Name = "btnRW";
            this.btnRW.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRW.Size = new System.Drawing.Size(115, 80);
            this.btnRW.TabIndex = 5;
            this.btnRW.Tag = "2";
            this.btnRW.Text = "ПРОТОКОЛ ";
            this.btnRW.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRW.UseVisualStyleBackColor = false;
            this.btnRW.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPDF.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDF.Location = new System.Drawing.Point(3, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnPDF.Size = new System.Drawing.Size(115, 80);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Tag = "1";
            this.btnPDF.Text = "ЧЕРТЕЖИ \r\nPDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnTex
            // 
            this.btnTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnTex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnTex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTex.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnTex.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnTex.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTex.Location = new System.Drawing.Point(608, 4);
            this.btnTex.Name = "btnTex";
            this.btnTex.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnTex.Size = new System.Drawing.Size(119, 80);
            this.btnTex.TabIndex = 7;
            this.btnTex.Tag = "5";
            this.btnTex.Text = "ТЕХСВИДЕ-\r\nТЕЛЬСТВО";
            this.btnTex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTex.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTex.UseVisualStyleBackColor = false;
            this.btnTex.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            this.btnTex.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaintBorder);
            // 
            // btnNG
            // 
            this.btnNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNG.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNG.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnNG.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNG.Location = new System.Drawing.Point(487, 4);
            this.btnNG.Name = "btnNG";
            this.btnNG.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnNG.Size = new System.Drawing.Size(115, 80);
            this.btnNG.TabIndex = 6;
            this.btnNG.Tag = "4";
            this.btnNG.Text = "СЕРТИФИКАТ\r\nНА НГ";
            this.btnNG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNG.UseVisualStyleBackColor = false;
            this.btnNG.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            this.btnNG.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaintBorder);
            // 
            // btnEI
            // 
            this.btnEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEI.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnEI.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnEI.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEI.Location = new System.Drawing.Point(366, 4);
            this.btnEI.Name = "btnEI";
            this.btnEI.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEI.Size = new System.Drawing.Size(115, 80);
            this.btnEI.TabIndex = 5;
            this.btnEI.Tag = "3";
            this.btnEI.Text = "ПРОТОКОЛ \r\nНА EI ";
            this.btnEI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEI.UseVisualStyleBackColor = false;
            this.btnEI.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            this.btnEI.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaintBorder);
            // 
            // btndw
            // 
            this.btndw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btndw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btndw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btndw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndw.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btndw.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btndw.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndw.Location = new System.Drawing.Point(124, 4);
            this.btndw.Name = "btndw";
            this.btndw.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btndw.Size = new System.Drawing.Size(115, 80);
            this.btndw.TabIndex = 3;
            this.btndw.Tag = "1";
            this.btndw.Text = "ЧЕРТЕЖИ \r\nDWG";
            this.btndw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndw.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btndw.UseVisualStyleBackColor = false;
            this.btndw.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            this.btndw.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaintBorder);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Lato", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(591, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(447, 289);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblClose
            // 
            this.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblClose.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.lblClose.Location = new System.Drawing.Point(813, 486);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(85, 25);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "Закрыть";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.label4.Location = new System.Drawing.Point(325, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "02. Параметры перегородки, EI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(983, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(308, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnDWG
            // 
            this.btnDWG.AutoSize = true;
            this.btnDWG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDWG.Controls.Add(this.label6);
            this.btnDWG.Controls.Add(this.label5);
            this.btnDWG.Controls.Add(this.label3);
            this.btnDWG.Controls.Add(this.lblUserData);
            this.btnDWG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDWG.Location = new System.Drawing.Point(290, 0);
            this.btnDWG.MinimumSize = new System.Drawing.Size(0, 75);
            this.btnDWG.Name = "btnDWG";
            this.btnDWG.Size = new System.Drawing.Size(772, 75);
            this.btnDWG.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(31, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "w";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "R";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "ИСХОДНЫЕ ДАННЫЕ";
            // 
            // lblUserData
            // 
            this.lblUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserData.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lblUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.lblUserData.Location = new System.Drawing.Point(46, 42);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(604, 22);
            this.lblUserData.TabIndex = 4;
            this.lblUserData.Text = "=55дБ, EI=60; Толщина перегродки Tп=150мм;";
            this.lblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBack
            // 
            this.lblBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBack.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.lblBack.Location = new System.Drawing.Point(526, 486);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(66, 25);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Назад";
            this.lblBack.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelLeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLeftSide.Controls.Add(this.exListBox1);
            this.panelLeftSide.Controls.Add(this.label1);
            this.panelLeftSide.Controls.Add(this.label2);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(290, 530);
            this.panelLeftSide.TabIndex = 5;
            this.panelLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelLeftSide.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // exListBox1
            // 
            this.exListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.exListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.exListBox1.Font = new System.Drawing.Font("Lato", 18F);
            this.exListBox1.ForeColor = System.Drawing.Color.Silver;
            this.exListBox1.FormattingEnabled = true;
            this.exListBox1.ItemHeight = 25;
            this.exListBox1.Items.AddRange(new object[] {
            "ВАРИАНТ 1"});
            this.exListBox1.Location = new System.Drawing.Point(14, 82);
            this.exListBox1.Name = "exListBox1";
            this.exListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exListBox1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.exListBox1.Size = new System.Drawing.Size(231, 400);
            this.exListBox1.TabIndex = 1;
            this.exListBox1.SelectedIndexChanged += new System.EventHandler(this.exListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 19F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(85, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕЗУЛЬТАТ\r\nПОДБОРА";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lato", 37F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "03";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPrint.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPrint.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPrint.ButtonBorderWidth = 1;
            this.btnPrint.ButtonHighlightColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrint.ButtonHighlightColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrint.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.btnPrint.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPrint.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPrint.ButtonPressedForeColor = System.Drawing.Color.White;
            this.btnPrint.ButtonRoundRadius = 35;
            this.btnPrint.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(600, 473);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.offsettextX = 0;
            this.btnPrint.Size = new System.Drawing.Size(195, 47);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "СОХРАНИТЬ PDF";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDWG);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ы";
            this.Load += new System.EventHandler(this.Step3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnDWG.ResumeLayout(false);
            this.btnDWG.PerformLayout();
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XControl.RoundButton btnPrint;
        private XControl.SelectableLabel lblBack;
        private System.Windows.Forms.Panel btnDWG;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private ExListBox exListBox1;
        private SelectableLabel lblClose;
        private System.Windows.Forms.Button btndw;
        private System.Windows.Forms.Button btnEI;
        private System.Windows.Forms.Button btnNG;
        private System.Windows.Forms.Button btnTex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog saveFDPDF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnRW;
    }
}