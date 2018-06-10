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
        /*

        [Description("Add Text Align"), Category("AddText options")]
        public ContentAlignment AddTextAlign
        {
            get { return label1.TextAlign; }
            set { label1.TextAlign = value; }
 
        }

        [Description("Add Text Value"), Category("AddText options")]
        public string AddText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        */
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

        public void ApplyWatermark(string newText)
        {
            textbox.Font = new Font("Lato", 8);

            WatermarkText = newText;
            ApplyWatermark();
        }

        public void ApplyWatermark()
        {
            if (!_watermarkActive && string.IsNullOrEmpty(textbox.Text)
                || ForeColor == Color.Gray)
            {
                _watermarkActive = true;
                textbox.Text = _watermarkText;
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
