using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCotrols;
using System.Globalization;

namespace XControl
{
    public partial class RoundEdit : RoundPanel
    {
        public RoundEdit() : base()
        {
            InitializeComponent();
            
            _watermarkActive = true;
            textbox.Text = _watermarkText;
            textbox.ForeColor = Color.Gray;

            MaxTextLenght = 5;
            IsDigitOnly = false;

            textbox.GotFocus += (source, e) =>
            {
                RemoveWatermak();
            };

            textbox.LostFocus += (source, e) =>
            {
                ApplyWatermark();
            };

            textbox.KeyPress += Textbox_KeyPress;

        }
 
        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!IsDigitOnly) return;

            
            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

            string c = e.KeyChar.ToString();
            if (char.IsDigit(c, 0))
                return;

            if ((textbox.SelectionStart == 0) && (c.Equals(fi.NegativeSign)))
                return;

            // copy/paste
            if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
                && ((ModifierKeys & Keys.Control) == Keys.Control))
                return;

            if (e.KeyChar == '\b')
                return;

            e.Handled = true;
        }
        
        public bool IsDigitOnly {get;set;}

        public int MaxTextLenght {
            get
            {
                return textbox.MaxLength;
            }
            set
            {
                textbox.MaxLength = value;
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_PASTE = 0x0302;
            if (m.Msg == WM_PASTE)
            {
                string text = Clipboard.GetText();
                if (string.IsNullOrEmpty(text))
                    return;

                if (IsDigitOnly)
                {
                    if ((text.IndexOf('+') >= 0) && (textbox.SelectionStart != 0))
                        return;

                    int i;
                    if (!int.TryParse(text, out i)) // change this for other integer types
                        return;

                    if ((i < 0) && (textbox.SelectionStart != 0))
                        return;
                }
            }
            base.WndProc(ref m);
        }

        public void RemoveWatermak()
        {
            if (_watermarkActive)
            {
                textbox.Font = new Font("Lato", 10, FontStyle.Bold);
                textbox.ForeColor = Color.Black;

                _watermarkActive = false;
                textbox.Text = "";
            }
        }

        private Font _WaterMarkFont = new Font("Lato", 9.25f, FontStyle.Bold);

        public void ApplyWatermark(string newText)
        {

            WatermarkText = newText;
            ApplyWatermark();
        }

        public void ApplyWatermark()
        {
            if (!_watermarkActive && string.IsNullOrEmpty(textbox.Text)
                || ForeColor == Color.Gray)
            {
                _watermarkActive = true;
                if (Parent.Enabled)
                {
                    textbox.Font = _WaterMarkFont;
                    textbox.Text = _watermarkText;
                }
                else
                {

                    textbox.Font = new Font("Lato", 10);
                    textbox.Text = "";
                }

                textbox.ForeColor = Color.Gray;
            }
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    
        private void RoundEdit_FontChanged(object sender, EventArgs e)
        {
            textbox.Font = Font;
        }
        private bool _watermarkActive = true;
        public bool WatermarkActive
        {
            get { return _watermarkActive;  }
            set { _watermarkActive = value; }
        }
        private string _watermarkText = "Введите значение";
        public string WatermarkText
        {
            get { return _watermarkText; }
            set { _watermarkText = value; }
        }

        private void RoundEdit_ForeColorChanged(object sender, EventArgs e)
        {
            textbox.ForeColor = ForeColor;
        }
    }
}
