using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel.Design;
using System;

namespace XCotrols
{
   public class RoundPanel : UserControl
    {
        public RoundPanel()
        {
            Size = new Size(50, 40);

            BorderColor = Color.FromArgb(105, 203, 242);
            BackColorInBorder = Color.White;

            BorderWidth = 2;
            Radius = 20;

            Paint += RoundPanel_Paint1;

            SetStyle(ControlStyles.Selectable, true);

            IsFocus = false;
        }

        private bool IsFocus;
        protected override void OnGotFocus(EventArgs e)
        {
            IsFocus = true;
            Invalidate();
        }
        
        protected override void OnLostFocus(EventArgs e)
        {
            IsFocus = false;
            Invalidate();
        }


        private void RoundPanel_Paint1(object sender, PaintEventArgs e)
        {
            /*
            if (IsFocus)
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Dashed);
            else
            {
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, SystemColors.Control, ButtonBorderStyle.Dashed);
            }
            */
            var ButtonBorderColor = Color.Red;

            using (var pen = new Pen(BorderColor, BorderWidth))
                e.Graphics.DrawPath(pen, Path);

            using (var brush = new SolidBrush(BackColorInBorder))
                e.Graphics.FillPath(brush, Path);
        }

        [Description("Border Color"), Category("RoundBorderProperty")]
        public Color BorderColor { get; set; }

        [Description("Background color"), Category("RoundBorderProperty")]
        public Color BackColorInBorder { get; set; }

        [Description("Border width"), Category("RoundBorderProperty")]
        public int BorderWidth { get; set; }

        [Description("Border radius"), Category("RoundBorderProperty")]
        public int Radius { get; set; }


        protected GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-BorderWidth, -BorderWidth);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RoundPanel
            // 
            this.Name = "RoundPanel";
            this.Size = new System.Drawing.Size(162, 39);
            this.ResumeLayout(false);

        }
    }
}