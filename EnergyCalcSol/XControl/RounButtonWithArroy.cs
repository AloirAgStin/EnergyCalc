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
        public float DrawArrowW { get; set; }
        public float DrawArrowXOffset { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!DrawArrow)
                return;

            var rect = ClientRectangle;
            rect.Inflate(-4, -4);   
            //var textPos = e.Graphics.MeasureString(Text, Font);
            
            using (var pen = new Pen(base.ForeColor, DrawArrowW))
            {
                //pen.StartCap = LineCap.Flat;
                //pen.EndCap = LineCap.ArrowAnchor;

                float yPos = rect.Height / 2 + 5;
                float part = rect.Width / 20;

                e.Graphics.DrawLine(pen, part * 18 - DrawArrowXOffset - part * 2, //начало стрелы 
                                         yPos,
                                         rect.Width - part * 2.5f + 1, //конец стрелы
                                         yPos);

                e.Graphics.DrawLine(pen, rect.Width - part * 2.5f, yPos,
                                         rect.Width - part * 2.5f - rect.Width / 30,
                                         yPos - rect.Height / 5
                                         );

                e.Graphics.DrawLine(pen, rect.Width - part * 2.5f, yPos,
                                         rect.Width - part  *2.5f - rect.Width / 30,
                                         yPos + rect.Height / 5
                                         );
            }
        }


        
    }



}
