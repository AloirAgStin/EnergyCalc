using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel.Design;
using System;

namespace XCotrols
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
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

            DoubleBuffered = true;

        }

        protected override void OnGotFocus(EventArgs e)
        {
         //   Invalidate();
        }
        
        protected override void OnLostFocus(EventArgs e)
        {
          //  Invalidate();
        }
        
        private void RoundPanel_Paint1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var ButtonBorderColor = Color.Red;

            using (var pen = new Pen(BorderColor, BorderWidth))
                e.Graphics.DrawPath(pen, Path);


            var backColor = Enabled ? BackColorInBorder : SystemColors.Control;

            using (var brush = new SolidBrush(backColor))
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