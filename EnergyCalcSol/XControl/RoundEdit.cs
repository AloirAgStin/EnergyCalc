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

            textbox.GotFocus += (source, e) =>
            {
                RemoveWatermak();
            };

            textbox.LostFocus += (source, e) =>
            {
                ApplyWatermark();
            };
            
        }

        public void RemoveWatermak()
        {
            if (_watermarkActive)
            {
                textbox.Font = new Font("Lato", 10);
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
