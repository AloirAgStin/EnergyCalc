using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCtrl
{
    public struct sExtDataSource
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
    public partial class ExtComboBox : ComboBox
    {
        public ExtComboBox()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.DropDown += ExtComboBox_DropDown;
        }

        public void SetDataSource(IEnumerable<sExtDataSource> data)
        {
            DisplayMember = "Name";
            ValueMember = "Code";
            DataSource = data;
        }
        private void ExtComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (object item in ((ComboBox)sender).Items)
            {
                string s = "";
                if (item is sExtDataSource)
                {
                    s = ((sExtDataSource)(item)).Name;
                }
                else
                if( item is sGroupComboBoxItem)
                {
                    s = ((sGroupComboBoxItem)item).DisplayName;
                }
                else
                if( item is string)
                    s = (string)item;
                     

                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }
    }
}
