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
            this.components = new System.ComponentModel.Container();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors4 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors5 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors6 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.sprayEnableButton = new CodeArtEng.Gauge.InputGauge.BitButton();
            this.autoBoomEnableButton = new CodeArtEng.Gauge.InputGauge.BitButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.rateTargetDIS = new CodeArtEng.Gauge.InputGauge.NumericInput();
            this.circularGauge1 = new CodeArtEng.Gauge.CircularGauge();
            this.SuspendLayout();
            // 
            // sprayEnableButton
            // 
            this.sprayEnableButton.Image = null;
            this.sprayEnableButton.Location = new System.Drawing.Point(42, 44);
            this.sprayEnableButton.Maximum = 2147483647D;
            this.sprayEnableButton.Name = "sprayEnableButton";
            this.sprayEnableButton.ResetValue = 0D;
            this.sprayEnableButton.ScaleFactor = 1D;
            this.sprayEnableButton.Size = new System.Drawing.Size(80, 80);
            this.sprayEnableButton.TabIndex = 0;
            this.sprayEnableButton.Title = "Sprayer Enable";
            this.sprayEnableButton.Unit = "";
            this.sprayEnableButton.UserDefinedColors.Base = themeColors4;
            this.sprayEnableButton.UserDefinedColors.Error = themeColors5;
            this.sprayEnableButton.UserDefinedColors.Warning = themeColors6;
            this.sprayEnableButton.Load += new System.EventHandler(this.sprayEnableButton_Load);
            // 
            // autoBoomEnableButton
            // 
            this.autoBoomEnableButton.Image = null;
            this.autoBoomEnableButton.Location = new System.Drawing.Point(42, 148);
            this.autoBoomEnableButton.Maximum = 2147483647D;
            this.autoBoomEnableButton.Name = "autoBoomEnableButton";
            this.autoBoomEnableButton.ResetValue = 0D;
            this.autoBoomEnableButton.ScaleFactor = 1D;
            this.autoBoomEnableButton.Size = new System.Drawing.Size(80, 80);
            this.autoBoomEnableButton.TabIndex = 1;
            this.autoBoomEnableButton.Title = "Auto Boom";
            this.autoBoomEnableButton.Unit = "";
            this.autoBoomEnableButton.Load += new System.EventHandler(this.autoBoomEnableButton_Load);
            this.autoBoomEnableButton.Click += new System.EventHandler(this.autoBoomEnableButton_Click_1);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.materialRaisedButton2.Location = new System.Drawing.Point(142, 100);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(205, 35);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "materialRaisedButton2";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(166, 44);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(150, 30);
            this.materialCheckBox1.TabIndex = 4;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // rateTargetDIS
            // 
            this.rateTargetDIS.InputDelta = 0.5D;
            this.rateTargetDIS.InputDeltaFine = 0.5D;
            this.rateTargetDIS.KnobPanelOffset = 4;
            this.rateTargetDIS.Location = new System.Drawing.Point(573, 259);
            this.rateTargetDIS.Name = "rateTargetDIS";
            this.rateTargetDIS.ResetValue = 0D;
            this.rateTargetDIS.ScaleFactor = 1D;
            this.rateTargetDIS.Size = new System.Drawing.Size(100, 100);
            this.rateTargetDIS.TabIndex = 1;
            this.rateTargetDIS.Theme = CodeArtEng.Gauge.GaugeTheme.DarkBlue;
            this.rateTargetDIS.Title = "";
            this.rateTargetDIS.Unit = "gal/ac";
            this.rateTargetDIS.Value = 15D;
            this.rateTargetDIS.Load += new System.EventHandler(this.numericInput1_Load);
            // 
            // circularGauge1
            // 
            this.circularGauge1.Location = new System.Drawing.Point(295, 259);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.ResetValue = 0D;
            this.circularGauge1.ScaleFactor = 1D;
            this.circularGauge1.Size = new System.Drawing.Size(65, 65);
            this.circularGauge1.TabIndex = 5;
            this.circularGauge1.Title = "";
            this.circularGauge1.Unit = "km/h";
            // 
            // FormSpray
            // 
            this.ClientSize = new System.Drawing.Size(713, 371);
            this.Controls.Add(this.circularGauge1);
            this.Controls.Add(this.rateTargetDIS);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.autoBoomEnableButton);
            this.Controls.Add(this.sprayEnableButton);
            this.Name = "FormSpray";
            this.Load += new System.EventHandler(this.FormSpray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private CodeArtEng.Gauge.InputGauge.BitButton bitButton1;
        private CodeArtEng.Gauge.InputGauge.BitButton bitButton2;
        public CodeArtEng.Gauge.PanelGauges.PanelGaugeCircularIndicator panelGaugeCircularIndicator1;
        private CodeArtEng.Gauge.InputGauge.BitButton sprayEnableButton;
        private CodeArtEng.Gauge.InputGauge.BitButton autoBoomEnableButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private CodeArtEng.Gauge.InputGauge.NumericInput rateTargetDIS;
        private CodeArtEng.Gauge.CircularGauge circularGauge1;

    }
}