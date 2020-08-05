namespace Exponential_Calc
{
    partial class Dashboard
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
            this.aButtonSubmit = new System.Windows.Forms.Button();
            this.aTextBoxResults = new System.Windows.Forms.TextBox();
            this.aTextBoxStartingValue = new System.Windows.Forms.TextBox();
            this.aTextBoxRateOfReturn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aTextBoxContribution = new System.Windows.Forms.TextBox();
            this.aLabelTTL = new System.Windows.Forms.Label();
            this.aTextBoxTTL = new System.Windows.Forms.TextBox();
            this.aLabelResult = new System.Windows.Forms.Label();
            this.aComboBoxTTL_Type = new System.Windows.Forms.ComboBox();
            this.aComboboxContribution_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aComboboxCompound = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // aButtonSubmit
            // 
            this.aButtonSubmit.Location = new System.Drawing.Point(99, 370);
            this.aButtonSubmit.Name = "aButtonSubmit";
            this.aButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.aButtonSubmit.TabIndex = 0;
            this.aButtonSubmit.Text = "Submit";
            this.aButtonSubmit.UseVisualStyleBackColor = true;
            this.aButtonSubmit.Click += new System.EventHandler(this.aButtonSubmit_Click);
            // 
            // aTextBoxResults
            // 
            this.aTextBoxResults.Location = new System.Drawing.Point(99, 319);
            this.aTextBoxResults.Name = "aTextBoxResults";
            this.aTextBoxResults.Size = new System.Drawing.Size(148, 20);
            this.aTextBoxResults.TabIndex = 1;
            // 
            // aTextBoxStartingValue
            // 
            this.aTextBoxStartingValue.Location = new System.Drawing.Point(99, 94);
            this.aTextBoxStartingValue.Name = "aTextBoxStartingValue";
            this.aTextBoxStartingValue.Size = new System.Drawing.Size(100, 20);
            this.aTextBoxStartingValue.TabIndex = 2;
            this.aTextBoxStartingValue.Leave += new System.EventHandler(this.aTextBoxStartingValue_Leave);
            // 
            // aTextBoxRateOfReturn
            // 
            this.aTextBoxRateOfReturn.Location = new System.Drawing.Point(99, 145);
            this.aTextBoxRateOfReturn.Name = "aTextBoxRateOfReturn";
            this.aTextBoxRateOfReturn.Size = new System.Drawing.Size(100, 20);
            this.aTextBoxRateOfReturn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rate of Return";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contribution";
            // 
            // aTextBoxContribution
            // 
            this.aTextBoxContribution.Location = new System.Drawing.Point(99, 199);
            this.aTextBoxContribution.Name = "aTextBoxContribution";
            this.aTextBoxContribution.Size = new System.Drawing.Size(100, 20);
            this.aTextBoxContribution.TabIndex = 7;
            this.aTextBoxContribution.Leave += new System.EventHandler(this.aTextBoxContribution_Leave);
            // 
            // aLabelTTL
            // 
            this.aLabelTTL.AutoSize = true;
            this.aLabelTTL.Location = new System.Drawing.Point(96, 240);
            this.aLabelTTL.Name = "aLabelTTL";
            this.aLabelTTL.Size = new System.Drawing.Size(42, 13);
            this.aLabelTTL.TabIndex = 10;
            this.aLabelTTL.Text = "Run for";
            // 
            // aTextBoxTTL
            // 
            this.aTextBoxTTL.Location = new System.Drawing.Point(99, 256);
            this.aTextBoxTTL.Name = "aTextBoxTTL";
            this.aTextBoxTTL.Size = new System.Drawing.Size(100, 20);
            this.aTextBoxTTL.TabIndex = 9;
            // 
            // aLabelResult
            // 
            this.aLabelResult.AutoSize = true;
            this.aLabelResult.Location = new System.Drawing.Point(96, 303);
            this.aLabelResult.Name = "aLabelResult";
            this.aLabelResult.Size = new System.Drawing.Size(42, 13);
            this.aLabelResult.TabIndex = 11;
            this.aLabelResult.Text = "Results";
            // 
            // aComboBoxTTL_Type
            // 
            this.aComboBoxTTL_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboBoxTTL_Type.FormattingEnabled = true;
            this.aComboBoxTTL_Type.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.aComboBoxTTL_Type.Location = new System.Drawing.Point(202, 256);
            this.aComboBoxTTL_Type.Name = "aComboBoxTTL_Type";
            this.aComboBoxTTL_Type.Size = new System.Drawing.Size(121, 21);
            this.aComboBoxTTL_Type.TabIndex = 12;
            // 
            // aComboboxContribution_Type
            // 
            this.aComboboxContribution_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxContribution_Type.FormattingEnabled = true;
            this.aComboboxContribution_Type.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly"});
            this.aComboboxContribution_Type.Location = new System.Drawing.Point(202, 199);
            this.aComboboxContribution_Type.Name = "aComboboxContribution_Type";
            this.aComboboxContribution_Type.Size = new System.Drawing.Size(121, 21);
            this.aComboboxContribution_Type.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(465, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ROR will be divided by and applied every day, month or year depending on what is " +
    "selected here.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Compounded";
            // 
            // aComboboxCompound
            // 
            this.aComboboxCompound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxCompound.FormattingEnabled = true;
            this.aComboboxCompound.Items.AddRange(new object[] {
            "Daily",
            "Monthly",
            "Yearly"});
            this.aComboboxCompound.Location = new System.Drawing.Point(220, 145);
            this.aComboboxCompound.Name = "aComboboxCompound";
            this.aComboboxCompound.Size = new System.Drawing.Size(103, 21);
            this.aComboboxCompound.TabIndex = 17;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 566);
            this.Controls.Add(this.aComboboxCompound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aComboboxContribution_Type);
            this.Controls.Add(this.aComboBoxTTL_Type);
            this.Controls.Add(this.aLabelResult);
            this.Controls.Add(this.aLabelTTL);
            this.Controls.Add(this.aTextBoxTTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aTextBoxContribution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBoxRateOfReturn);
            this.Controls.Add(this.aTextBoxStartingValue);
            this.Controls.Add(this.aTextBoxResults);
            this.Controls.Add(this.aButtonSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonSubmit;
        private System.Windows.Forms.TextBox aTextBoxResults;
        private System.Windows.Forms.TextBox aTextBoxStartingValue;
        private System.Windows.Forms.TextBox aTextBoxRateOfReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aTextBoxContribution;
        private System.Windows.Forms.Label aLabelTTL;
        private System.Windows.Forms.TextBox aTextBoxTTL;
        private System.Windows.Forms.Label aLabelResult;
        private System.Windows.Forms.ComboBox aComboBoxTTL_Type;
        private System.Windows.Forms.ComboBox aComboboxContribution_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox aComboboxCompound;
    }
}

