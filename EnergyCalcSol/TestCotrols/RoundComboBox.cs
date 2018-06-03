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

namespace XControl
{
    public partial class RoundComboBox : RoundEdit
    {
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design",
     "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return comboBox1.Items;
            }
            set
            {
                    comboBox1.Items.Add(value);
            }
        }

        public string DefaultText { get; set; }
        public ComboBoxStyle StyleCombo
        {
            get
            {
                return comboBox1.DropDownStyle;
            }
            set { comboBox1.DropDownStyle = value; }
        }

        public Font FontCombo
        {
            get => comboBox1.Font;
            set => comboBox1.Font = value;
        }

        public RoundComboBox()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //label3.Text = DefaultText;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                comboBox1.Text = DefaultText;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHideLable();
        }

        private void ShowHideLable()
        {
            /*
            label3.Text = DefaultText;
            if (comboBox1.SelectedIndex == -1)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }

            label3.Invalidate();*/
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
            ShowHideLable();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = comboBox1.Font;
            Brush backgroundColor;
            Brush textColor;



            ComboBox senderComboBox = comboBox1;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;



            if (comboBox1.Items.Contains(e.Index))
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    backgroundColor = Brushes.Cyan;
                    textColor = Brushes.Black;
                }
                else
                {
                    backgroundColor = Brushes.Brown;
                    textColor = Brushes.Black;
                }
            }
            else
            {
                backgroundColor = new SolidBrush(comboBox1.BackColor);
                textColor = new SolidBrush(comboBox1.ForeColor);

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    if(e.Index < 1 )
                    {
                        backgroundColor = new SolidBrush(comboBox1.BackColor);
                        textColor = new SolidBrush(comboBox1.ForeColor);
                    }
                    else
                    {
                        backgroundColor = new SolidBrush(Color.SandyBrown);
                        textColor = new SolidBrush(comboBox1.ForeColor);
                        
                    }

                }
                else
                {
                    backgroundColor = new SolidBrush(comboBox1.BackColor);
                    textColor = new SolidBrush(comboBox1.ForeColor);

                }
            }
            e.Graphics.FillRectangle(backgroundColor, e.Bounds);
            if (e.Index == -1) return;

            e.Graphics.DrawString((sender as ComboBox).
            Items[e.Index].ToString(), font, textColor, e.Bounds);
        }
    }
}
