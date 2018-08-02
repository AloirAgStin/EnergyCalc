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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exListBox1 = new XControl.ExListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDWG = new System.Windows.Forms.Panel();
            this.lblUserData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btndw = new System.Windows.Forms.Button();
            this.btnRW = new System.Windows.Forms.Button();
            this.btnEI = new System.Windows.Forms.Button();
            this.btnNG = new System.Windows.Forms.Button();
            this.btnTex = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBack = new XControl.SelectableLabel();
            this.btnPrint = new XControl.RoundButton();
            this.lblClose = new XControl.SelectableLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFDPDF = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.btnDWG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exListBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 510);
            this.panel1.TabIndex = 5;
            // 
            // exListBox1
            // 
            this.exListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.exListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.exListBox1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold);
            this.exListBox1.ForeColor = System.Drawing.Color.Silver;
            this.exListBox1.FormattingEnabled = true;
            this.exListBox1.ItemHeight = 25;
            this.exListBox1.Items.AddRange(new object[] {
            "ВАРИАНТ 1"});
            this.exListBox1.Location = new System.Drawing.Point(14, 82);
            this.exListBox1.Name = "exListBox1";
            this.exListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exListBox1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.exListBox1.Size = new System.Drawing.Size(192, 400);
            this.exListBox1.TabIndex = 1;
            this.exListBox1.SelectedIndexChanged += new System.EventHandler(this.exListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕЗУЛЬТАТ\r\nПОДБОРА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "03";
            // 
            // btnDWG
            // 
            this.btnDWG.AutoSize = true;
            this.btnDWG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDWG.Controls.Add(this.lblUserData);
            this.btnDWG.Controls.Add(this.label3);
            this.btnDWG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDWG.Location = new System.Drawing.Point(260, 0);
            this.btnDWG.MinimumSize = new System.Drawing.Size(0, 65);
            this.btnDWG.Name = "btnDWG";
            this.btnDWG.Size = new System.Drawing.Size(733, 65);
            this.btnDWG.TabIndex = 10;
            // 
            // lblUserData
            // 
            this.lblUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserData.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.lblUserData.Location = new System.Drawing.Point(13, 38);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(707, 22);
            this.lblUserData.TabIndex = 4;
            this.lblUserData.Text = "Rw=55дБ, EI=60; Толщина перегродки Tп=150мм;";
            this.lblUserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPDF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPDF.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnPDF.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDF.Location = new System.Drawing.Point(3, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(110, 74);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Tag = "0";
            this.btnPDF.Text = "ЧЕРТЕЖИ \r\nPDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btndw
            // 
            this.btndw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btndw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndw.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btndw.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btndw.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndw.Location = new System.Drawing.Point(119, 4);
            this.btndw.Name = "btndw";
            this.btndw.Size = new System.Drawing.Size(110, 74);
            this.btndw.TabIndex = 3;
            this.btndw.Tag = "1";
            this.btndw.Text = "ЧЕРТЕЖИ \r\nDWG";
            this.btndw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndw.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btndw.UseVisualStyleBackColor = false;
            this.btndw.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnRW
            // 
            this.btnRW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRW.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnRW.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnRW.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRW.Location = new System.Drawing.Point(235, 4);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(110, 74);
            this.btnRW.TabIndex = 4;
            this.btnRW.Tag = "2";
            this.btnRW.Text = "ПРОТОКОЛ \r\nНА Rw";
            this.btnRW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRW.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRW.UseVisualStyleBackColor = false;
            this.btnRW.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnEI
            // 
            this.btnEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEI.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnEI.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnEI.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEI.Location = new System.Drawing.Point(351, 4);
            this.btnEI.Name = "btnEI";
            this.btnEI.Size = new System.Drawing.Size(110, 74);
            this.btnEI.TabIndex = 5;
            this.btnEI.Tag = "3";
            this.btnEI.Text = "ПРОТОКОЛ \r\nНА EI ";
            this.btnEI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEI.UseVisualStyleBackColor = false;
            this.btnEI.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnNG
            // 
            this.btnNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNG.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNG.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnNG.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNG.Location = new System.Drawing.Point(467, 4);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(110, 74);
            this.btnNG.TabIndex = 6;
            this.btnNG.Tag = "4";
            this.btnNG.Text = "СЕРТИФИКАТ\r\nНА НГ";
            this.btnNG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNG.UseVisualStyleBackColor = false;
            this.btnNG.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // btnTex
            // 
            this.btnTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTex.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnTex.Image = global::KnaufinsulationWalls.Properties.Resources.dw_file;
            this.btnTex.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTex.Location = new System.Drawing.Point(583, 4);
            this.btnTex.Name = "btnTex";
            this.btnTex.Size = new System.Drawing.Size(116, 74);
            this.btnTex.TabIndex = 7;
            this.btnTex.Tag = "5";
            this.btnTex.Text = "ТЕХСВИДЕ-\r\nТЕЛЬСТВО";
            this.btnTex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTex.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTex.UseVisualStyleBackColor = false;
            this.btnTex.Click += new System.EventHandler(this.onBtnFileDownLoadClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(983, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(279, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "02. Параметры перегородки, EI";
            // 
            // lblBack
            // 
            this.lblBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBack.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.lblBack.Location = new System.Drawing.Point(473, 464);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(66, 25);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Назад";
            this.lblBack.Click += new System.EventHandler(this.label4_Click);
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
            this.btnPrint.ButtonRoundRadius = 30;
            this.btnPrint.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(547, 459);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.offsettextX = 0;
            this.btnPrint.Size = new System.Drawing.Size(202, 39);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Сохранить PDF";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblClose.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.lblClose.Location = new System.Drawing.Point(760, 465);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(85, 25);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "Закрыть";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(565, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(415, 277);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "zip";
            this.saveFileDialog1.Filter = "Файлы архива zip|*.zip";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnTex, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNG, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEI, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRW, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btndw, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPDF, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 83);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // saveFDPDF
            // 
            this.saveFDPDF.DefaultExt = "pdf";
            this.saveFDPDF.Filter = "PDF файл|*.PDF";
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDWG);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ы";
            this.Load += new System.EventHandler(this.Step3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnDWG.ResumeLayout(false);
            this.btnDWG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XControl.RoundButton btnPrint;
        private XControl.SelectableLabel lblBack;
        private System.Windows.Forms.Panel btnDWG;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label4;
        private ExListBox exListBox1;
        private SelectableLabel lblClose;
        private System.Windows.Forms.Button btndw;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.Button btnEI;
        private System.Windows.Forms.Button btnNG;
        private System.Windows.Forms.Button btnTex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog saveFDPDF;
    }
}