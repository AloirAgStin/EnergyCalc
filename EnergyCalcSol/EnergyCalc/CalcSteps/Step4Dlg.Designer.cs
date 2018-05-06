namespace EnergyCalc.CalcSteps
{
    partial class Step4Dlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step4Dlg));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.extGropBox1 = new XCtrl.ExtGropBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoftName = new System.Windows.Forms.Label();
            this.pbLoft = new System.Windows.Forms.PictureBox();
            this.cbLoftType = new XCtrl.ExtComboBox();
            this.cbLoft = new XCtrl.ExtComboBox();
            this.lblHeatType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWallsType = new System.Windows.Forms.Label();
            this.pbWalls = new System.Windows.Forms.PictureBox();
            this.extGropBox2 = new XCtrl.ExtGropBox();
            this.cbWall = new XCtrl.ExtComboBox();
            this.tbFundamentH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWallsFundament = new XCtrl.ExtComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWallsType = new XCtrl.ExtComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbFloorType = new XCtrl.ExtComboBox();
            this.cbFloor = new XCtrl.ExtComboBox();
            this.DropZone = new System.Windows.Forms.Panel();
            this.extGropBox3 = new XCtrl.ExtGropBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFloorLabel = new System.Windows.Forms.Label();
            this.pbFloor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.extGropBox1.DropZone.SuspendLayout();
            this.extGropBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoft)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalls)).BeginInit();
            this.extGropBox2.DropZone.SuspendLayout();
            this.extGropBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.extGropBox3.DropZone.SuspendLayout();
            this.extGropBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::EnergyCalc.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(734, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(187, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 28);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Шаг 4. Укажите тип отопления и тариф:";
            // 
            // extGropBox1
            // 
            this.extGropBox1.ArrowType = 0;
            this.extGropBox1.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox1.DropZone
            // 
            this.extGropBox1.DropZone.Controls.Add(this.panel1);
            this.extGropBox1.DropZone.Controls.Add(this.cbLoftType);
            this.extGropBox1.DropZone.Controls.Add(this.cbLoft);
            this.extGropBox1.DropZone.Controls.Add(this.lblHeatType);
            this.extGropBox1.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox1.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox1.DropZone.Name = "DropZone";
            this.extGropBox1.DropZone.Size = new System.Drawing.Size(300, 372);
            this.extGropBox1.DropZone.TabIndex = 0;
            this.extGropBox1.LineW = 4;
            this.extGropBox1.Location = new System.Drawing.Point(10, 75);
            this.extGropBox1.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox1.Name = "extGropBox1";
            this.extGropBox1.Size = new System.Drawing.Size(300, 372);
            this.extGropBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoftName);
            this.panel1.Controls.Add(this.pbLoft);
            this.panel1.Location = new System.Drawing.Point(30, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 243);
            this.panel1.TabIndex = 24;
            // 
            // lblLoftName
            // 
            this.lblLoftName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoftName.AutoSize = true;
            this.lblLoftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblLoftName.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblLoftName.Location = new System.Drawing.Point(20, 219);
            this.lblLoftName.Name = "lblLoftName";
            this.lblLoftName.Size = new System.Drawing.Size(166, 13);
            this.lblLoftName.TabIndex = 21;
            this.lblLoftName.Text = "Утеплитель Knauf Insultion";
            // 
            // pbLoft
            // 
            this.pbLoft.Location = new System.Drawing.Point(4, 4);
            this.pbLoft.Name = "pbLoft";
            this.pbLoft.Size = new System.Drawing.Size(240, 236);
            this.pbLoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoft.TabIndex = 17;
            this.pbLoft.TabStop = false;
            // 
            // cbLoftType
            // 
            this.cbLoftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoftType.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbLoftType, 2);
            this.cbLoftType.Location = new System.Drawing.Point(33, 334);
            this.cbLoftType.Name = "cbLoftType";
            this.cbLoftType.Size = new System.Drawing.Size(244, 21);
            this.cbLoftType.TabIndex = 1;
            // 
            // cbLoft
            // 
            this.cbLoft.BackColor = System.Drawing.Color.White;
            this.cbLoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoft.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbLoft, 2);
            this.cbLoft.Location = new System.Drawing.Point(30, 61);
            this.cbLoft.Name = "cbLoft";
            this.cbLoft.Size = new System.Drawing.Size(247, 21);
            this.cbLoft.TabIndex = 0;
            this.cbLoft.SelectedIndexChanged += new System.EventHandler(this.cbLoft_SelectedIndexChanged);
            // 
            // lblHeatType
            // 
            this.lblHeatType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeatType.AutoSize = true;
            this.lblHeatType.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHeatType.Location = new System.Drawing.Point(55, 22);
            this.lblHeatType.Name = "lblHeatType";
            this.lblHeatType.Size = new System.Drawing.Size(172, 24);
            this.lblHeatType.TabIndex = 19;
            this.lblHeatType.Text = "Утепление чердака";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWallsType);
            this.panel2.Controls.Add(this.pbWalls);
            this.panel2.Location = new System.Drawing.Point(30, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 248);
            this.panel2.TabIndex = 25;
            // 
            // lblWallsType
            // 
            this.lblWallsType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWallsType.AutoSize = true;
            this.lblWallsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblWallsType.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblWallsType.Location = new System.Drawing.Point(31, 219);
            this.lblWallsType.Name = "lblWallsType";
            this.lblWallsType.Size = new System.Drawing.Size(166, 13);
            this.lblWallsType.TabIndex = 21;
            this.lblWallsType.Text = "Утеплитель Knauf Insultion";
            // 
            // pbWalls
            // 
            this.pbWalls.Location = new System.Drawing.Point(3, 4);
            this.pbWalls.Name = "pbWalls";
            this.pbWalls.Size = new System.Drawing.Size(240, 239);
            this.pbWalls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWalls.TabIndex = 22;
            this.pbWalls.TabStop = false;
            // 
            // extGropBox2
            // 
            this.extGropBox2.ArrowType = 0;
            this.extGropBox2.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox2.DropZone
            // 
            this.extGropBox2.DropZone.Controls.Add(this.cbWall);
            this.extGropBox2.DropZone.Controls.Add(this.tbFundamentH);
            this.extGropBox2.DropZone.Controls.Add(this.label6);
            this.extGropBox2.DropZone.Controls.Add(this.label5);
            this.extGropBox2.DropZone.Controls.Add(this.cbWallsFundament);
            this.extGropBox2.DropZone.Controls.Add(this.label4);
            this.extGropBox2.DropZone.Controls.Add(this.cbWallsType);
            this.extGropBox2.DropZone.Controls.Add(this.label1);
            this.extGropBox2.DropZone.Controls.Add(this.panel2);
            this.extGropBox2.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox2.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox2.DropZone.Name = "DropZone";
            this.extGropBox2.DropZone.Size = new System.Drawing.Size(299, 451);
            this.extGropBox2.DropZone.TabIndex = 0;
            this.extGropBox2.LineW = 4;
            this.extGropBox2.Location = new System.Drawing.Point(316, 75);
            this.extGropBox2.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox2.Name = "extGropBox2";
            this.extGropBox2.Size = new System.Drawing.Size(299, 451);
            this.extGropBox2.TabIndex = 26;
            // 
            // cbWall
            // 
            this.cbWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWall.FormattingEnabled = true;
            this.cbWall.Location = new System.Drawing.Point(30, 61);
            this.cbWall.Name = "cbWall";
            this.cbWall.Size = new System.Drawing.Size(247, 21);
            this.cbWall.TabIndex = 2;
            this.cbWall.SelectedIndexChanged += new System.EventHandler(this.cbWalls_SelectedIndexChanged);
            // 
            // tbFundamentH
            // 
            this.err2.SetIconPadding(this.tbFundamentH, 38);
            this.err1.SetIconPadding(this.tbFundamentH, 38);
            this.tbFundamentH.Location = new System.Drawing.Point(193, 419);
            this.tbFundamentH.Name = "tbFundamentH";
            this.tbFundamentH.Size = new System.Drawing.Size(39, 20);
            this.tbFundamentH.TabIndex = 5;
            this.tbFundamentH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(238, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "мм";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Толщина основания";
            // 
            // cbWallsFundament
            // 
            this.cbWallsFundament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWallsFundament.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbWallsFundament, 2);
            this.cbWallsFundament.Location = new System.Drawing.Point(30, 390);
            this.cbWallsFundament.Name = "cbWallsFundament";
            this.cbWallsFundament.Size = new System.Drawing.Size(247, 21);
            this.cbWallsFundament.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(69, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Материал основания";
            // 
            // cbWallsType
            // 
            this.cbWallsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWallsType.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbWallsType, 2);
            this.cbWallsType.Location = new System.Drawing.Point(30, 340);
            this.cbWallsType.Name = "cbWallsType";
            this.cbWallsType.Size = new System.Drawing.Size(247, 21);
            this.cbWallsType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Утепление стен";
            // 
            // err1
            // 
            this.err1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err1.ContainerControl = this;
            this.err1.Icon = ((System.Drawing.Icon)(resources.GetObject("err1.Icon")));
            // 
            // cbFloorType
            // 
            this.cbFloorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloorType.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbFloorType, 2);
            this.cbFloorType.Location = new System.Drawing.Point(33, 337);
            this.cbFloorType.Name = "cbFloorType";
            this.cbFloorType.Size = new System.Drawing.Size(244, 21);
            this.cbFloorType.TabIndex = 7;
            // 
            // cbFloor
            // 
            this.cbFloor.BackColor = System.Drawing.Color.White;
            this.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloor.FormattingEnabled = true;
            this.err1.SetIconPadding(this.cbFloor, 2);
            this.cbFloor.Location = new System.Drawing.Point(30, 61);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(247, 21);
            this.cbFloor.TabIndex = 6;
            this.cbFloor.SelectedIndexChanged += new System.EventHandler(this.cbFloor_SelectedIndexChanged);
            // 
            // DropZone
            // 
            this.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropZone.Location = new System.Drawing.Point(0, 0);
            this.DropZone.Name = "DropZone";
            this.DropZone.Size = new System.Drawing.Size(300, 372);
            this.DropZone.TabIndex = 0;
            // 
            // extGropBox3
            // 
            this.extGropBox3.ArrowType = 0;
            this.extGropBox3.BackColor = System.Drawing.Color.Transparent;
            this.extGropBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGropBox3.DropZone
            // 
            this.extGropBox3.DropZone.Controls.Add(this.panel3);
            this.extGropBox3.DropZone.Controls.Add(this.cbFloorType);
            this.extGropBox3.DropZone.Controls.Add(this.cbFloor);
            this.extGropBox3.DropZone.Controls.Add(this.label3);
            this.extGropBox3.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGropBox3.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGropBox3.DropZone.Name = "DropZone";
            this.extGropBox3.DropZone.Size = new System.Drawing.Size(300, 372);
            this.extGropBox3.DropZone.TabIndex = 0;
            this.extGropBox3.LineW = 4;
            this.extGropBox3.Location = new System.Drawing.Point(621, 75);
            this.extGropBox3.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGropBox3.Name = "extGropBox3";
            this.extGropBox3.Size = new System.Drawing.Size(300, 372);
            this.extGropBox3.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFloorLabel);
            this.panel3.Controls.Add(this.pbFloor);
            this.panel3.Location = new System.Drawing.Point(30, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 243);
            this.panel3.TabIndex = 24;
            // 
            // lblFloorLabel
            // 
            this.lblFloorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFloorLabel.AutoSize = true;
            this.lblFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblFloorLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblFloorLabel.Location = new System.Drawing.Point(20, 219);
            this.lblFloorLabel.Name = "lblFloorLabel";
            this.lblFloorLabel.Size = new System.Drawing.Size(166, 13);
            this.lblFloorLabel.TabIndex = 21;
            this.lblFloorLabel.Text = "Утеплитель Knauf Insultion";
            // 
            // pbFloor
            // 
            this.pbFloor.Location = new System.Drawing.Point(4, 4);
            this.pbFloor.Name = "pbFloor";
            this.pbFloor.Size = new System.Drawing.Size(240, 236);
            this.pbFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFloor.TabIndex = 17;
            this.pbFloor.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(49, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Утепление пола первого этажа:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // err2
            // 
            this.err2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err2.ContainerControl = this;
            this.err2.Icon = ((System.Drawing.Icon)(resources.GetObject("err2.Icon")));
            // 
            // Step4Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 534);
            this.Controls.Add(this.extGropBox3);
            this.Controls.Add(this.extGropBox2);
            this.Controls.Add(this.extGropBox1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step4Dlg";
            this.Text = "Step4Dlg";
            this.Load += new System.EventHandler(this.Step4Dlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.extGropBox1.DropZone.ResumeLayout(false);
            this.extGropBox1.DropZone.PerformLayout();
            this.extGropBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoft)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalls)).EndInit();
            this.extGropBox2.DropZone.ResumeLayout(false);
            this.extGropBox2.DropZone.PerformLayout();
            this.extGropBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.extGropBox3.DropZone.ResumeLayout(false);
            this.extGropBox3.DropZone.PerformLayout();
            this.extGropBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
        private XCtrl.ExtGropBox extGropBox1;
        private System.Windows.Forms.PictureBox pbLoft;
        private System.Windows.Forms.Label lblHeatType;
        private XCtrl.ExtComboBox cbLoft;
        private XCtrl.ExtComboBox cbLoftType;
        private System.Windows.Forms.Label lblLoftName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWallsType;
        private XCtrl.ExtGropBox extGropBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err1;
        private XCtrl.ExtComboBox cbWallsType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private XCtrl.ExtComboBox cbWallsFundament;
        private System.Windows.Forms.TextBox tbFundamentH;
        private System.Windows.Forms.Label label6;
        private XCtrl.ExtGropBox extGropBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFloorLabel;
        private System.Windows.Forms.PictureBox pbFloor;
        private XCtrl.ExtComboBox cbFloorType;
        private XCtrl.ExtComboBox cbFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbWalls;
        private System.Windows.Forms.Panel DropZone;
        private XCtrl.ExtComboBox cbWall;
        private System.Windows.Forms.ErrorProvider err2;
    }
}