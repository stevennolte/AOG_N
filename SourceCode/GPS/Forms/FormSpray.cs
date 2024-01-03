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
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        int productEnable = 0;
        public FormSpray()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (productEnable == 0)
            {
                productEnable = 1;
            } else if (productEnable == 1)
            {
                productEnable = 0;
            }
        }
    }
}
