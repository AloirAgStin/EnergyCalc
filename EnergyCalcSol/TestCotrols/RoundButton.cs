using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XControl
{
    public class RoundButton : Control
    {
        public Color BackColor2 { get; set; }
        public Color ButtonBorderColor { get; set; }

        public int ButtonBorderWidth { get; set; }
        public int ButtonRoundRadius { get; set; }

        public Color ButtonHighlightColor { get; set; }
        public Color ButtonHighlightColor2 { get; set; }
        public Color ButtonHighlightForeColor { get; set; }

        public Color ButtonPressedColor { get; set; }
        public Color ButtonPressedColor2 { get; set; }
        public Color ButtonPressedForeColor { get; set; }

        private bool IsHighlighted;
        private bool IsPressed;

        public RoundButton()
        {
            Font = new Font("Lato", Font.Size);

            Color defColor = Color.FromArgb(0, 178, 236);
            Size = new Size(100, 40);

            ButtonRoundRadius = 30;
            ButtonBorderWidth = 1;

            BackColor = defColor;
            BackColor2 = defColor;
            ButtonBorderColor = defColor;

            ButtonHighlightColor = SystemColors.MenuHighlight;
            ButtonHighlightColor2 = SystemColors.MenuHighlight;

            ButtonPressedColor = Color.FromArgb(0, 178, 236); ;
            ButtonPressedColor2 = Color.FromArgb(0, 178, 236); ;
            
            ButtonPressedForeColor = Color.White;

            ForeColor = Color.White;
            ButtonHighlightForeColor = Color.White;


            this.KeyDown += RoundButton_KeyDown;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            var foreColor = IsPressed ? ButtonPressedForeColor : IsHighlighted ? ButtonHighlightForeColor : ForeColor;
            var backColor = IsPressed ? ButtonPressedColor : IsHighlighted ? ButtonHighlightColor : BackColor;
            var backColor2 = IsPressed ? ButtonPressedColor2 : IsHighlighted ? ButtonHighlightColor2 : BackColor2;


            using (var pen = new Pen(ButtonBorderColor, ButtonBorderWidth))
                e.Graphics.DrawPath(pen, Path);

            using (var brush = new LinearGradientBrush(ClientRectangle, backColor, backColor2, LinearGradientMode.Vertical))
                e.Graphics.FillPath(brush, Path);

            using (var brush = new SolidBrush(foreColor))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                var rect = ClientRectangle;
                //rect.Inflate(-4, -4);
                rect.Y += 2;
                e.Graphics.DrawString(Text, Font, brush, rect, sf);
            }

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            IsHighlighted = true;
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHighlighted = false;
            IsPressed = false;
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            IsPressed = true;
        }

        private void RoundButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
                base.OnClick(new EventArgs());
        }

    
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            IsPressed = false;
        }

        protected GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-1 - ButtonBorderWidth / 2, -1 - ButtonBorderWidth / 2 );
                return GetRoundedRectangle(rect, ButtonRoundRadius);
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

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
