namespace Workshop_Selector
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
            this.workShopListBox = new System.Windows.Forms.ListBox();
            this.lodgingListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcTotal = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.ExitForm = new System.Windows.Forms.Button();
            this.regOutput = new System.Windows.Forms.TextBox();
            this.lodgOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // workShopListBox
            // 
            this.workShopListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workShopListBox.FormattingEnabled = true;
            this.workShopListBox.ItemHeight = 29;
            this.workShopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workShopListBox.Location = new System.Drawing.Point(266, 96);
            this.workShopListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.workShopListBox.Name = "workShopListBox";
            this.workShopListBox.Size = new System.Drawing.Size(236, 178);
            this.workShopListBox.TabIndex = 0;
            // 
            // lodgingListBox
            // 
            this.lodgingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingListBox.FormattingEnabled = true;
            this.lodgingListBox.ItemHeight = 29;
            this.lodgingListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoneix",
            "Raleigh"});
            this.lodgingListBox.Location = new System.Drawing.Point(668, 96);
            this.lodgingListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lodgingListBox.Name = "lodgingListBox";
            this.lodgingListBox.Size = new System.Drawing.Size(236, 178);
            this.lodgingListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lodging";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 477);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // calcTotal
            // 
            this.calcTotal.Location = new System.Drawing.Point(280, 544);
            this.calcTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Size = new System.Drawing.Size(150, 44);
            this.calcTotal.TabIndex = 7;
            this.calcTotal.Text = "Calculate";
            this.calcTotal.UseVisualStyleBackColor = true;
            this.calcTotal.Click += new System.EventHandler(this.CalcTotal_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(532, 544);
            this.clearAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(150, 44);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ExitForm
            // 
            this.ExitForm.Location = new System.Drawing.Point(758, 544);
            this.ExitForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(150, 44);
            this.ExitForm.TabIndex = 9;
            this.ExitForm.Text = "Exit";
            this.ExitForm.UseVisualStyleBackColor = true;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // regOutput
            // 
            this.regOutput.Location = new System.Drawing.Point(554, 354);
            this.regOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.regOutput.Name = "regOutput";
            this.regOutput.Size = new System.Drawing.Size(196, 31);
            this.regOutput.TabIndex = 10;
            // 
            // lodgOutput
            // 
            this.lodgOutput.Location = new System.Drawing.Point(554, 421);
            this.lodgOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lodgOutput.Name = "lodgOutput";
            this.lodgOutput.Size = new System.Drawing.Size(196, 31);
            this.lodgOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(554, 477);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(196, 31);
            this.totalOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.lodgOutput);
            this.Controls.Add(this.regOutput);
            this.Controls.Add(this.ExitForm);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.calcTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lodgingListBox);
            this.Controls.Add(this.workShopListBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Workshop selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workShopListBox;
        private System.Windows.Forms.ListBox lodgingListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcTotal;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button ExitForm;
        private System.Windows.Forms.TextBox regOutput;
        private System.Windows.Forms.TextBox lodgOutput;
        private System.Windows.Forms.TextBox totalOutput;
    }
}

