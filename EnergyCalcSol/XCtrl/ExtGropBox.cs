using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace XCtrl
{
    [Designer(typeof(XCtrl.UserControlDesigner))]
    public partial class ExtGropBox: UserControl
    {
        public ExtGropBox()
        {
            InitializeComponent();
            BorderColor = Color.FromArgb(126,175, 45);
            LineW = 4;
        }

        public Color BorderColor { get; set; }
        public int LineW { get; set; }
        

        private void ExtGropBox_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(BorderColor, LineW);
            pen.LineJoin = LineJoin.Miter;//задаем скошенные углы
            pen.MiterLimit = 1;           //задаем ограничение толщины скошенных углов
            e.Graphics.DrawRectangle(pen, new Rectangle(20, 3, Width - 3 - LineW - 20, Height - 3 - LineW));

            var img = Image.FromHbitmap(Properties.Resources.arrow.GetHbitmap());
            img.MakeTransparent();
            e.Graphics.DrawImage(img, LineW-2, 10);
        }
        
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel DropZone
        {
            get {
                panel1.Dock = DockStyle.Fill;
                    return panel1; }
        }
    }

    public class UserControlDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            if (this.Control is ExtGropBox)
            {
                this.EnableDesignMode(
                                     ((ExtGropBox)this.Control).DropZone, "DropZone");
            }
        }
    }
}
