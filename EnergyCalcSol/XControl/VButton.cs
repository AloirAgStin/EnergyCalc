﻿using System;
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
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ButtonRenderer.DrawParentBackground(e.Graphics, ClientRectangle, this);
            
            GraphicsPath path = new GraphicsPath();
            if(!isPress)
            {
                path.AddLine(   new PointF(0, ClientRectangle.Top - 2), 
                                new PointF(ClientRectangle.Width /2 , ClientRectangle.Bottom - 2) 
                               );

                path.AddLine(   new PointF(ClientRectangle.Width / 2, ClientRectangle.Bottom - 2),
                                new PointF(ClientRectangle.Width, ClientRectangle.Top - 2));                
            }
             /*else
             {
                path.AddLine(new PointF(PenSize, ClientRectangle.Height - PenSize ),
                                new PointF(ClientRectangle.Width / wightDeliter - PenSize, PenSize)
                          );

                path.AddLine(new PointF(ClientRectangle.Width / 2 - PenSize, PenSize),
                             new PointF(ClientRectangle.Width - PenSize, ClientRectangle.Height - PenSize)
                            );
            }*/

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
