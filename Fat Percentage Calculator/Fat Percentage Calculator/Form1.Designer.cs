namespace Fat_Percentage_Calculator
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
            this.totCaloriesLabel = new System.Windows.Forms.Label();
            this.numFatinFoodLabel = new System.Windows.Forms.Label();
            this.calFromFatLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.checkOutput = new System.Windows.Forms.CheckBox();
            this.totCaloriePromptLabel = new System.Windows.Forms.TextBox();
            this.numFatInFoodPromptLabel = new System.Windows.Forms.TextBox();
            this.calFromFatPromptLabel = new System.Windows.Forms.TextBox();
            this.percentageOutputLabel = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totCaloriesLabel
            // 
            this.totCaloriesLabel.AutoSize = true;
            this.totCaloriesLabel.Location = new System.Drawing.Point(128, 50);
            this.totCaloriesLabel.Name = "totCaloriesLabel";
            this.totCaloriesLabel.Size = new System.Drawing.Size(193, 13);
            this.totCaloriesLabel.TabIndex = 0;
            this.totCaloriesLabel.Text = "Total number of calories for a food item ";
            // 
            // numFatinFoodLabel
            // 
            this.numFatinFoodLabel.AutoSize = true;
            this.numFatinFoodLabel.Location = new System.Drawing.Point(128, 80);
            this.numFatinFoodLabel.Name = "numFatinFoodLabel";
            this.numFatinFoodLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numFatinFoodLabel.Size = new System.Drawing.Size(180, 13);
            this.numFatinFoodLabel.TabIndex = 1;
            this.numFatinFoodLabel.Text = "Number of fat grams in that food item";
            // 
            // calFromFatLabel
            // 
            this.calFromFatLabel.AutoSize = true;
            this.calFromFatLabel.Location = new System.Drawing.Point(128, 111);
            this.calFromFatLabel.Name = "calFromFatLabel";
            this.calFromFatLabel.Size = new System.Drawing.Size(133, 13);
            this.calFromFatLabel.TabIndex = 2;
            this.calFromFatLabel.Text = "Number of calories from fat";
            this.calFromFatLabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(128, 141);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(180, 13);
            this.PercentageLabel.TabIndex = 3;
            this.PercentageLabel.Text = "Percentage of caloreis come from fat";
            // 
            // checkOutput
            // 
            this.checkOutput.AutoSize = true;
            this.checkOutput.Location = new System.Drawing.Point(131, 183);
            this.checkOutput.Name = "checkOutput";
            this.checkOutput.Size = new System.Drawing.Size(214, 17);
            this.checkOutput.TabIndex = 4;
            this.checkOutput.Text = "Check whether the food is low fat or not";
            this.checkOutput.UseVisualStyleBackColor = true;
            // 
            // totCaloriePromptLabel
            // 
            this.totCaloriePromptLabel.Location = new System.Drawing.Point(351, 50);
            this.totCaloriePromptLabel.Name = "totCaloriePromptLabel";
            this.totCaloriePromptLabel.Size = new System.Drawing.Size(100, 20);
            this.totCaloriePromptLabel.TabIndex = 5;
            // 
            // numFatInFoodPromptLabel
            // 
            this.numFatInFoodPromptLabel.Location = new System.Drawing.Point(351, 81);
            this.numFatInFoodPromptLabel.Name = "numFatInFoodPromptLabel";
            this.numFatInFoodPromptLabel.Size = new System.Drawing.Size(100, 20);
            this.numFatInFoodPromptLabel.TabIndex = 6;
            // 
            // calFromFatPromptLabel
            // 
            this.calFromFatPromptLabel.Location = new System.Drawing.Point(351, 111);
            this.calFromFatPromptLabel.Name = "calFromFatPromptLabel";
            this.calFromFatPromptLabel.ReadOnly = true;
            this.calFromFatPromptLabel.Size = new System.Drawing.Size(100, 20);
            this.calFromFatPromptLabel.TabIndex = 7;
            // 
            // percentageOutputLabel
            // 
            this.percentageOutputLabel.Location = new System.Drawing.Point(351, 141);
            this.percentageOutputLabel.Name = "percentageOutputLabel";
            this.percentageOutputLabel.ReadOnly = true;
            this.percentageOutputLabel.Size = new System.Drawing.Size(100, 20);
            this.percentageOutputLabel.TabIndex = 8;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(131, 234);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 9;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(271, 234);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 23);
            this.clearAll.TabIndex = 10;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(411, 234);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.percentageOutputLabel);
            this.Controls.Add(this.calFromFatPromptLabel);
            this.Controls.Add(this.numFatInFoodPromptLabel);
            this.Controls.Add(this.totCaloriePromptLabel);
            this.Controls.Add(this.checkOutput);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.calFromFatLabel);
            this.Controls.Add(this.numFatinFoodLabel);
            this.Controls.Add(this.totCaloriesLabel);
            this.Name = "Form1";
            this.Text = "Fat Percentage Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totCaloriesLabel;
        private System.Windows.Forms.Label numFatinFoodLabel;
        private System.Windows.Forms.Label calFromFatLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.CheckBox checkOutput;
        private System.Windows.Forms.TextBox totCaloriePromptLabel;
        private System.Windows.Forms.TextBox numFatInFoodPromptLabel;
        private System.Windows.Forms.TextBox calFromFatPromptLabel;
        private System.Windows.Forms.TextBox percentageOutputLabel;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button Exit;
    }
}

