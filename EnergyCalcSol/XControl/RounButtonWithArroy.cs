using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;  
using System.Windows.Forms;

namespace XControl
{
    public class RounButtonWithArroy : RoundButton
    {
        public RounButtonWithArroy()
        {
            Size = new Size(250, 60);
            DrawArrow = true;
        }

        public bool DrawArrow { get; set; }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!DrawArrow)
                return;

            var rect = ClientRectangle;
            rect.Inflate(-4, -4);
            var textPos = e.Graphics.MeasureString(Text, Font);

            float arroyW = 2;
            using (var pen = new Pen(base.ForeColor, arroyW))
            {
                //pen.StartCap = LineCap.Flat;
                //pen.EndCap = LineCap.ArrowAnchor;

                float yPos = rect.Height / 2 + 5;

                e.Graphics.DrawLine(pen, rect.Width / 20 * 18 , //начало стрелы 
                                         yPos,
                                         rect.Width - arroyW, //конец стрелы
                                         yPos);

                e.Graphics.DrawLine(pen, rect.Width - arroyW, yPos,
                                         rect.Width - arroyW - rect.Width / 20,
                                         yPos - rect.Height / 4
                                         );

                e.Graphics.DrawLine(pen, rect.Width - arroyW, yPos,
                                         rect.Width - arroyW - rect.Width / 20,
                                         yPos + rect.Height / 4
                                         );
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }



}
