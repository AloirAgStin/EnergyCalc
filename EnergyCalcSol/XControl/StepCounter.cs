using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace XCotrols
{ 
/*
рисование галочки
 ButtonRenderer.DrawParentBackground(e.Graphics, ClientRectangle, this);

            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(0, 0), new Point(10, 10));
            path.AddLine(new Point(10, 10), new Point(20, 0));


            var color = Color.FromArgb(8, 175, 230);
            var Pen = new Pen(color, 5);

            e.Graphics.DrawPath(Pen, path);
*/
 

    public partial class StepCounter : UserControl
    {        
        public int StepCount { get; set; }


        private int _StepCurrent;
        public int StepCurrent
        {
            get { return _StepCurrent; }
            set { _StepCurrent = value; Invalidate(); }
        }

        public Color StepColorFuture { get; set; }
        public Color StepColorCurrent { get; set; }

        public StepCounter()
        {
            InitializeComponent();
            StepCount = 1;
            StepCurrent = 2;

            StepColorCurrent = Color.FromArgb(8, 175, 230);
            StepColorFuture = Color.FromArgb(211, 215, 216);
            
            Font = new Font("Lato", 40);

            DoubleBuffered = true;
        }

        private void StepCounter_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            SolidBrush drawBrushCurr = new SolidBrush(StepColorCurrent);
            SolidBrush drawBrushFuture = new SolidBrush(StepColorFuture);

            PointF drawPoint = new PointF(0.0f, 0.0f);

            StringBuilder drawText = new StringBuilder();

            for (int i = 1; i <= StepCurrent; i++)
            {
                drawText.AppendFormat("0{0}", i);
                if (i != StepCurrent)
                    drawText.AppendFormat(" - ");
            }
            e.Graphics.DrawString(drawText.ToString(), Font, drawBrushCurr, drawPoint);
            var sizeAdd = e.Graphics.MeasureString(drawText.ToString(), Font);

            drawText.Clear();
            for (int i = StepCurrent + 1; i <= StepCount; i++)
            {
                if (i - 1 == StepCurrent)
                    drawText.AppendFormat("- ");
                else
                if (i <= StepCount)
                    drawText.AppendFormat(" - ");

                drawText.AppendFormat("0{0}", i);
            }

            drawPoint.X += +sizeAdd.Width;

            e.Graphics.DrawString(drawText.ToString(), Font, drawBrushFuture, drawPoint);


            sizeAdd = e.Graphics.MeasureString(drawText.ToString(), Font);
            drawPoint.X += +sizeAdd.Width;
            if(StepCurrent == StepCount)
                e.Graphics.DrawString("РЕЗУЛЬТАТ", Font, drawBrushCurr, drawPoint);
            
            //рисуем круги
            var TextPart = e.Graphics.MeasureString("0", Font);
            float sz = Font.Size / 4;
            drawPoint = new PointF(0.0f, TextPart.Height - TextPart.Width * 0.2f);


            for (int i = 1; i <= _StepCurrent; i++)
            {
                if (i == 1)
                    drawPoint.X += TextPart.Width / 2 + TextPart.Width * 0.2f;
                else
                    drawPoint.X += TextPart.Width * 2 + TextPart.Width * 0.2f;

                // Draw ellipse to screen.        
                e.Graphics.FillEllipse(drawBrushCurr, drawPoint.X, drawPoint.Y, sz, sz);
            }

            drawPoint.X += TextPart.Width * 2 + TextPart.Width * 0.2f;

            for (int i = _StepCurrent + 1; i <= StepCount; i++)
            {
                if (i - 1 == _StepCurrent)
                    drawPoint.X += TextPart.Width * 0.1f;
                else
                    drawPoint.X += TextPart.Width * 2 + TextPart.Width * 0.2f;

                // Draw ellipse to screen.        
                e.Graphics.FillEllipse(drawBrushFuture, drawPoint.X, drawPoint.Y, sz, sz);
            }

            
        }
    }
}
