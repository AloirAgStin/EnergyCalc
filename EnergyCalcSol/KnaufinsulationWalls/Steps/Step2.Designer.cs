using XControl;

namespace KnaufinsulationWalls.Steps
{
    partial class Step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPanel4 = new XCotrols.RoundPanel();
            this.cbCountN = new XCotrols.CustomComboBox();
            this.roundPanel3 = new XCotrols.RoundPanel();
            this.cbIsolation = new XCotrols.CustomComboBox();
            this.roundPanel2 = new XCotrols.RoundPanel();
            this.cbTP = new XCotrols.CustomComboBox();
            this.roundPanel1 = new XCotrols.RoundPanel();
            this.cbEI = new XCotrols.CustomComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vButton1 = new XCotrols.VButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_N1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBack = new XControl.SelectableLabel();
            this.btnNext = new XControl.RounButtonWithArroy();
            this.dbPictureBox1 = new XControl.DBPictureBox();
            this.pbRArroy = new System.Windows.Forms.PictureBox();
            this.pbLArroy = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRArroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLArroy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.roundPanel4);
            this.panel1.Controls.Add(this.roundPanel3);
            this.panel1.Controls.Add(this.roundPanel2);
            this.panel1.Controls.Add(this.roundPanel1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.vButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_N1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 530);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // roundPanel4
            // 
            this.roundPanel4.BackColorInBorder = System.Drawing.Color.White;
            this.roundPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(203)))), ((int)(((byte)(242)))));
            this.roundPanel4.BorderWidth = 2;
            this.roundPanel4.Controls.Add(this.cbCountN);
            this.roundPanel4.Location = new System.Drawing.Point(16, 406);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Radius = 35;
            this.roundPanel4.Size = new System.Drawing.Size(258, 40);
            this.roundPanel4.TabIndex = 6;
            // 
            // cbCountN
            // 
            this.cbCountN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountN.ColorActiveItem = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.cbCountN.ColorDeactiveItem = System.Drawing.Color.White;
            this.cbCountN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCountN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountN.DropDownWidth = 231;
            this.cbCountN.Font = new System.Drawing.Font("Lato", 10F);
            this.cbCountN.ForeColor = System.Drawing.Color.DimGray;
            this.cbCountN.ForeColorFirstItem = System.Drawing.Color.DimGray;
            this.cbCountN.FormattingEnabled = true;
            this.cbCountN.Location = new System.Drawing.Point(14, 9);
            this.cbCountN.Name = "cbCountN";
            this.cbCountN.Size = new System.Drawing.Size(231, 24);
            this.cbCountN.TabIndex = 6;
            this.cbCountN.Enter += new System.EventHandler(this.onFocusCombo);
            this.cbCountN.Leave += new System.EventHandler(this.onLeaveCombo);
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColorInBorder = System.Drawing.Color.White;
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(203)))), ((int)(((byte)(242)))));
            this.roundPanel3.BorderWidth = 2;
            this.roundPanel3.Controls.Add(this.cbIsolation);
            this.roundPanel3.Location = new System.Drawing.Point(16, 340);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Radius = 35;
            this.roundPanel3.Size = new System.Drawing.Size(258, 40);
            this.roundPanel3.TabIndex = 5;
            // 
            // cbIsolation
            // 
            this.cbIsolation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsolation.ColorActiveItem = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.cbIsolation.ColorDeactiveItem = System.Drawing.Color.White;
            this.cbIsolation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbIsolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsolation.DropDownWidth = 231;
            this.cbIsolation.Font = new System.Drawing.Font("Lato", 10F);
            this.cbIsolation.ForeColor = System.Drawing.Color.DimGray;
            this.cbIsolation.ForeColorFirstItem = System.Drawing.Color.DimGray;
            this.cbIsolation.FormattingEnabled = true;
            this.cbIsolation.Location = new System.Drawing.Point(14, 9);
            this.cbIsolation.Name = "cbIsolation";
            this.cbIsolation.Size = new System.Drawing.Size(231, 24);
            this.cbIsolation.TabIndex = 5;
            this.cbIsolation.SelectedIndexChanged += new System.EventHandler(this.onChangeTi);
            this.cbIsolation.Enter += new System.EventHandler(this.onFocusCombo);
            this.cbIsolation.Leave += new System.EventHandler(this.onLeaveCombo);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColorInBorder = System.Drawing.Color.White;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(203)))), ((int)(((byte)(242)))));
            this.roundPanel2.BorderWidth = 2;
            this.roundPanel2.Controls.Add(this.cbTP);
            this.roundPanel2.Location = new System.Drawing.Point(16, 214);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radius = 35;
            this.roundPanel2.Size = new System.Drawing.Size(258, 40);
            this.roundPanel2.TabIndex = 4;
            // 
            // cbTP
            // 
            this.cbTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTP.ColorActiveItem = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.cbTP.ColorDeactiveItem = System.Drawing.Color.White;
            this.cbTP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTP.DropDownWidth = 231;
            this.cbTP.Font = new System.Drawing.Font("Lato", 10F);
            this.cbTP.ForeColor = System.Drawing.Color.DimGray;
            this.cbTP.ForeColorFirstItem = System.Drawing.Color.DimGray;
            this.cbTP.FormattingEnabled = true;
            this.cbTP.Location = new System.Drawing.Point(14, 9);
            this.cbTP.Name = "cbTP";
            this.cbTP.Size = new System.Drawing.Size(231, 24);
            this.cbTP.TabIndex = 3;
            this.cbTP.SelectedIndexChanged += new System.EventHandler(this.onChangeTp);
            this.cbTP.Enter += new System.EventHandler(this.onFocusCombo);
            this.cbTP.Leave += new System.EventHandler(this.onLeaveCombo);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColorInBorder = System.Drawing.Color.White;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(203)))), ((int)(((byte)(242)))));
            this.roundPanel1.BorderWidth = 2;
            this.roundPanel1.Controls.Add(this.cbEI);
            this.roundPanel1.Location = new System.Drawing.Point(16, 149);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 35;
            this.roundPanel1.Size = new System.Drawing.Size(258, 40);
            this.roundPanel1.TabIndex = 2;
            // 
            // cbEI
            // 
            this.cbEI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEI.ColorActiveItem = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.cbEI.ColorDeactiveItem = System.Drawing.Color.White;
            this.cbEI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEI.DropDownWidth = 233;
            this.cbEI.Font = new System.Drawing.Font("Lato", 10F);
            this.cbEI.ForeColor = System.Drawing.Color.DimGray;
            this.cbEI.ForeColorFirstItem = System.Drawing.Color.DimGray;
            this.cbEI.FormattingEnabled = true;
            this.cbEI.Location = new System.Drawing.Point(14, 9);
            this.cbEI.Name = "cbEI";
            this.cbEI.Size = new System.Drawing.Size(233, 24);
            this.cbEI.TabIndex = 1;
            this.cbEI.SelectedIndexChanged += new System.EventHandler(this.onChangeEI);
            this.cbEI.Enter += new System.EventHandler(this.onFocusCombo);
            this.cbEI.Leave += new System.EventHandler(this.onLeaveCombo);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(28, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "КОЛ-ВО ЛИСТОВ С ОДНОЙ СТОРОНЫ, N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(28, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "ТОЛЩИНА ИЗОЛЯЦИИ, Ти ";
            // 
            // vButton1
            // 
            this.vButton1.EnablePress = false;
            this.vButton1.isPress = false;
            this.vButton1.Location = new System.Drawing.Point(239, 298);
            this.vButton1.Name = "vButton1";
            this.vButton1.PenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.vButton1.PenSize = 2;
            this.vButton1.Size = new System.Drawing.Size(21, 10);
            this.vButton1.TabIndex = 30;
            this.vButton1.TabStop = false;
            this.vButton1.Text = "vButton1";
            this.vButton1.UseVisualStyleBackColor = true;
            this.vButton1.wightDeliter = 2;
            this.vButton1.Click += new System.EventHandler(this.onClickExtParams);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label7.Location = new System.Drawing.Point(23, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "ДОПОЛОНИТЕЛЬНЫЕ ПАРАМЕТРЫ";
            this.label7.Click += new System.EventHandler(this.onClickExtParams);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(28, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ТОЛЩИНА ПЕРЕГОРОДКИ, Тп";
            // 
            // lbl_N1
            // 
            this.lbl_N1.AutoSize = true;
            this.lbl_N1.Font = new System.Drawing.Font("Lato", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_N1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_N1.Location = new System.Drawing.Point(28, 134);
            this.lbl_N1.Name = "lbl_N1";
            this.lbl_N1.Size = new System.Drawing.Size(165, 13);
            this.lbl_N1.TabIndex = 25;
            this.lbl_N1.Text = "ПРЕДЕЛ ОГНЕСТОЙКОСТИ EI";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(55, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "ОСНОВНЫЕ ПАРАМЕТРЫ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lato", 19F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПАРАМЕТРЫ\r\nПЕРЕГОРОДКИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(715, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 180);
            this.label11.TabIndex = 10;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.label4.Location = new System.Drawing.Point(811, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "03. Результат подбора";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 9.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.label12.Location = new System.Drawing.Point(382, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "01. Уровень шума Rw";
            // 
            // lblBack
            // 
            this.lblBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBack.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.lblBack.Location = new System.Drawing.Point(526, 486);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(67, 25);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Назад";
            this.lblBack.Click += new System.EventHandler(this.lbl_Back);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNext.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNext.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNext.ButtonBorderWidth = 1;
            this.btnNext.ButtonHighlightColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.ButtonHighlightColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.btnNext.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNext.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.btnNext.ButtonPressedForeColor = System.Drawing.Color.White;
            this.btnNext.ButtonRoundRadius = 35;
            this.btnNext.DrawArrow = true;
            this.btnNext.DrawArrowW = 1.6F;
            this.btnNext.DrawArrowXOffset = -5F;
            this.btnNext.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(600, 473);
            this.btnNext.Name = "btnNext";
            this.btnNext.offsettextX = 0;
            this.btnNext.Size = new System.Drawing.Size(195, 47);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "ДАЛЕЕ";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dbPictureBox1
            // 
            this.dbPictureBox1.BackColor = System.Drawing.Color.White;
            this.dbPictureBox1.Image = global::KnaufinsulationWalls.Properties.Resources.stepImage;
            this.dbPictureBox1.Location = new System.Drawing.Point(325, 11);
            this.dbPictureBox1.Name = "dbPictureBox1";
            this.dbPictureBox1.Size = new System.Drawing.Size(372, 448);
            this.dbPictureBox1.TabIndex = 9;
            this.dbPictureBox1.TabStop = false;
            // 
            // pbRArroy
            // 
            this.pbRArroy.Image = global::KnaufinsulationWalls.Properties.Resources.arroyL;
            this.pbRArroy.Location = new System.Drawing.Point(859, 94);
            this.pbRArroy.Name = "pbRArroy";
            this.pbRArroy.Size = new System.Drawing.Size(89, 50);
            this.pbRArroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRArroy.TabIndex = 22;
            this.pbRArroy.TabStop = false;
            // 
            // pbLArroy
            // 
            this.pbLArroy.Image = global::KnaufinsulationWalls.Properties.Resources.arroyR;
            this.pbLArroy.Location = new System.Drawing.Point(715, 95);
            this.pbLArroy.Name = "pbLArroy";
            this.pbLArroy.Size = new System.Drawing.Size(86, 50);
            this.pbLArroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLArroy.TabIndex = 21;
            this.pbLArroy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 35F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(800, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 56);
            this.label3.TabIndex = 20;
            this.label3.Text = "EI";
            // 
            // Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 530);
            this.Controls.Add(this.pbRArroy);
            this.Controls.Add(this.pbLArroy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dbPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(0, 430);
            this.Name = "Step2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Step2";
            this.Load += new System.EventHandler(this.Step2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRArroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLArroy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private XControl.RounButtonWithArroy btnNext;
        private SelectableLabel lblBack;
        private System.Windows.Forms.Label label5;
        private XControl.DBPictureBox dbPictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private XCotrols.VButton vButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_N1;
        private XCotrols.RoundPanel roundPanel1;
        private XCotrols.CustomComboBox cbEI;
        private XCotrols.RoundPanel roundPanel2;
        private XCotrols.CustomComboBox cbTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private XCotrols.RoundPanel roundPanel4;
        private XCotrols.CustomComboBox cbCountN;
        private XCotrols.RoundPanel roundPanel3;
        private XCotrols.CustomComboBox cbIsolation;
        private System.Windows.Forms.PictureBox pbRArroy;
        private System.Windows.Forms.PictureBox pbLArroy;
        private System.Windows.Forms.Label label3;
    }
}