namespace ColorThemePreviewer
{
    partial class ColorThemePreviewer
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
            this.ColorThemeGradientOutput = new System.Windows.Forms.PictureBox();
            this.RedValueLabel = new System.Windows.Forms.Label();
            this.RedValueBox = new System.Windows.Forms.TextBox();
            this.GreenValueBox = new System.Windows.Forms.TextBox();
            this.GreenValueLabel = new System.Windows.Forms.Label();
            this.BlueValueBox = new System.Windows.Forms.TextBox();
            this.BlueValueLabel = new System.Windows.Forms.Label();
            this.Okbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsageLabel = new System.Windows.Forms.Label();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleExplanationLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorThemeGradientOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorThemeGradientOutput
            // 
            this.ColorThemeGradientOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorThemeGradientOutput.Location = new System.Drawing.Point(88, 40);
            this.ColorThemeGradientOutput.Name = "ColorThemeGradientOutput";
            this.ColorThemeGradientOutput.Size = new System.Drawing.Size(510, 100);
            this.ColorThemeGradientOutput.TabIndex = 0;
            this.ColorThemeGradientOutput.TabStop = false;
            this.ColorThemeGradientOutput.Click += new System.EventHandler(this.ColorThemeGradientOutput_Click);
            // 
            // RedValueLabel
            // 
            this.RedValueLabel.AutoSize = true;
            this.RedValueLabel.Location = new System.Drawing.Point(3, 42);
            this.RedValueLabel.Name = "RedValueLabel";
            this.RedValueLabel.Size = new System.Drawing.Size(30, 13);
            this.RedValueLabel.TabIndex = 1;
            this.RedValueLabel.Text = "Red:";
            this.RedValueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RedValueBox
            // 
            this.RedValueBox.Location = new System.Drawing.Point(36, 39);
            this.RedValueBox.MaxLength = 3;
            this.RedValueBox.Name = "RedValueBox";
            this.RedValueBox.Size = new System.Drawing.Size(30, 20);
            this.RedValueBox.TabIndex = 2;
            this.RedValueBox.TextChanged += new System.EventHandler(this.RedValueBox_TextChanged);
            // 
            // GreenValueBox
            // 
            this.GreenValueBox.Location = new System.Drawing.Point(113, 39);
            this.GreenValueBox.MaxLength = 3;
            this.GreenValueBox.Name = "GreenValueBox";
            this.GreenValueBox.Size = new System.Drawing.Size(30, 20);
            this.GreenValueBox.TabIndex = 4;
            this.GreenValueBox.TextChanged += new System.EventHandler(this.GreenValueBox_TextChanged);
            // 
            // GreenValueLabel
            // 
            this.GreenValueLabel.AutoSize = true;
            this.GreenValueLabel.Location = new System.Drawing.Point(72, 42);
            this.GreenValueLabel.Name = "GreenValueLabel";
            this.GreenValueLabel.Size = new System.Drawing.Size(39, 13);
            this.GreenValueLabel.TabIndex = 3;
            this.GreenValueLabel.Text = "Green:";
            // 
            // BlueValueBox
            // 
            this.BlueValueBox.Location = new System.Drawing.Point(183, 39);
            this.BlueValueBox.MaxLength = 3;
            this.BlueValueBox.Name = "BlueValueBox";
            this.BlueValueBox.Size = new System.Drawing.Size(30, 20);
            this.BlueValueBox.TabIndex = 6;
            this.BlueValueBox.TextChanged += new System.EventHandler(this.BlueValueBox_TextChanged);
            // 
            // BlueValueLabel
            // 
            this.BlueValueLabel.AutoSize = true;
            this.BlueValueLabel.Location = new System.Drawing.Point(149, 42);
            this.BlueValueLabel.Name = "BlueValueLabel";
            this.BlueValueLabel.Size = new System.Drawing.Size(31, 13);
            this.BlueValueLabel.TabIndex = 5;
            this.BlueValueLabel.Text = "Blue:";
            // 
            // Okbutton
            // 
            this.Okbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Okbutton.Location = new System.Drawing.Point(240, 33);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 30);
            this.Okbutton.TabIndex = 7;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RedValueLabel);
            this.panel1.Controls.Add(this.Okbutton);
            this.panel1.Controls.Add(this.RedValueBox);
            this.panel1.Controls.Add(this.BlueValueBox);
            this.panel1.Controls.Add(this.GreenValueLabel);
            this.panel1.Controls.Add(this.BlueValueLabel);
            this.panel1.Controls.Add(this.GreenValueBox);
            this.panel1.Location = new System.Drawing.Point(70, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 100);
            this.panel1.TabIndex = 8;
            // 
            // UsageLabel
            // 
            this.UsageLabel.AutoSize = true;
            this.UsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsageLabel.Location = new System.Drawing.Point(67, 265);
            this.UsageLabel.Name = "UsageLabel";
            this.UsageLabel.Size = new System.Drawing.Size(53, 17);
            this.UsageLabel.TabIndex = 9;
            this.UsageLabel.Text = "Usage:";
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ExplanationLabel.Location = new System.Drawing.Point(79, 282);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(456, 15);
            this.ExplanationLabel.TabIndex = 10;
            this.ExplanationLabel.Text = "Enter a value to fix the corresponding R/G/B. Leave blank for it to be cycled thr" +
    "ough.";
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(67, 307);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(174, 13);
            this.ExampleLabel.TabIndex = 11;
            this.ExampleLabel.Text = "Example: R: 200 G: (blank) : B: 100";
            // 
            // ExampleExplanationLable
            // 
            this.ExampleExplanationLable.AutoSize = true;
            this.ExampleExplanationLable.Location = new System.Drawing.Point(85, 320);
            this.ExampleExplanationLable.Name = "ExampleExplanationLable";
            this.ExampleExplanationLable.Size = new System.Drawing.Size(380, 13);
            this.ExampleExplanationLable.TabIndex = 12;
            this.ExampleExplanationLable.Text = "The program will fix R and B values while incrementing G values starting from 5.";
            // 
            // ColorThemePreviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.ExampleExplanationLable);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.UsageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorThemeGradientOutput);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ColorThemePreviewer";
            this.Text = "ColorThemePreviewer";
            ((System.ComponentModel.ISupportInitialize)(this.ColorThemeGradientOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorThemeGradientOutput;
        private System.Windows.Forms.Label RedValueLabel;
        private System.Windows.Forms.TextBox RedValueBox;
        private System.Windows.Forms.TextBox GreenValueBox;
        private System.Windows.Forms.Label GreenValueLabel;
        private System.Windows.Forms.TextBox BlueValueBox;
        private System.Windows.Forms.Label BlueValueLabel;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UsageLabel;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleExplanationLable;
    }
}

