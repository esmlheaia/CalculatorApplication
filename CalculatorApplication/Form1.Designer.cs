namespace CalculatorApplication
{
    partial class FrmCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxfnumber = new System.Windows.Forms.TextBox();
            this.txtboxsnumber = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer: ";
            // 
            // txtboxfnumber
            // 
            this.txtboxfnumber.Location = new System.Drawing.Point(166, 14);
            this.txtboxfnumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxfnumber.Name = "txtboxfnumber";
            this.txtboxfnumber.Size = new System.Drawing.Size(186, 21);
            this.txtboxfnumber.TabIndex = 3;
            // 
            // txtboxsnumber
            // 
            this.txtboxsnumber.Location = new System.Drawing.Point(166, 90);
            this.txtboxsnumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxsnumber.Name = "txtboxsnumber";
            this.txtboxsnumber.Size = new System.Drawing.Size(186, 21);
            this.txtboxsnumber.TabIndex = 4;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(215, 51);
            this.cbOperator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(83, 23);
            this.cbOperator.TabIndex = 5;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(164, 136);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(14, 15);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(264, 170);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 27);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(360, 248);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.txtboxsnumber);
            this.Controls.Add(this.txtboxfnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCalculator";
            this.Text = "FrmCalculator";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxfnumber;
        private System.Windows.Forms.TextBox txtboxsnumber;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

