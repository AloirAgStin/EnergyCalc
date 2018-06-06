using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace XControl
{
    public partial class RoundEdit : UserControl
    {
        public RoundEdit()
        {
            SetStyle(ControlStyles.Selectable, true);
            InitializeComponent();
            Size = new Size(270, 60);
            BorderColor = Color.FromArgb(105, 203, 242);
            BackButtonColor = Color.White;
            BorderWidth = 2;
            Radius = 30;
            AddTextEnable = false;
            label1.Parent = this;

            TBFontInit = TBFont;
            SetDefaultText();
            
        }
        public Font TBFont
        {
            get => textBox1.Font;
            set => textBox1.Font = value;

        }

        private Font TBFontInit;

        public int TBMaxLenght
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }

        public String TBText
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
          
        public HorizontalAlignment TBTextAlign
        {
            get => textBox1.TextAlign;
            set => textBox1.TextAlign = value;
        }
        

        public bool AddTextEnable { get; set; }
        public String AddText { get; set; }

        public Color BorderColor { get; set; }
        public Color BackButtonColor { get; set; }

        public int BorderWidth { get; set; }

        public int Radius { get; set; }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var ButtonBorderColor = Color.Red;

            ClientRectangle.Inflate(-3, -3);



            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var pen = new Pen(BorderColor, BorderWidth))
                e.Graphics.DrawPath(pen, Path);

            using (var brush = new LinearGradientBrush(ClientRectangle, BackButtonColor, 
                BackButtonColor, LinearGradientMode.Vertical))
                e.Graphics.FillPath(brush, Path);
                
            label1.Text = AddText;
            if(!AddTextEnable)
            {
                textBox1.Visible = false;
                label1.Visible = false;
            }


            if (Focused)
            {
                ClientRectangle.Inflate(-3, -3);
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Dotted);
            }
            else
            {
            }



        }

        protected GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-4, -4);
                return GetRoundedRectangle(rect, Radius);
            }
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();

            return gp;
        }

        public String TBDefaultText { get; set; }

        public void SetDefaultText()
        {
            TBFontInit = textBox1.Font;
            textBox1.Font = new Font("Lato", 8);
            textBox1.Text = TBDefaultText;
            textBox1.Invalidate();
        }
        private void SetNormalText()
        {            
            textBox1.Font = TBFontInit;
            textBox1.Text = "";
        }

        

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Focused ? SystemColors.Highlight : SystemColors.Control);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (TBDefaultText == null)
                TBDefaultText = "";

            if (textBox1.Text == TBDefaultText)
            {
                SetNormalText();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                SetDefaultText();
            }
            else
                textBox1.Font = TBFontInit; ;
        }
  
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!Focused)
                Focus();
            base.OnMouseDown(e);
        }
        
    }
}
