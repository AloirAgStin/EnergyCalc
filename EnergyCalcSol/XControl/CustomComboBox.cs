﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace XCotrols
{
    public class CustomComboBox : ComboBox
    {
        public CustomComboBox() : base()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            Font = new Font("Lato", 10);
            ForeColor = Color.Black;
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawVariable;


            ColorActiveItem = Color.CornflowerBlue;
            ColorDeactiveItem = Color.White;
        }

        private Font FontSmall = new Font("Lato", 9.25f, FontStyle.Bold);

        private TextFormatFlags _textFormatFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
       
            var g = e.Graphics;
            
            if(Enabled)
                g.SmoothingMode = SmoothingMode.AntiAlias;

            //control rectangle
            var ctrlRectangle = Enabled? ClientRectangle : e.ClipRectangle;

            //combobox button W;
            int buttonW = 15;
            int border = 8;

            //TEXT rectangle
            var textRectange = ctrlRectangle;
            textRectange.Width -= buttonW;
            textRectange.Width -= border;


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
           
            
            if (SelectedIndex == 0)
            {               
                TextRenderer.DrawText(g, Text, FontSmall, textRectange, Color.Gray, _textFormatFlags);
            }
            else
            {
                TextRenderer.DrawText(g, Text, Font, textRectange, ForeColor, _textFormatFlags);
            }
            
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

            int wPen = 2;

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
            base.OnDrawItem(e);


            if (!DroppedDown )
            {
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
            {
                drawColor = ColorActiveItem;
            }

            using (var br = new SolidBrush(drawColor))
                g.FillRectangle(br, textRectange);


            if (e.Index != -1 && Items.Count > 0)
            {
                textToPaint = GetItemText(Items[e.Index]);                
            }
            
            if(e.Index == 0)
            {
                using (var br = new SolidBrush(Color.Black))
                    e.Graphics.DrawString(textToPaint, e.Font, br, textRectange);
            }
            else
            {
                using (var br = new SolidBrush(e.ForeColor))
                    e.Graphics.DrawString(textToPaint, e.Font, br, textRectange);
            }           

            e.DrawFocusRectangle();
        }

    }
}