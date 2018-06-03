using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XControl
{
    public class SelectableLabel : Control
    {
        public SelectableLabel() : base()
        {
            SetStyle(ControlStyles.Selectable, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, BackColor);          
        }
    }
}
