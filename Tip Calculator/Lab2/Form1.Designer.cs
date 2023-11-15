namespace Lab2
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
            this.userMealInputLbl = new System.Windows.Forms.Label();
            this.userMealInputTxt = new System.Windows.Forms.TextBox();
            this.userTipOutputLbl1 = new System.Windows.Forms.Label();
            this.userTipOutput1 = new System.Windows.Forms.Label();
            this.userTipOutputLbl2 = new System.Windows.Forms.Label();
            this.userTipOutput2 = new System.Windows.Forms.Label();
            this.userTipOutputLbl3 = new System.Windows.Forms.Label();
            this.userTipOutput3 = new System.Windows.Forms.Label();
            this.userTipCalculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userMealInputLbl
            // 
            this.userMealInputLbl.AutoSize = true;
            this.userMealInputLbl.Location = new System.Drawing.Point(13, 13);
            this.userMealInputLbl.Name = "userMealInputLbl";
            this.userMealInputLbl.Size = new System.Drawing.Size(98, 13);
            this.userMealInputLbl.TabIndex = 0;
            this.userMealInputLbl.Text = "Enter price of meal:";
            // 
            // userMealInputTxt
            // 
            this.userMealInputTxt.Location = new System.Drawing.Point(118, 13);
            this.userMealInputTxt.Name = "userMealInputTxt";
            this.userMealInputTxt.Size = new System.Drawing.Size(100, 20);
            this.userMealInputTxt.TabIndex = 1;
            // 
            // userTipOutputLbl1
            // 
            this.userTipOutputLbl1.AutoSize = true;
            this.userTipOutputLbl1.Location = new System.Drawing.Point(75, 53);
            this.userTipOutputLbl1.Name = "userTipOutputLbl1";
            this.userTipOutputLbl1.Size = new System.Drawing.Size(27, 13);
            this.userTipOutputLbl1.TabIndex = 2;
            this.userTipOutputLbl1.Text = "15%";
            // 
            // userTipOutput1
            // 
            this.userTipOutput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTipOutput1.Location = new System.Drawing.Point(118, 53);
            this.userTipOutput1.Name = "userTipOutput1";
            this.userTipOutput1.Size = new System.Drawing.Size(100, 13);
            this.userTipOutput1.TabIndex = 3;
            // 
            // userTipOutputLbl2
            // 
            this.userTipOutputLbl2.AutoSize = true;
            this.userTipOutputLbl2.Location = new System.Drawing.Point(75, 66);
            this.userTipOutputLbl2.Name = "userTipOutputLbl2";
            this.userTipOutputLbl2.Size = new System.Drawing.Size(27, 13);
            this.userTipOutputLbl2.TabIndex = 4;
            this.userTipOutputLbl2.Text = "18%";
            // 
            // userTipOutput2
            // 
            this.userTipOutput2.AllowDrop = true;
            this.userTipOutput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTipOutput2.Location = new System.Drawing.Point(118, 66);
            this.userTipOutput2.Name = "userTipOutput2";
            this.userTipOutput2.Size = new System.Drawing.Size(100, 14);
            this.userTipOutput2.TabIndex = 5;
            // 
            // userTipOutputLbl3
            // 
            this.userTipOutputLbl3.AutoSize = true;
            this.userTipOutputLbl3.Location = new System.Drawing.Point(75, 79);
            this.userTipOutputLbl3.Name = "userTipOutputLbl3";
            this.userTipOutputLbl3.Size = new System.Drawing.Size(27, 13);
            this.userTipOutputLbl3.TabIndex = 6;
            this.userTipOutputLbl3.Text = "20%";
            // 
            // userTipOutput3
            // 
            this.userTipOutput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTipOutput3.Location = new System.Drawing.Point(118, 80);
            this.userTipOutput3.Name = "userTipOutput3";
            this.userTipOutput3.Size = new System.Drawing.Size(100, 13);
            this.userTipOutput3.TabIndex = 7;
            // 
            // userTipCalculation
            // 
            this.userTipCalculation.Location = new System.Drawing.Point(219, 52);
            this.userTipCalculation.Name = "userTipCalculation";
            this.userTipCalculation.Size = new System.Drawing.Size(75, 43);
            this.userTipCalculation.TabIndex = 8;
            this.userTipCalculation.Text = "Calculate Tip";
            this.userTipCalculation.UseVisualStyleBackColor = true;
            this.userTipCalculation.Click += new System.EventHandler(this.userTipCalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.userTipCalculation);
            this.Controls.Add(this.userTipOutput3);
            this.Controls.Add(this.userTipOutputLbl3);
            this.Controls.Add(this.userTipOutput2);
            this.Controls.Add(this.userTipOutputLbl2);
            this.Controls.Add(this.userTipOutput1);
            this.Controls.Add(this.userTipOutputLbl1);
            this.Controls.Add(this.userMealInputTxt);
            this.Controls.Add(this.userMealInputLbl);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userMealInputLbl;
        private System.Windows.Forms.TextBox userMealInputTxt;
        private System.Windows.Forms.Label userTipOutputLbl1;
        private System.Windows.Forms.Label userTipOutput1;
        private System.Windows.Forms.Label userTipOutputLbl2;
        private System.Windows.Forms.Label userTipOutput2;
        private System.Windows.Forms.Label userTipOutputLbl3;
        private System.Windows.Forms.Label userTipOutput3;
        private System.Windows.Forms.Button userTipCalculation;
    }
}

