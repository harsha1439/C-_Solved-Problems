namespace stadium_seating
{
    partial class form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.class3Label = new System.Windows.Forms.Label();
            this.ClassBLabel = new System.Windows.Forms.Label();
            this.ClassALabel = new System.Windows.Forms.Label();
            this.classCticketsold = new System.Windows.Forms.TextBox();
            this.classAticketsold = new System.Windows.Forms.TextBox();
            this.classBticketsold = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalReven = new System.Windows.Forms.TextBox();
            this.classCtotalreven = new System.Windows.Forms.TextBox();
            this.classBReven = new System.Windows.Forms.Label();
            this.classBtotalreven = new System.Windows.Forms.TextBox();
            this.classCReven = new System.Windows.Forms.Label();
            this.classAtotalreven = new System.Windows.Forms.TextBox();
            this.classAReven = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.class3Label);
            this.groupBox1.Controls.Add(this.ClassBLabel);
            this.groupBox1.Controls.Add(this.ClassALabel);
            this.groupBox1.Controls.Add(this.classCticketsold);
            this.groupBox1.Controls.Add(this.classAticketsold);
            this.groupBox1.Controls.Add(this.classBticketsold);
            this.groupBox1.Location = new System.Drawing.Point(72, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets sold";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // class3Label
            // 
            this.class3Label.AutoSize = true;
            this.class3Label.Location = new System.Drawing.Point(27, 120);
            this.class3Label.Name = "class3Label";
            this.class3Label.Size = new System.Drawing.Size(45, 13);
            this.class3Label.TabIndex = 2;
            this.class3Label.Text = "Class C:";
            // 
            // ClassBLabel
            // 
            this.ClassBLabel.AutoSize = true;
            this.ClassBLabel.Location = new System.Drawing.Point(27, 77);
            this.ClassBLabel.Name = "ClassBLabel";
            this.ClassBLabel.Size = new System.Drawing.Size(45, 13);
            this.ClassBLabel.TabIndex = 1;
            this.ClassBLabel.Text = "Class B:";
            // 
            // ClassALabel
            // 
            this.ClassALabel.AutoSize = true;
            this.ClassALabel.Location = new System.Drawing.Point(27, 42);
            this.ClassALabel.Name = "ClassALabel";
            this.ClassALabel.Size = new System.Drawing.Size(45, 13);
            this.ClassALabel.TabIndex = 0;
            this.ClassALabel.Text = "Class A:";
            // 
            // classCticketsold
            // 
            this.classCticketsold.Location = new System.Drawing.Point(93, 120);
            this.classCticketsold.Name = "classCticketsold";
            this.classCticketsold.Size = new System.Drawing.Size(100, 20);
            this.classCticketsold.TabIndex = 4;
            // 
            // classAticketsold
            // 
            this.classAticketsold.Location = new System.Drawing.Point(93, 42);
            this.classAticketsold.Name = "classAticketsold";
            this.classAticketsold.Size = new System.Drawing.Size(100, 20);
            this.classAticketsold.TabIndex = 2;
            this.classAticketsold.TextChanged += new System.EventHandler(this.ClassAticketsold_TextChanged);
            // 
            // classBticketsold
            // 
            this.classBticketsold.Location = new System.Drawing.Point(93, 77);
            this.classBticketsold.Name = "classBticketsold";
            this.classBticketsold.Size = new System.Drawing.Size(100, 20);
            this.classBticketsold.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalReven);
            this.groupBox2.Controls.Add(this.classCtotalreven);
            this.groupBox2.Controls.Add(this.classBReven);
            this.groupBox2.Controls.Add(this.classBtotalreven);
            this.groupBox2.Controls.Add(this.classCReven);
            this.groupBox2.Controls.Add(this.classAtotalreven);
            this.groupBox2.Controls.Add(this.classAReven);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(409, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // totalReven
            // 
            this.totalReven.Location = new System.Drawing.Point(118, 140);
            this.totalReven.Name = "totalReven";
            this.totalReven.ReadOnly = true;
            this.totalReven.Size = new System.Drawing.Size(100, 20);
            this.totalReven.TabIndex = 8;
            // 
            // classCtotalreven
            // 
            this.classCtotalreven.Location = new System.Drawing.Point(118, 95);
            this.classCtotalreven.Name = "classCtotalreven";
            this.classCtotalreven.ReadOnly = true;
            this.classCtotalreven.Size = new System.Drawing.Size(100, 20);
            this.classCtotalreven.TabIndex = 7;
            this.classCtotalreven.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // classBReven
            // 
            this.classBReven.AutoSize = true;
            this.classBReven.Location = new System.Drawing.Point(44, 63);
            this.classBReven.Name = "classBReven";
            this.classBReven.Size = new System.Drawing.Size(45, 13);
            this.classBReven.TabIndex = 4;
            this.classBReven.Text = "Class B:";
            // 
            // classBtotalreven
            // 
            this.classBtotalreven.Location = new System.Drawing.Point(118, 60);
            this.classBtotalreven.Name = "classBtotalreven";
            this.classBtotalreven.ReadOnly = true;
            this.classBtotalreven.Size = new System.Drawing.Size(100, 20);
            this.classBtotalreven.TabIndex = 6;
            // 
            // classCReven
            // 
            this.classCReven.AutoSize = true;
            this.classCReven.Location = new System.Drawing.Point(44, 95);
            this.classCReven.Name = "classCReven";
            this.classCReven.Size = new System.Drawing.Size(45, 13);
            this.classCReven.TabIndex = 5;
            this.classCReven.Text = "Class C:";
            // 
            // classAtotalreven
            // 
            this.classAtotalreven.Location = new System.Drawing.Point(118, 28);
            this.classAtotalreven.Name = "classAtotalreven";
            this.classAtotalreven.ReadOnly = true;
            this.classAtotalreven.Size = new System.Drawing.Size(100, 20);
            this.classAtotalreven.TabIndex = 5;
            // 
            // classAReven
            // 
            this.classAReven.AutoSize = true;
            this.classAReven.Location = new System.Drawing.Point(44, 31);
            this.classAReven.Name = "classAReven";
            this.classAReven.Size = new System.Drawing.Size(45, 13);
            this.classAReven.TabIndex = 3;
            this.classAReven.Text = "Class A:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(190, 279);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(75, 46);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Calculate Revenue";
            this.outputLabel.UseVisualStyleBackColor = true;
            this.outputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // clearall
            // 
            this.clearall.Location = new System.Drawing.Point(320, 291);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(75, 23);
            this.clearall.TabIndex = 9;
            this.clearall.Text = "clear";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.Clearall_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(482, 291);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.Close_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 406);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form";
            this.Text = "stadiun seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label class3Label;
        private System.Windows.Forms.Label ClassBLabel;
        private System.Windows.Forms.Label ClassALabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label classBReven;
        private System.Windows.Forms.Label classCReven;
        private System.Windows.Forms.Label classAReven;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox classCticketsold;
        private System.Windows.Forms.TextBox classAticketsold;
        private System.Windows.Forms.TextBox classBticketsold;
        private System.Windows.Forms.TextBox totalReven;
        private System.Windows.Forms.TextBox classCtotalreven;
        private System.Windows.Forms.TextBox classBtotalreven;
        private System.Windows.Forms.TextBox classAtotalreven;
        private System.Windows.Forms.Button outputLabel;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button exitbutton;
    }
}

