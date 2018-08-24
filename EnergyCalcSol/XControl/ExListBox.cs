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
                if (selected)
                    myBrush = new SolidBrush(SelectedTextColor);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                var drawtext = Items[e.Index].ToString();
                var extText = "";
                int pos = drawtext.LastIndexOf("(");
                if (pos != -1)
                {
                    extText = drawtext.Substring(pos);
                    drawtext = drawtext.Substring(0, pos);
                }

                e.Graphics.DrawString(drawtext, e.Font, myBrush, rect, StringFormat.GenericDefault);
                var len = e.Graphics.MeasureString(drawtext, e.Font);
                rect.X += (int)len.Width - 8;
                rect.Y += 5;

                if (extText.Length != 0)
                {
                    var f = new Font(e.Font.Name, e.Font.Size - 4);
                    e.Graphics.DrawString(extText, f, myBrush, rect, StringFormat.GenericDefault);
                }
            }
            e.DrawFocusRectangle();
        }
    }
}
