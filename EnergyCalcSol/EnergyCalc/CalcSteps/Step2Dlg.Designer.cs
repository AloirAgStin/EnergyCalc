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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2Dlg));
            this.imlBuildsType = new System.Windows.Forms.ImageList(this.components);
            this.cbBuildingType = new XCtrl.ExtComboBox();
            this.extGBTypeBuild = new XCtrl.ExtGropBox();
            this.pbArroy = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBCountFloor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBHBasement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBSkat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBWight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBLenght = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbHeatingType = new XCtrl.ExtPictureBox();
            this.lblBuildSize = new System.Windows.Forms.Label();
            this.lblHeatType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbMainImg = new XCtrl.ExtPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.extGBTypeBuild.DropZone.SuspendLayout();
            this.extGBTypeBuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeatingType)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlBuildsType
            // 
            this.imlBuildsType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBuildsType.ImageStream")));
            this.imlBuildsType.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBuildsType.Images.SetKeyName(0, "bt_1.png");
            this.imlBuildsType.Images.SetKeyName(1, "bt_2.png");
            this.imlBuildsType.Images.SetKeyName(2, "bt_3.png");
            this.imlBuildsType.Images.SetKeyName(3, "bt_4.png");
            this.imlBuildsType.Images.SetKeyName(4, "bt_5.png");
            this.imlBuildsType.Images.SetKeyName(5, "bt_6.png");
            // 
            // cbBuildingType
            // 
            this.cbBuildingType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuildingType.BackColor = System.Drawing.Color.White;
            this.cbBuildingType.DisplayMember = "0";
            this.cbBuildingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuildingType.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.cbBuildingType.FormattingEnabled = true;
            this.err2.SetIconPadding(this.cbBuildingType, 2);
            this.err1.SetIconPadding(this.cbBuildingType, 2);
            this.cbBuildingType.Location = new System.Drawing.Point(387, 10);
            this.cbBuildingType.Name = "cbBuildingType";
            this.cbBuildingType.Size = new System.Drawing.Size(476, 27);
            this.cbBuildingType.TabIndex = 10;
            this.cbBuildingType.ValueMember = "0";
            this.cbBuildingType.SelectedIndexChanged += new System.EventHandler(this.cbHeatingType_SelectedIndexChanged);
            // 
            // extGBTypeBuild
            // 
            this.extGBTypeBuild.ArrowType = 0;
            this.extGBTypeBuild.BackColor = System.Drawing.Color.Transparent;
            this.extGBTypeBuild.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            // 
            // extGBTypeBuild.DropZone
            // 
            this.extGBTypeBuild.DropZone.AllowDrop = true;
            this.extGBTypeBuild.DropZone.Controls.Add(this.pbArroy);
            this.extGBTypeBuild.DropZone.Controls.Add(this.pictureBox2);
            this.extGBTypeBuild.DropZone.Controls.Add(this.panel1);
            this.extGBTypeBuild.DropZone.Controls.Add(this.label7);
            this.extGBTypeBuild.DropZone.Controls.Add(this.pbHeatingType);
            this.extGBTypeBuild.DropZone.Controls.Add(this.lblBuildSize);
            this.extGBTypeBuild.DropZone.Controls.Add(this.lblHeatType);
            this.extGBTypeBuild.DropZone.Controls.Add(this.panel2);
            this.extGBTypeBuild.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extGBTypeBuild.DropZone.Location = new System.Drawing.Point(0, 0);
            this.extGBTypeBuild.DropZone.Name = "DropZone";
            this.extGBTypeBuild.DropZone.Size = new System.Drawing.Size(277, 571);
            this.extGBTypeBuild.DropZone.TabIndex = 0;
            this.extGBTypeBuild.LineW = 4;
            this.extGBTypeBuild.Location = new System.Drawing.Point(1, 41);
            this.extGBTypeBuild.MinimumSize = new System.Drawing.Size(188, 65);
            this.extGBTypeBuild.Name = "extGBTypeBuild";
            this.extGBTypeBuild.Size = new System.Drawing.Size(277, 571);
            this.extGBTypeBuild.TabIndex = 17;
            // 
            // pbArroy
            // 
            this.pbArroy.Image = global::EnergyCalc.Properties.Resources.arrow;
            this.pbArroy.Location = new System.Drawing.Point(2, 234);
            this.pbArroy.Name = "pbArroy";
            this.pbArroy.Size = new System.Drawing.Size(46, 46);
            this.pbArroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbArroy.TabIndex = 21;
            this.pbArroy.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EnergyCalc.Properties.Resources.arrow;
            this.pictureBox2.Location = new System.Drawing.Point(2, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10000;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbBCountFloor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbBHBasement);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbBSkat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbBHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbBWight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBLenght);
            this.panel1.Location = new System.Drawing.Point(22, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 161);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Количество этажей";
            // 
            // tbBCountFloor
            // 
            this.err2.SetIconPadding(this.tbBCountFloor, 2);
            this.err1.SetIconPadding(this.tbBCountFloor, 2);
            this.tbBCountFloor.Location = new System.Drawing.Point(170, 134);
            this.tbBCountFloor.MaxLength = 5;
            this.tbBCountFloor.Name = "tbBCountFloor";
            this.tbBCountFloor.Size = new System.Drawing.Size(40, 20);
            this.tbBCountFloor.TabIndex = 16;
            this.tbBCountFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod2);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Высота подавала, м";
            // 
            // tbBHBasement
            // 
            this.err2.SetIconPadding(this.tbBHBasement, 2);
            this.err1.SetIconPadding(this.tbBHBasement, 2);
            this.tbBHBasement.Location = new System.Drawing.Point(170, 109);
            this.tbBHBasement.MaxLength = 5;
            this.tbBHBasement.Name = "tbBHBasement";
            this.tbBHBasement.Size = new System.Drawing.Size(40, 20);
            this.tbBHBasement.TabIndex = 15;
            this.tbBHBasement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Высота конька, м";
            // 
            // tbBSkat
            // 
            this.err2.SetIconPadding(this.tbBSkat, 2);
            this.err1.SetIconPadding(this.tbBSkat, 2);
            this.tbBSkat.Location = new System.Drawing.Point(170, 83);
            this.tbBSkat.MaxLength = 5;
            this.tbBSkat.Name = "tbBSkat";
            this.tbBSkat.Size = new System.Drawing.Size(40, 20);
            this.tbBSkat.TabIndex = 14;
            this.tbBSkat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Высота до ската, м";
            // 
            // tbBHeight
            // 
            this.err2.SetIconPadding(this.tbBHeight, 2);
            this.err1.SetIconPadding(this.tbBHeight, 2);
            this.tbBHeight.Location = new System.Drawing.Point(170, 57);
            this.tbBHeight.MaxLength = 5;
            this.tbBHeight.Name = "tbBHeight";
            this.tbBHeight.Size = new System.Drawing.Size(40, 20);
            this.tbBHeight.TabIndex = 13;
            this.tbBHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ширина здания, м";
            // 
            // tbBWight
            // 
            this.err2.SetIconPadding(this.tbBWight, 2);
            this.err1.SetIconPadding(this.tbBWight, 2);
            this.tbBWight.Location = new System.Drawing.Point(170, 31);
            this.tbBWight.MaxLength = 5;
            this.tbBWight.Name = "tbBWight";
            this.tbBWight.Size = new System.Drawing.Size(40, 20);
            this.tbBWight.TabIndex = 12;
            this.tbBWight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Длина здания, м";
            // 
            // tbBLenght
            // 
            this.err2.SetIconPadding(this.tbBLenght, 2);
            this.err1.SetIconPadding(this.tbBLenght, 2);
            this.tbBLenght.Location = new System.Drawing.Point(170, 5);
            this.tbBLenght.MaxLength = 5;
            this.tbBLenght.Name = "tbBLenght";
            this.tbBLenght.Size = new System.Drawing.Size(40, 20);
            this.tbBLenght.TabIndex = 11;
            this.tbBLenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextBod);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(49, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Температурный режим:";
            // 
            // pbHeatingType
            // 
            this.pbHeatingType.InitialImage = global::EnergyCalc.Properties.Resources.bt_1;
            this.pbHeatingType.Location = new System.Drawing.Point(33, 60);
            this.pbHeatingType.Name = "pbHeatingType";
            this.pbHeatingType.Size = new System.Drawing.Size(225, 170);
            this.pbHeatingType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeatingType.TabIndex = 12;
            this.pbHeatingType.TabStop = false;
            this.pbHeatingType.WaitOnLoad = true;
            // 
            // lblBuildSize
            // 
            this.lblBuildSize.AutoSize = true;
            this.lblBuildSize.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildSize.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBuildSize.Location = new System.Drawing.Point(49, 244);
            this.lblBuildSize.Name = "lblBuildSize";
            this.lblBuildSize.Size = new System.Drawing.Size(153, 24);
            this.lblBuildSize.TabIndex = 13;
            this.lblBuildSize.Text = "Размеры здания:";
            // 
            // lblHeatType
            // 
            this.lblHeatType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeatType.AutoSize = true;
            this.lblHeatType.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatType.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHeatType.Location = new System.Drawing.Point(49, 24);
            this.lblHeatType.Name = "lblHeatType";
            this.lblHeatType.Size = new System.Drawing.Size(113, 24);
            this.lblHeatType.TabIndex = 11;
            this.lblHeatType.Text = "Тип здания:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbTemp);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(22, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 99);
            this.panel2.TabIndex = 20;
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.err2.SetIconPadding(this.tbTemp, 2);
            this.err1.SetIconPadding(this.tbTemp, 2);
            this.tbTemp.Location = new System.Drawing.Point(197, 12);
            this.tbTemp.MaxLength = 2;
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(25, 20);
            this.tbTemp.TabIndex = 17;
            this.tbTemp.Text = "22";
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.tbTemp.Leave += new System.EventHandler(this.tbTemp_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(203, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 10005;
            this.label11.Text = "30";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(4, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Температура внутри, °C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(164, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 10007;
            this.label13.Text = "27";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(88, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 10006;
            this.label12.Text = "21";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(47, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 10003;
            this.label9.Text = "18";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(13, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 10002;
            this.label8.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(127, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 10004;
            this.label10.Text = "24";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(8, 45);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(220, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 22;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 28);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Шаг 2. Укажите параметры дома:";
            // 
            // err1
            // 
            this.err1.BlinkRate = 100;
            this.err1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err1.ContainerControl = this;
            this.err1.Icon = ((System.Drawing.Icon)(resources.GetObject("err1.Icon")));
            // 
            // err2
            // 
            this.err2.BlinkRate = 100;
            this.err2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err2.ContainerControl = this;
            this.err2.Icon = ((System.Drawing.Icon)(resources.GetObject("err2.Icon")));
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::EnergyCalc.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(392, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(187, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // pbMainImg
            // 
            this.pbMainImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainImg.Location = new System.Drawing.Point(0, 0);
            this.pbMainImg.Name = "pbMainImg";
            this.pbMainImg.Size = new System.Drawing.Size(579, 517);
            this.pbMainImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMainImg.TabIndex = 18;
            this.pbMainImg.TabStop = false;
            this.pbMainImg.WaitOnLoad = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pbLogo);
            this.panel3.Controls.Add(this.pbMainImg);
            this.panel3.Location = new System.Drawing.Point(284, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 517);
            this.panel3.TabIndex = 21;
            // 
            // Step2Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbBuildingType);
            this.Controls.Add(this.extGBTypeBuild);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step2Dlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Step2Dlg";
            this.Load += new System.EventHandler(this.Step2Dlg_Load);
            this.extGBTypeBuild.DropZone.ResumeLayout(false);
            this.extGBTypeBuild.DropZone.PerformLayout();
            this.extGBTypeBuild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeatingType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeatType;
        private XCtrl.ExtPictureBox pbHeatingType;
        private XCtrl.ExtComboBox cbBuildingType;
        private System.Windows.Forms.Label lblBuildSize;
        private System.Windows.Forms.Panel panel1;
        private XCtrl.ExtGropBox extGBTypeBuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBLenght;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBSkat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBWight;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBHBasement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBCountFloor;
        private System.Windows.Forms.PictureBox pbArroy;
        private System.Windows.Forms.ImageList imlBuildsType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbLogo;
        private XCtrl.ExtPictureBox pbMainImg;
        private System.Windows.Forms.Panel panel3;
    }
}