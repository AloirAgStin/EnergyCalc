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
            KeyDown += SelectableLabel_KeyDown; ;
        }

        private void SelectableLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
                base.OnClick(new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Focused)
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Dashed);
            }
            else
            {
                Color cl = SystemColors.Control;
                if (Parent != null)
                    cl = Parent.BackColor;

                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, cl, ButtonBorderStyle.Solid);
            }
            var rect = ClientRectangle;
            rect.Inflate(-3, -3);
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, BackColor);          
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Focus();
            Invalidate();
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Invalidate();
        }
    }
}
