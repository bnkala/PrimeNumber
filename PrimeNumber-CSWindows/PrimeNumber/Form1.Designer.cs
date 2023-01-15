namespace PrimeNumber
{
    partial class PrimeNumber
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtPrime = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(156, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 23);
            this.txtNum.TabIndex = 1;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(53, 154);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 2;
            this.btnDetermine.Text = "Submit";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // txtPrime
            // 
            this.txtPrime.Location = new System.Drawing.Point(12, 79);
            this.txtPrime.Name = "txtPrime";
            this.txtPrime.Size = new System.Drawing.Size(283, 23);
            this.txtPrime.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(118, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // PrimeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrime);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "PrimeNumber";
            this.Text = "PrimeNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnDetermine;
        private TextBox txtPrime;
        private Button btnClear;
        private Button btnExit;
    }
}