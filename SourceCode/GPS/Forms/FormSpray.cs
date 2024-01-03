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
        Timer t = new Timer();
        int productEnable = 0;
        public FormSpray()
        {
            InitializeComponent();
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
        }                

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
