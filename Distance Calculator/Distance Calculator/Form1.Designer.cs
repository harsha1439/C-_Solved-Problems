namespace Distance_Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedInputLabel = new System.Windows.Forms.TextBox();
            this.HoursInputLabel = new System.Windows.Forms.TextBox();
            this.OutputListbox = new System.Windows.Forms.ListBox();
            this.DistOutput = new System.Windows.Forms.Button();
            this.totalExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in MPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Travelled:";
            // 
            // SpeedInputLabel
            // 
            this.SpeedInputLabel.Location = new System.Drawing.Point(305, 47);
            this.SpeedInputLabel.Name = "SpeedInputLabel";
            this.SpeedInputLabel.Size = new System.Drawing.Size(100, 20);
            this.SpeedInputLabel.TabIndex = 2;
            // 
            // HoursInputLabel
            // 
            this.HoursInputLabel.Location = new System.Drawing.Point(305, 94);
            this.HoursInputLabel.Name = "HoursInputLabel";
            this.HoursInputLabel.Size = new System.Drawing.Size(100, 20);
            this.HoursInputLabel.TabIndex = 3;
            // 
            // OutputListbox
            // 
            this.OutputListbox.FormattingEnabled = true;
            this.OutputListbox.Location = new System.Drawing.Point(163, 145);
            this.OutputListbox.Name = "OutputListbox";
            this.OutputListbox.Size = new System.Drawing.Size(242, 95);
            this.OutputListbox.TabIndex = 4;
            // 
            // DistOutput
            // 
            this.DistOutput.Location = new System.Drawing.Point(163, 273);
            this.DistOutput.Name = "DistOutput";
            this.DistOutput.Size = new System.Drawing.Size(75, 23);
            this.DistOutput.TabIndex = 5;
            this.DistOutput.Text = "Calculate";
            this.DistOutput.UseVisualStyleBackColor = true;
            this.DistOutput.Click += new System.EventHandler(this.DistOutput_Click);
            // 
            // totalExit
            // 
            this.totalExit.Location = new System.Drawing.Point(330, 273);
            this.totalExit.Name = "totalExit";
            this.totalExit.Size = new System.Drawing.Size(75, 23);
            this.totalExit.TabIndex = 6;
            this.totalExit.Text = "Exit";
            this.totalExit.UseVisualStyleBackColor = true;
            this.totalExit.Click += new System.EventHandler(this.TotalExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalExit);
            this.Controls.Add(this.DistOutput);
            this.Controls.Add(this.OutputListbox);
            this.Controls.Add(this.HoursInputLabel);
            this.Controls.Add(this.SpeedInputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeedInputLabel;
        private System.Windows.Forms.TextBox HoursInputLabel;
        private System.Windows.Forms.ListBox OutputListbox;
        private System.Windows.Forms.Button DistOutput;
        private System.Windows.Forms.Button totalExit;
    }
}

