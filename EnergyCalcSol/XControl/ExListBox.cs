using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace XControl
{
    public class ExListBox : ListBox
    {
        public Color SelectedTextColor { get; set; }

        public ExListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            SelectedTextColor = Color.FromArgb(0,178, 236);

            BorderStyle = BorderStyle.None;

            Font = new Font("Lato", 14.25f, FontStyle.Bold);

            DrawItem += ExListBox_DrawItem;
        }
        

        private void ExListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (Items.Count > 0 && e.Index != -1)
            {
                var rect = e.Bounds;
                rect.Inflate(-10, 0);
                Brush myBrush = new SolidBrush(ForeColor);

                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                if(selected)
                    myBrush = new SolidBrush(SelectedTextColor);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, myBrush, rect, StringFormat.GenericDefault);

            }
            e.DrawFocusRectangle();
        }
    }
}
