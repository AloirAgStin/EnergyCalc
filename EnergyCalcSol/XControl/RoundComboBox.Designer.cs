namespace XControl
{
    partial class RoundComboBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupComboBox1 = new XCotrols.GroupComboBox();
            this.SuspendLayout();
            // 
            // groupComboBox1
            // 
            this.groupComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComboBox1.DataSource = null;
            this.groupComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupComboBox1.FormattingEnabled = true;
            this.groupComboBox1.GroupColor = System.Drawing.SystemColors.WindowText;
            this.groupComboBox1.Location = new System.Drawing.Point(16, 12);
            this.groupComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupComboBox1.Name = "groupComboBox1";
            this.groupComboBox1.Size = new System.Drawing.Size(164, 24);
            this.groupComboBox1.TabIndex = 0;
            // 
            // RoundComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupComboBox1);
            this.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoundComboBox";
            this.Size = new System.Drawing.Size(197, 46);
            this.ResumeLayout(false);

        }

        #endregion

        public XCotrols.GroupComboBox groupComboBox1;
    }
}
