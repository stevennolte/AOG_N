namespace AgOpenGPS.Forms
{
    partial class FormSpray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
=======
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 50;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(323, 251);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(0);
            this.aGauge1.MaxValue = 120F;
            this.aGauge1.MinValue = -10F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 45;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 1;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 45;
            this.aGauge1.ScaleLinesInterOuterRadius = 50;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 40;
            this.aGauge1.ScaleLinesMajorOuterRadius = 50;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 45;
            this.aGauge1.ScaleLinesMinorOuterRadius = 50;
            this.aGauge1.ScaleLinesMinorTicks = 3;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 60;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(191, 161);
            this.aGauge1.TabIndex = 2;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(41, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Product Enable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(41, 144);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
=======
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(39, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Product Enable";
            this.button1.UseVisualStyleBackColor = false;
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
            // 
            // FormSpray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(876, 450);
<<<<<<< HEAD
            this.Controls.Add(this.numericUpDown1);
=======
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FormSpray";
            this.Text = "Form1";
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
=======
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.NumericUpDown numericUpDown1;
=======
>>>>>>> c4e356ae9af2b1b687bb91c2190890f584466f7c
    }
}