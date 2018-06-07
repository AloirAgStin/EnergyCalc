using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace XCotrols
{
    public class VButton : Button
    {
        public VButton() : base()
        {
            Size = new Size(10, 10);
            PenColor = Color.FromArgb(8, 175, 230);
            PenSize = 3;
            wightDeliter = 4;

            isPress = false;
            EnablePress = true;
        }

        public int PenSize { get; set; }
        public bool EnablePress { get; set; }
        public int wightDeliter { get; set; }
        public Color PenColor { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            ButtonRenderer.DrawParentBackground(e.Graphics, ClientRectangle, this);

            
            GraphicsPath path = new GraphicsPath();
            if(!isPress)
            {
                path.AddLine(   new PointF(PenSize, PenSize), 
                                new PointF(ClientRectangle.Width / wightDeliter, ClientRectangle.Height - PenSize) 
                               );

                path.AddLine(   new PointF(ClientRectangle.Width / wightDeliter, ClientRectangle.Height - PenSize), 
                                new PointF(ClientRectangle.Width, PenSize));                
            }
             else
             {
                path.AddLine(new PointF(PenSize, ClientRectangle.Height - PenSize ),
                                new PointF(ClientRectangle.Width / wightDeliter - PenSize, PenSize)
                          );

                path.AddLine(new PointF(ClientRectangle.Width / wightDeliter - PenSize, PenSize),
                             new PointF(ClientRectangle.Width - PenSize, ClientRectangle.Height - PenSize)
                            );
            }

            var Pen = new Pen(PenColor, PenSize);
            e.Graphics.DrawPath(Pen, path);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(EnablePress)
                isPress = !isPress;
            Invalidate();
        }

        public bool isPress { get; set; }

    }
}
