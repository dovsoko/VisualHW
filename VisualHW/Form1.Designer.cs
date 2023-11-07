namespace SortVisualization
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblPowerballNumbers;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCheck;

        private void InitializePowerballControls()
        {
            // Initialize lblPowerballNumbers
            this.lblPowerballNumbers = new System.Windows.Forms.Label();
            this.lblPowerballNumbers.AutoSize = true;
            this.lblPowerballNumbers.Location = new System.Drawing.Point(10, 10);
            this.lblPowerballNumbers.Text = "Main Numbers: -\nPowerball Number: -";
            this.Controls.Add(this.lblPowerballNumbers);

            // Initialize lblResult
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(10, 50);
            this.lblResult.Text = "";
            this.Controls.Add(this.lblResult);

            // Initialize textBoxUserInput
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.textBoxUserInput.Location = new System.Drawing.Point(10, 90);
            this.Controls.Add(this.textBoxUserInput);

            // Initialize btnGenerate
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerate.Location = new System.Drawing.Point(10, 130);
            this.btnGenerate.Text = "Generate";
            this.Controls.Add(this.btnGenerate);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click); // Event handler for the button

            // Initialize btnCheck
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCheck.Location = new System.Drawing.Point(10, 170);
            this.btnCheck.Text = "Check";
            this.Controls.Add(this.btnCheck);
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click); // Event handler for the button
        }

        // Rest of the designer-generated code

        private void InitializeComponent()
        {
            // Auto-generated code for other controls in your form

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 631);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.pnlCount);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Sort Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.ResumeLayout(false);
        }

        // In the constructor, call InitializePowerballControls to create the controls
        public Form1()
        {
            InitializeComponent();
            InitializePowerballControls();
        }
    }
}
