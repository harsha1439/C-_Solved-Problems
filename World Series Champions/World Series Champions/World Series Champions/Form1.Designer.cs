namespace World_Series_Champions
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
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.outputLabel = new System.Windows.Forms.Button();
            this.exitlabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 25;
            this.teamListBox.Location = new System.Drawing.Point(446, 154);
            this.teamListBox.Margin = new System.Windows.Forms.Padding(6);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(308, 329);
            this.teamListBox.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(446, 506);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(6);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(150, 44);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Check";
            this.outputLabel.UseVisualStyleBackColor = true;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // exitlabel
            // 
            this.exitlabel.Location = new System.Drawing.Point(608, 506);
            this.exitlabel.Margin = new System.Windows.Forms.Padding(6);
            this.exitlabel.Name = "exitlabel";
            this.exitlabel.Size = new System.Drawing.Size(150, 44);
            this.exitlabel.TabIndex = 3;
            this.exitlabel.Text = "Exit";
            this.exitlabel.UseVisualStyleBackColor = true;
            this.exitlabel.Click += new System.EventHandler(this.exitlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.exitlabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button outputLabel;
        private System.Windows.Forms.Button exitlabel;
    }
}

