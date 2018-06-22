using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace XCotrols
{
    public class ExtProgressBar : ProgressBar
    {
        public ExtProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            ProgressColor = Color.LightSkyBlue;
            ProgressColor2 = SystemColors.Highlight;

            TextFont = new Font("Arial", 12);
            TextColor = ForeColor;
            ProgressText = "";

            IsDrawText = true;

        }

        [Description("Draw progress text"), Category("Appearance")]
        public bool IsDrawText { get; set; }


        [Description("Progress text, default percent"), Category("Appearance")]
        public String ProgressText { get; set; }

        [Description(""), Category("Appearance")]
        public Color ProgressColor { get; set; }
        [Description(""), Category("Appearance")]
        public Color ProgressColor2 { get; set; }

        [Description(""), Category("Appearance")]
        public Font TextFont { get; set; }
        [Description(""), Category("Appearance")]
        public Color TextColor { get; set; }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;


            using (var br = new LinearGradientBrush(new Point(2, 2), new Point(2 + rec.Width, 2 + rec.Height), ProgressColor, ProgressColor2))
                g.FillRectangle(br, 2, 2, rec.Width, rec.Height);

            if (!IsDrawText)
                return;

            rec = e.ClipRectangle;
            rec.Inflate(0, 5);

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;


            string text = ProgressText.Length > 0 ? ProgressText : this.Value.ToString() + '%';

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(text, TextFont, (Brushes.Black), ClientRectangle, sf);
            }

        }
    }
}