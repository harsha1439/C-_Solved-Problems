namespace Distance_File
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
            this.DistOutput = new System.Windows.Forms.Button();
            this.TotExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in MPH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Travelled";
            // 
            // SpeedInputLabel
            // 
            this.SpeedInputLabel.Location = new System.Drawing.Point(343, 50);
            this.SpeedInputLabel.Name = "SpeedInputLabel";
            this.SpeedInputLabel.Size = new System.Drawing.Size(100, 20);
            this.SpeedInputLabel.TabIndex = 2;
            // 
            // HoursInputLabel
            // 
            this.HoursInputLabel.Location = new System.Drawing.Point(343, 94);
            this.HoursInputLabel.Name = "HoursInputLabel";
            this.HoursInputLabel.Size = new System.Drawing.Size(100, 20);
            this.HoursInputLabel.TabIndex = 3;
            // 
            // DistOutput
            // 
            this.DistOutput.Location = new System.Drawing.Point(203, 184);
            this.DistOutput.Name = "DistOutput";
            this.DistOutput.Size = new System.Drawing.Size(75, 23);
            this.DistOutput.TabIndex = 4;
            this.DistOutput.Text = "Calculate";
            this.DistOutput.UseVisualStyleBackColor = true;
            this.DistOutput.Click += new System.EventHandler(this.DistOutput_Click);
            // 
            // TotExit
            // 
            this.TotExit.Location = new System.Drawing.Point(368, 184);
            this.TotExit.Name = "TotExit";
            this.TotExit.Size = new System.Drawing.Size(75, 23);
            this.TotExit.TabIndex = 5;
            this.TotExit.Text = "Exit";
            this.TotExit.UseVisualStyleBackColor = true;
            this.TotExit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotExit);
            this.Controls.Add(this.DistOutput);
            this.Controls.Add(this.HoursInputLabel);
            this.Controls.Add(this.SpeedInputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeedInputLabel;
        private System.Windows.Forms.TextBox HoursInputLabel;
        private System.Windows.Forms.Button DistOutput;
        private System.Windows.Forms.Button TotExit;
    }
}

