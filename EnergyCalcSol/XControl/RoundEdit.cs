using System;
using System.ComponentModel;
using System.Drawing;
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

            _RichTextBox.GotFocus += (source, e) =>
            {
                RemoveWatermak();
            };

            _RichTextBox.LostFocus += (source, e) =>
            {
                ApplyWatermark();
            };

            _RichTextBox.KeyPress += _RichTextBox_KeyPress;

            IsDigitOnly = false;
            MaxTextLenght = 5;

            //init rich text box
            _RichTextBox.ForeColor = Color.Gray;
            _RichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            _RichTextBox.BorderStyle = BorderStyle.None;

            _WaterMarkFont = new Font("Lato", 9.25f);
            _WaterMarkColor = Color.Gray;
        }
        public bool IsDigitOnly { get; set; }
        public int MaxTextLenght
        {
            get
            {
                return _RichTextBox.MaxLength;
            }
            set
            {
                _RichTextBox.MaxLength = value;
            }
        }

        [Description("Watermark Font"), Category("Watermark")]
        public Font _WaterMarkFont { get; set; }

        [Description("Watermark Color"), Category("Watermark")]
        public Color _WaterMarkColor { get; set; }

        public delegate void DrawTextWaterMask();

        [Description("Watermark"), Category("Print watermake text")]
        public event DrawTextWaterMask onDrawTextWaterMask;


        protected void RemoveWatermak()
        {
            _RichTextBox.Clear();
        }

        public void ApplyWatermark()
        {
            if (string.IsNullOrEmpty(_RichTextBox.Text))
            {
                if (Parent.Enabled)
                {
                    _RichTextBox.SelectionFont = _WaterMarkFont;
                    _RichTextBox.SelectionColor = _WaterMarkColor;
                    onDrawTextWaterMask?.Invoke();
                }
                else
                {
                    _RichTextBox.Text = "";
                }
            }
        }
        private void RoundEdit_Load(object sender, EventArgs e)
        {
            ApplyWatermark();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void RoundEdit_FontChanged(object sender, EventArgs e)
        {
            _RichTextBox.Font = Font;
        }

        private void RoundEdit_ForeColorChanged(object sender, EventArgs e)
        {
            _RichTextBox.ForeColor = ForeColor;
        }

        private void _RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!IsDigitOnly) return;


            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

            string c = e.KeyChar.ToString();
            if (char.IsDigit(c, 0))
                return;

            if ((_RichTextBox.SelectionStart == 0) && (c.Equals(fi.NegativeSign)))
                return;

            // copy/paste
            if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
                && ((ModifierKeys & Keys.Control) == Keys.Control))
                return;

            if (e.KeyChar == '\b')
                return;

            e.Handled = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_PASTE = 0x0302;
            if (m.Msg == WM_PASTE)
            {
                string text = Clipboard.GetText();
                if (string.IsNullOrEmpty(text))
                    return;

                if (IsDigitOnly)
                {
                    if ((text.IndexOf('+') >= 0) && (_RichTextBox.SelectionStart != 0))
                        return;

                    int i;
                    if (!int.TryParse(text, out i)) // change this for other integer types
                        return;

                    if ((i < 0) && (_RichTextBox.SelectionStart != 0))
                        return;
                }
            }
            base.WndProc(ref m);
        }
    }
}