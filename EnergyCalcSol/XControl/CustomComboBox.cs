using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace XCotrols
{
    public class CustomComboBox : ComboBox
    {
        public Color ForeColorFirstItem { get; set; }
        public bool DrawFocusRect { get; set; }
        public CustomComboBox() : base()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            
            DoubleBuffered = true;
            Font = new Font("Lato", 10);
            ForeColor = Color.Black;
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawVariable;


            ColorActiveItem = Color.CornflowerBlue;
            ColorDeactiveItem = Color.White;

            Leave += CustomComboBox_Leave;
            GotFocus += CustomComboBox_GotFocus;

            DrawFocusRect = true;
            ForeColorFirstItem = Color.DimGray;
        }

        private void CustomComboBox_GotFocus(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void CustomComboBox_Leave(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private Font FontSmall = new Font("Lato", 9f);

        //private TextFormatFlags _textFormatFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
       
            var g = e.Graphics;

            //control rectangle
            var ctrlRectangle = Enabled? ClientRectangle : e.ClipRectangle;
            
            //combobox button W;
            int buttonW = 15;
            int border = 8;

            //TEXT rectangle
            var textRectange = ctrlRectangle;
            textRectange.Width -= buttonW;
            textRectange.Width -= border;

            var rectBorder = textRectange;
            textRectange.Inflate(-1, -1);



            //BUTTON RECTANGLE
            var buttonRectangle =
                Rectangle.FromLTRB(textRectange.Right + border/2,
                                   textRectange.Top,
                                   ctrlRectangle.Right - border / 2,
                                   textRectange.Bottom);



            //DRAW BACKGROUND
            var bcgColor = Enabled ? BackColor : SystemColors.Control;
            
            using (var br = new SolidBrush(bcgColor))
                g.FillRectangle(br, ClientRectangle);


            if (Focused && DroppedDown == false)
            {
                rectBorder.Width -= 2;
                rectBorder.Height -= 2;
                
                var p = new Pen(Color.Gray);
                p.DashStyle = DashStyle.Dot;
                
                e.Graphics.DrawRectangle(p, rectBorder);
            }
            
            if (Enabled)
                g.SmoothingMode = SmoothingMode.AntiAlias;

            //add
            var sf = new StringFormat(StringFormatFlags.NoWrap);
            sf.LineAlignment = StringAlignment.Center;

            var textColor = SelectedIndex == 0 ? ForeColorFirstItem : ForeColor;
            var textFont  = SelectedIndex == 0 ? FontSmall : Font;
            using (var brush = new SolidBrush(textColor))
                e.Graphics.DrawString(Text, textFont, brush, textRectange, sf);
            

            DropDownWidth = GetDropDownWidth();
            
            //draw item arroy

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle buttonBounds = buttonRectangle;

            buttonBounds.Inflate(0, -7);

            int hItem = buttonBounds.Height / 4 * 3;
            int hAddP = 3;

            var p1 = new Point(buttonBounds.Left, buttonBounds.Top + hAddP);
            var p2 = new Point(buttonBounds.Left + buttonBounds.Width / 2, buttonBounds.Top + hItem + hAddP);
            var p3 = new Point(buttonBounds.Right, buttonBounds.Top + hAddP);

            float wPen = 1.5f;

            using (var pen = new Pen(Color.LightSlateGray, wPen))
            {
                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p2, p3);
            }
            
        }

        public int GetDropDownWidth()
        {
            int w = ClientRectangle.Width;
            foreach (var s in Items)
            {
                int curW = TextRenderer.MeasureText(GetItemText(s), Font).Width;
                if (curW > w)
                    w = curW;
            }

            return w;
        }

        public Color ColorActiveItem { get; set; }
        public Color ColorDeactiveItem { get; set; }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (!DroppedDown)
            {
                if(DrawFocusRect)
                    e.DrawFocusRectangle();
                return;
            }


            var g = e.Graphics;

            var ctrlRectangle = e.Bounds;

            //combobox button W;
            int buttonW = 0;
            int border = 0;

            //TEXT rectangle
            var textRectange = ctrlRectangle;
            textRectange.Width -= buttonW;
            textRectange.Width -= border;

            

            var textToPaint = "";

            using (var br = new SolidBrush(e.BackColor))
                g.FillRectangle(br, ctrlRectangle);


            var drawColor = ColorDeactiveItem;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected && e.Index > 0) 
                drawColor = ColorActiveItem;
        
            using (var br = new SolidBrush(drawColor))
                g.FillRectangle(br, textRectange);


            if (e.Index != -1 && Items.Count > 0)
            {
                textToPaint = GetItemText(Items[e.Index]);                
            }


            var colorText = e.Index == 0 ? ForeColorFirstItem : e.ForeColor;
            using (var br = new SolidBrush(colorText))
                e.Graphics.DrawString(textToPaint, e.Font, br, textRectange);

            if(DrawFocusRect)
                e.DrawFocusRectangle();
        }

    }
}