namespace XControl
{
    partial class RoundEdit
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.Location = new System.Drawing.Point(17, 7);
            this.textbox.Margin = new System.Windows.Forms.Padding(4);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(183, 16);
            this.textbox.TabIndex = 0;
            // 
            // RoundEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textbox);
            this.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoundEdit";
            this.Size = new System.Drawing.Size(243, 32);
            this.FontChanged += new System.EventHandler(this.RoundEdit_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.RoundEdit_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textbox;
    }
}
