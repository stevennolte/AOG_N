using AgOpenGPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgOpenGPS.Forms
{
    public partial class FormSpray : Form
    {
        Timer timer = new Timer();
        private readonly FormGPS mf = null;
        private bool sprayEnabled = false;
        private bool fold = false;
        public FormSpray(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 250;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1Tick);
            materialRaisedButton2.KeyDown += materialRaisedButton1_KeyDown1;
            materialRaisedButton2.KeyUp += materialRaisedButton1_KeyUp1;
        }

        

        private void FormSpray_Load(object sender, EventArgs e)
        {

        }

        private void timer1Tick(object sender, EventArgs e)
        {
            Debug.Write(materialCheckBox1.CheckState);
            Debug.Write(" ");
            Debug.Write(fold);
            Debug.Write(" ");
            Debug.WriteLine(rateTargetDIS.Value);
            
            if (materialCheckBox1.Checked == false)
            {
                mf.tool.toolEnable = 0;
            }
            else if (materialCheckBox1.Checked == true)
            {
                mf.tool.toolEnable = 1;
            }
            mf.tool.targetRate = rateTargetDIS.Value;
            circularGauge1.Value = mf.tool.section1FlowRate;
        }

        private void sprayEnableButton_Load(object sender, EventArgs e)
        {
            if (mf.tool.toolEnable == 0)
            {
               mf.tool.toolEnable = 1; 
            }
            else
            {
               mf.tool.toolEnable = 0;
            }
            

        }

        private void autoBoomEnableButton_Click_1(object sender, EventArgs e)
        {
            if (sprayEnabled == false) { sprayEnabled = true; }
            else if (sprayEnabled == true) { sprayEnabled = false; }
            Debug.WriteLine(sprayEnabled);
        }

        private void autoBoomEnableButton_Load(object sender, EventArgs e)
        {
            if (sprayEnabled == false) { sprayEnabled = true; }
            else if (sprayEnabled == true) { sprayEnabled = false; }
            Debug.WriteLine(sprayEnabled);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_KeyDown1(object sender, KeyEventArgs e)
        {
            fold = true;
            Debug.WriteLine("keydown");
        }
        private void materialRaisedButton1_KeyUp1(object sender, KeyEventArgs e)
        {
            fold = false;
        }
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            
            if (sprayEnabled == false) 
            {
                sprayEnabled = true;
                
            } 
            else if (sprayEnabled == true) 
            {
                sprayEnabled = false;
                
            }
            
        }
        

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void numericInput1_Load(object sender, EventArgs e)
        {
            mf.tool.targetRate = rateTargetDIS.Value;
        }
    }
}
