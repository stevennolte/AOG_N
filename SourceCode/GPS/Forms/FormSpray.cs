using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgOpenGPS.Forms
{
    
    public partial class FormSpray : Form
    {
<<<<<<< HEAD
        private readonly FormGPS mf = null;
        Timer t = new Timer();
        public int productEnable = 0;
        public FormSpray(Form callingForm)
=======
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int productEnable = 0;
        public FormSpray()
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
<<<<<<< HEAD
            t.Interval = 100;
            t.Enabled = true;

            t.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (productEnable == 1)
           {
               button1.BackColor = Color.Blue;
            } else if (productEnable == 0)
           {
                button1.BackColor = Color.Gray;
            }
            mf.tool.targetRate = (int)(numericUpDown1.Value*10);
        }                

=======
            myTimer.Interval = 100;
            myTimer.Enabled = true;
            myTimer.Tick += new EventHandler(myTimer_tick);
        }

        private void myTimer_tick(object sender, EventArgs e)
        {
            if (productEnable == 0)
            {
                button1.BackColor = Color.Gray;
            } else if (productEnable == 1)
            {
                button1.BackColor = Color.Blue;
            }
        }
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

<<<<<<< HEAD
        public void button1_Click(object sender, EventArgs e)
=======
        private void materialRaisedButton1_Click(object sender, EventArgs e)
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
        {
            if (productEnable == 0)
            {
                productEnable = 1;
<<<<<<< HEAD
                mf.tool.productEnable = 1;
            } else if (productEnable == 1)
            {
                productEnable = 0;
                mf.tool.productEnable = 0;
            }
        }

        
=======
            } else if (productEnable == 1)
            {
                productEnable = 0;
            }
        }
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
    }
}
