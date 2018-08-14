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
            this._RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            //
            // _RichTextBox
            //
            this._RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._RichTextBox.Location = new System.Drawing.Point(17, 13);
            this._RichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._RichTextBox.Name = "_RichTextBox";
            this._RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this._RichTextBox.Size = new System.Drawing.Size(322, 18);
            this._RichTextBox.TabIndex = 0;
            this._RichTextBox.Text = "";
            //
            // RoundEdit
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._RichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoundEdit";
            this.Size = new System.Drawing.Size(356, 39);
            this.Load += new System.EventHandler(this.RoundEdit_Load);
            this.ForeColorChanged += new System.EventHandler(this.RoundEdit_ForeColorChanged);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox _RichTextBox;
    }
}