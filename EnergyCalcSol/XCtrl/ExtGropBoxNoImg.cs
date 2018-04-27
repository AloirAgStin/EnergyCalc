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

namespace XCtrl
{
    public partial class ExtGropBoxNoImg : UserControl
    {
        public int ArrowType { get; set; }
        public Color BorderColor { get; set; }
        public int LineW { get; set; }
        public ExtGropBoxNoImg()
        {
            InitializeComponent();
            BorderColor = Color.FromArgb(126, 175, 45);
            LineW = 4;
            ArrowType = 0;
        }

        private void ExtGropBoxNoImg_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(BorderColor, LineW);
            pen.LineJoin = LineJoin.Miter;//задаем скошенные углы
            pen.MiterLimit = 1;           //задаем ограничение толщины скошенных углов
            e.Graphics.DrawRectangle(pen, new Rectangle(LineW, LineW, Width - LineW, Height - LineW));
        }
    }
}
