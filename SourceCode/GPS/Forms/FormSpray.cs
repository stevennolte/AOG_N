using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    
    public partial class FormSpray : Form
    {
        private readonly FormGPS mf = null;
        Timer t = new Timer();
        public int productEnable = 0;
        
        public FormSpray(Form callingForm)
        {
            mf = callingForm as FormGPS;
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
            mf.tool.targetRate = (int)(numericUpDown1.Value*10);

            byte cnt = 0;
            for (int i = 0; i < 64; i++)
            {
                if (mf.section[i].isSectionOn)
                {
                   cnt++;
                }
            }
            mf.tool.rowsActive = cnt;
            
        }                

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (productEnable == 0)
            {
                productEnable = 1;
                mf.tool.productEnable = 1;
            } else if (productEnable == 1)
            {
                productEnable = 0;
                mf.tool.productEnable = 0;
            }
        }

        
    }
}
