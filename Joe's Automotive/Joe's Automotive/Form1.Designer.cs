namespace Joe_s_Automotive
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
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilCheckBox = new System.Windows.Forms.CheckBox();
            this.flushGroupBox = new System.Windows.Forms.GroupBox();
            this.transCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireCheckBox = new System.Windows.Forms.CheckBox();
            this.muffCheckBox = new System.Windows.Forms.CheckBox();
            this.inspCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.partsInput = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeeOutput = new System.Windows.Forms.TextBox();
            this.taxOutputlabel = new System.Windows.Forms.TextBox();
            this.partsOutput = new System.Windows.Forms.TextBox();
            this.laborOutput = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.partsOutLabel = new System.Windows.Forms.Label();
            this.laborOutLabel = new System.Windows.Forms.Label();
            this.CalcOutputButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.flushGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.Controls.Add(this.lubeCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilCheckBox);
            this.oilLubeGroupBox.Location = new System.Drawing.Point(94, 24);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Size = new System.Drawing.Size(200, 91);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "oil and Lube";
            this.oilLubeGroupBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(18, 52);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(109, 17);
            this.lubeCheckBox.TabIndex = 1;
            this.lubeCheckBox.Text = "Lube Job($18.00)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilCheckBox
            // 
            this.oilCheckBox.AutoSize = true;
            this.oilCheckBox.Location = new System.Drawing.Point(18, 29);
            this.oilCheckBox.Name = "oilCheckBox";
            this.oilCheckBox.Size = new System.Drawing.Size(120, 17);
            this.oilCheckBox.TabIndex = 0;
            this.oilCheckBox.Text = "Oil Change ($26.00)";
            this.oilCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushGroupBox
            // 
            this.flushGroupBox.Controls.Add(this.transCheckBox);
            this.flushGroupBox.Controls.Add(this.radiatorCheckBox);
            this.flushGroupBox.Location = new System.Drawing.Point(322, 24);
            this.flushGroupBox.Name = "flushGroupBox";
            this.flushGroupBox.Size = new System.Drawing.Size(200, 91);
            this.flushGroupBox.TabIndex = 1;
            this.flushGroupBox.TabStop = false;
            this.flushGroupBox.Text = "Flushes";
            // 
            // transCheckBox
            // 
            this.transCheckBox.AutoSize = true;
            this.transCheckBox.Location = new System.Drawing.Point(28, 52);
            this.transCheckBox.Name = "transCheckBox";
            this.transCheckBox.Size = new System.Drawing.Size(157, 17);
            this.transCheckBox.TabIndex = 1;
            this.transCheckBox.Text = "Transmission Flush ($80.00)";
            this.transCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Location = new System.Drawing.Point(28, 29);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(121, 17);
            this.radiatorCheckBox.TabIndex = 0;
            this.radiatorCheckBox.Text = "Radiator Flush ($30)";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireCheckBox);
            this.miscGroupBox.Controls.Add(this.muffCheckBox);
            this.miscGroupBox.Controls.Add(this.inspCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(94, 131);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireCheckBox
            // 
            this.tireCheckBox.AutoSize = true;
            this.tireCheckBox.Location = new System.Drawing.Point(18, 77);
            this.tireCheckBox.Name = "tireCheckBox";
            this.tireCheckBox.Size = new System.Drawing.Size(129, 17);
            this.tireCheckBox.TabIndex = 2;
            this.tireCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireCheckBox.UseVisualStyleBackColor = true;
            // 
            // muffCheckBox
            // 
            this.muffCheckBox.AutoSize = true;
            this.muffCheckBox.Location = new System.Drawing.Point(18, 54);
            this.muffCheckBox.Name = "muffCheckBox";
            this.muffCheckBox.Size = new System.Drawing.Size(149, 17);
            this.muffCheckBox.TabIndex = 1;
            this.muffCheckBox.Text = "Replace Muffler ($100.00)";
            this.muffCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspCheckBox
            // 
            this.inspCheckBox.AutoSize = true;
            this.inspCheckBox.Location = new System.Drawing.Point(18, 31);
            this.inspCheckBox.Name = "inspCheckBox";
            this.inspCheckBox.Size = new System.Drawing.Size(117, 17);
            this.inspCheckBox.TabIndex = 0;
            this.inspCheckBox.Text = "Inspection ($15.00)";
            this.inspCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGroupBox
            // 
            this.partsLaborGroupBox.Controls.Add(this.laborInput);
            this.partsLaborGroupBox.Controls.Add(this.partsInput);
            this.partsLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsLaborGroupBox.Location = new System.Drawing.Point(322, 131);
            this.partsLaborGroupBox.Name = "partsLaborGroupBox";
            this.partsLaborGroupBox.Size = new System.Drawing.Size(200, 100);
            this.partsLaborGroupBox.TabIndex = 3;
            this.partsLaborGroupBox.TabStop = false;
            this.partsLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(92, 56);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(79, 20);
            this.laborInput.TabIndex = 3;
            // 
            // partsInput
            // 
            this.partsInput.Location = new System.Drawing.Point(92, 29);
            this.partsInput.Name = "partsInput";
            this.partsInput.Size = new System.Drawing.Size(79, 20);
            this.partsInput.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(28, 58);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(49, 13);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor ($)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(28, 31);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalFeeOutput);
            this.summaryGroupBox.Controls.Add(this.taxOutputlabel);
            this.summaryGroupBox.Controls.Add(this.partsOutput);
            this.summaryGroupBox.Controls.Add(this.laborOutput);
            this.summaryGroupBox.Controls.Add(this.total);
            this.summaryGroupBox.Controls.Add(this.TaxLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutLabel);
            this.summaryGroupBox.Controls.Add(this.laborOutLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(94, 257);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(434, 149);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalFeeOutput
            // 
            this.totalFeeOutput.Location = new System.Drawing.Point(145, 110);
            this.totalFeeOutput.Name = "totalFeeOutput";
            this.totalFeeOutput.ReadOnly = true;
            this.totalFeeOutput.Size = new System.Drawing.Size(100, 20);
            this.totalFeeOutput.TabIndex = 7;
            // 
            // taxOutputlabel
            // 
            this.taxOutputlabel.Location = new System.Drawing.Point(145, 82);
            this.taxOutputlabel.Name = "taxOutputlabel";
            this.taxOutputlabel.ReadOnly = true;
            this.taxOutputlabel.Size = new System.Drawing.Size(100, 20);
            this.taxOutputlabel.TabIndex = 6;
            // 
            // partsOutput
            // 
            this.partsOutput.Location = new System.Drawing.Point(145, 57);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.ReadOnly = true;
            this.partsOutput.Size = new System.Drawing.Size(100, 20);
            this.partsOutput.TabIndex = 5;
            // 
            // laborOutput
            // 
            this.laborOutput.Location = new System.Drawing.Point(145, 27);
            this.laborOutput.Name = "laborOutput";
            this.laborOutput.ReadOnly = true;
            this.laborOutput.Size = new System.Drawing.Size(100, 20);
            this.laborOutput.TabIndex = 4;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(36, 110);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(57, 13);
            this.total.TabIndex = 3;
            this.total.Text = "Total Fees";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(33, 82);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(72, 13);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax (on parts)";
            // 
            // partsOutLabel
            // 
            this.partsOutLabel.AutoSize = true;
            this.partsOutLabel.Location = new System.Drawing.Point(33, 56);
            this.partsOutLabel.Name = "partsOutLabel";
            this.partsOutLabel.Size = new System.Drawing.Size(31, 13);
            this.partsOutLabel.TabIndex = 1;
            this.partsOutLabel.Text = "Parts";
            // 
            // laborOutLabel
            // 
            this.laborOutLabel.AutoSize = true;
            this.laborOutLabel.Location = new System.Drawing.Point(33, 30);
            this.laborOutLabel.Name = "laborOutLabel";
            this.laborOutLabel.Size = new System.Drawing.Size(94, 13);
            this.laborOutLabel.TabIndex = 0;
            this.laborOutLabel.Text = "Service and Labor";
            // 
            // CalcOutputButton
            // 
            this.CalcOutputButton.Location = new System.Drawing.Point(121, 413);
            this.CalcOutputButton.Name = "CalcOutputButton";
            this.CalcOutputButton.Size = new System.Drawing.Size(75, 23);
            this.CalcOutputButton.TabIndex = 5;
            this.CalcOutputButton.Text = "Calculate";
            this.CalcOutputButton.UseVisualStyleBackColor = true;
            this.CalcOutputButton.Click += new System.EventHandler(this.CalcOutputButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(239, 413);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 457);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalcOutputButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushGroupBox);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.flushGroupBox.ResumeLayout(false);
            this.flushGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroupBox.ResumeLayout(false);
            this.partsLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeCheckBox;
        private System.Windows.Forms.CheckBox oilCheckBox;
        private System.Windows.Forms.GroupBox flushGroupBox;
        private System.Windows.Forms.CheckBox transCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireCheckBox;
        private System.Windows.Forms.CheckBox muffCheckBox;
        private System.Windows.Forms.CheckBox inspCheckBox;
        private System.Windows.Forms.GroupBox partsLaborGroupBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.TextBox partsInput;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox totalFeeOutput;
        private System.Windows.Forms.TextBox taxOutputlabel;
        private System.Windows.Forms.TextBox partsOutput;
        private System.Windows.Forms.TextBox laborOutput;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label partsOutLabel;
        private System.Windows.Forms.Label laborOutLabel;
        private System.Windows.Forms.Button CalcOutputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

