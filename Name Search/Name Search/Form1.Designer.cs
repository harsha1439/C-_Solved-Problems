namespace Name_Search
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
            this.Check = new System.Windows.Forms.Button();
            this.Exitall = new System.Windows.Forms.Button();
            this.boyNameInput = new System.Windows.Forms.TextBox();
            this.girlNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the boy name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the girl name";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(165, 192);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 2;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Exitall
            // 
            this.Exitall.Location = new System.Drawing.Point(328, 192);
            this.Exitall.Name = "Exitall";
            this.Exitall.Size = new System.Drawing.Size(75, 23);
            this.Exitall.TabIndex = 3;
            this.Exitall.Text = "Exit";
            this.Exitall.UseVisualStyleBackColor = true;
            this.Exitall.Click += new System.EventHandler(this.Exitall_Click);
            // 
            // boyNameInput
            // 
            this.boyNameInput.Location = new System.Drawing.Point(266, 86);
            this.boyNameInput.Name = "boyNameInput";
            this.boyNameInput.Size = new System.Drawing.Size(100, 20);
            this.boyNameInput.TabIndex = 4;
            // 
            // girlNameInput
            // 
            this.girlNameInput.Location = new System.Drawing.Point(266, 127);
            this.girlNameInput.Name = "girlNameInput";
            this.girlNameInput.Size = new System.Drawing.Size(100, 20);
            this.girlNameInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Most popular names";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(247, 192);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girlNameInput);
            this.Controls.Add(this.boyNameInput);
            this.Controls.Add(this.Exitall);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Exitall;
        private System.Windows.Forms.TextBox boyNameInput;
        private System.Windows.Forms.TextBox girlNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
    }
}

