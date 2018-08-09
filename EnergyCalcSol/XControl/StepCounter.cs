using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace XCotrols
{ 
    public partial class StepCounter : UserControl
    {
        public int StepCount { get; set; }


        private int _StepCurrent;
        public int StepCurrent
        {
            get { return _StepCurrent; }
            set { _StepCurrent = value;


                richTextBox1.Clear();
                richTextBox1.SelectionFont = new Font("Lato", 19, FontStyle.Regular);

                pictureBox1.Visible = StepCurrent == 1 ? true : false;
                pictureBox2.Visible = StepCurrent == 2 ? true : false;
                pictureBox3.Visible = StepCurrent == 3 ? true : false;

                for (int i = 1; i <= StepCount; i++)
                {
                    if (i <= StepCurrent)
                        richTextBox1.SelectionColor = StepColorCurrent;
                    else
                        richTextBox1.SelectionColor = StepColorFuture;

                    richTextBox1.AppendText("0" + i.ToString());
                    
                    if (StepCount == StepCurrent && i == StepCount)
                        richTextBox1.AppendText(" РЕЗУЛЬТАТ");

                    if (i == 1 && StepCurrent == 1)
                    {
                        richTextBox1.SelectionColor = StepColorFuture;
                    }
                    else                    
                    if(i < StepCurrent)
                        richTextBox1.SelectionColor = StepColorCurrent;
                    else
                        richTextBox1.SelectionColor = StepColorFuture;

                    if (i != StepCount)
                        richTextBox1.AppendText(" - ");

                }
                
            }
        }

        public Color StepColorFuture { get; set; }
        public Color StepColorCurrent { get; set; }

        public StepCounter()
        {
            InitializeComponent();
                        
            StepColorCurrent = Color.FromArgb(8, 175, 230);
            StepColorFuture = Color.FromArgb(211, 215, 216);

            richTextBox1.BackColor = BackColor;
            DoubleBuffered = true;
            
            StepCount = 3;
            StepCurrent = 1;
         }
   
    }
}
