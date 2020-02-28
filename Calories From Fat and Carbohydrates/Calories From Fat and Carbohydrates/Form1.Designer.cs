namespace Calories_From_Fat_and_Carbohydrates
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
            this.FatgramLabel = new System.Windows.Forms.Label();
            this.CarbsLabel = new System.Windows.Forms.Label();
            this.CalFromFatLabel = new System.Windows.Forms.Label();
            this.CalFromCarbs = new System.Windows.Forms.Label();
            this.fatGramInput = new System.Windows.Forms.TextBox();
            this.carbInput = new System.Windows.Forms.TextBox();
            this.fatGramOutput = new System.Windows.Forms.TextBox();
            this.carbOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FatgramLabel
            // 
            this.FatgramLabel.AutoSize = true;
            this.FatgramLabel.Location = new System.Drawing.Point(245, 103);
            this.FatgramLabel.Name = "FatgramLabel";
            this.FatgramLabel.Size = new System.Drawing.Size(108, 25);
            this.FatgramLabel.TabIndex = 0;
            this.FatgramLabel.Text = "Fat grams";
            // 
            // CarbsLabel
            // 
            this.CarbsLabel.AutoSize = true;
            this.CarbsLabel.Location = new System.Drawing.Point(245, 174);
            this.CarbsLabel.Name = "CarbsLabel";
            this.CarbsLabel.Size = new System.Drawing.Size(123, 25);
            this.CarbsLabel.TabIndex = 1;
            this.CarbsLabel.Text = "Carb grams";
            // 
            // CalFromFatLabel
            // 
            this.CalFromFatLabel.AutoSize = true;
            this.CalFromFatLabel.Location = new System.Drawing.Point(245, 242);
            this.CalFromFatLabel.Name = "CalFromFatLabel";
            this.CalFromFatLabel.Size = new System.Drawing.Size(235, 25);
            this.CalFromFatLabel.TabIndex = 2;
            this.CalFromFatLabel.Text = "Calories from Fatgrams";
            // 
            // CalFromCarbs
            // 
            this.CalFromCarbs.AutoSize = true;
            this.CalFromCarbs.Location = new System.Drawing.Point(245, 313);
            this.CalFromCarbs.Name = "CalFromCarbs";
            this.CalFromCarbs.Size = new System.Drawing.Size(202, 25);
            this.CalFromCarbs.TabIndex = 3;
            this.CalFromCarbs.Text = "Caloreis from Carbs";
            // 
            // fatGramInput
            // 
            this.fatGramInput.Location = new System.Drawing.Point(511, 103);
            this.fatGramInput.Name = "fatGramInput";
            this.fatGramInput.Size = new System.Drawing.Size(162, 31);
            this.fatGramInput.TabIndex = 4;
            // 
            // carbInput
            // 
            this.carbInput.Location = new System.Drawing.Point(511, 171);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(162, 31);
            this.carbInput.TabIndex = 5;
            // 
            // fatGramOutput
            // 
            this.fatGramOutput.Location = new System.Drawing.Point(511, 242);
            this.fatGramOutput.Name = "fatGramOutput";
            this.fatGramOutput.ReadOnly = true;
            this.fatGramOutput.Size = new System.Drawing.Size(162, 31);
            this.fatGramOutput.TabIndex = 6;
            // 
            // carbOutput
            // 
            this.carbOutput.Location = new System.Drawing.Point(511, 313);
            this.carbOutput.Name = "carbOutput";
            this.carbOutput.ReadOnly = true;
            this.carbOutput.Size = new System.Drawing.Size(162, 31);
            this.carbOutput.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 74);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carbOutput);
            this.Controls.Add(this.fatGramOutput);
            this.Controls.Add(this.carbInput);
            this.Controls.Add(this.fatGramInput);
            this.Controls.Add(this.CalFromCarbs);
            this.Controls.Add(this.CalFromFatLabel);
            this.Controls.Add(this.CarbsLabel);
            this.Controls.Add(this.FatgramLabel);
            this.Name = "Form1";
            this.Text = "Calorie Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FatgramLabel;
        private System.Windows.Forms.Label CarbsLabel;
        private System.Windows.Forms.Label CalFromFatLabel;
        private System.Windows.Forms.Label CalFromCarbs;
        private System.Windows.Forms.TextBox fatGramInput;
        private System.Windows.Forms.TextBox carbInput;
        private System.Windows.Forms.TextBox fatGramOutput;
        private System.Windows.Forms.TextBox carbOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

