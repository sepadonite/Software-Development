namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radiusOfSphereLbl = new System.Windows.Forms.Label();
            this.userRadiusInputTxt = new System.Windows.Forms.TextBox();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.diameterOutputLbl = new System.Windows.Forms.Label();
            this.surfaceAreaLbl = new System.Windows.Forms.Label();
            this.surfaceAreaOutputLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.volumeOutputLbl = new System.Windows.Forms.Label();
            this.userInputCalculationBtn = new System.Windows.Forms.Button();
            this.sphereAndBall1 = new System.Windows.Forms.PictureBox();
            this.sphereAndBall2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sphereAndBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereAndBall2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusOfSphereLbl
            // 
            this.radiusOfSphereLbl.AutoSize = true;
            this.radiusOfSphereLbl.Location = new System.Drawing.Point(12, 22);
            this.radiusOfSphereLbl.Name = "radiusOfSphereLbl";
            this.radiusOfSphereLbl.Size = new System.Drawing.Size(87, 13);
            this.radiusOfSphereLbl.TabIndex = 0;
            this.radiusOfSphereLbl.Text = "Radius of sphere";
            // 
            // userRadiusInputTxt
            // 
            this.userRadiusInputTxt.Location = new System.Drawing.Point(105, 22);
            this.userRadiusInputTxt.Name = "userRadiusInputTxt";
            this.userRadiusInputTxt.Size = new System.Drawing.Size(100, 20);
            this.userRadiusInputTxt.TabIndex = 1;
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(12, 76);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 2;
            this.diameterLbl.Text = "Diameter";
            // 
            // diameterOutputLbl
            // 
            this.diameterOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutputLbl.Location = new System.Drawing.Point(105, 66);
            this.diameterOutputLbl.Name = "diameterOutputLbl";
            this.diameterOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.diameterOutputLbl.TabIndex = 3;
            // 
            // surfaceAreaLbl
            // 
            this.surfaceAreaLbl.AutoSize = true;
            this.surfaceAreaLbl.Location = new System.Drawing.Point(12, 118);
            this.surfaceAreaLbl.Name = "surfaceAreaLbl";
            this.surfaceAreaLbl.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLbl.TabIndex = 4;
            this.surfaceAreaLbl.Text = "Surface Area";
            // 
            // surfaceAreaOutputLbl
            // 
            this.surfaceAreaOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaOutputLbl.Location = new System.Drawing.Point(105, 108);
            this.surfaceAreaOutputLbl.Name = "surfaceAreaOutputLbl";
            this.surfaceAreaOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaOutputLbl.TabIndex = 5;
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(12, 153);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(42, 13);
            this.volumeLbl.TabIndex = 6;
            this.volumeLbl.Text = "Volume";
            // 
            // volumeOutputLbl
            // 
            this.volumeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutputLbl.Location = new System.Drawing.Point(105, 143);
            this.volumeOutputLbl.Name = "volumeOutputLbl";
            this.volumeOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.volumeOutputLbl.TabIndex = 7;
            // 
            // userInputCalculationBtn
            // 
            this.userInputCalculationBtn.Location = new System.Drawing.Point(222, 226);
            this.userInputCalculationBtn.Name = "userInputCalculationBtn";
            this.userInputCalculationBtn.Size = new System.Drawing.Size(103, 68);
            this.userInputCalculationBtn.TabIndex = 8;
            this.userInputCalculationBtn.Text = "Calculate";
            this.userInputCalculationBtn.UseVisualStyleBackColor = true;
            this.userInputCalculationBtn.Click += new System.EventHandler(this.userInputCalculationBtn_Click);
            // 
            // sphereAndBall1
            // 
            this.sphereAndBall1.Image = ((System.Drawing.Image)(resources.GetObject("sphereAndBall1.Image")));
            this.sphereAndBall1.Location = new System.Drawing.Point(222, 7);
            this.sphereAndBall1.Name = "sphereAndBall1";
            this.sphereAndBall1.Size = new System.Drawing.Size(150, 150);
            this.sphereAndBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereAndBall1.TabIndex = 9;
            this.sphereAndBall1.TabStop = false;
            // 
            // sphereAndBall2
            // 
            this.sphereAndBall2.Image = ((System.Drawing.Image)(resources.GetObject("sphereAndBall2.Image")));
            this.sphereAndBall2.Location = new System.Drawing.Point(12, 199);
            this.sphereAndBall2.Name = "sphereAndBall2";
            this.sphereAndBall2.Size = new System.Drawing.Size(150, 150);
            this.sphereAndBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereAndBall2.TabIndex = 10;
            this.sphereAndBall2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.sphereAndBall2);
            this.Controls.Add(this.sphereAndBall1);
            this.Controls.Add(this.userInputCalculationBtn);
            this.Controls.Add(this.volumeOutputLbl);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceAreaOutputLbl);
            this.Controls.Add(this.surfaceAreaLbl);
            this.Controls.Add(this.diameterOutputLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.userRadiusInputTxt);
            this.Controls.Add(this.radiusOfSphereLbl);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.sphereAndBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereAndBall2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusOfSphereLbl;
        private System.Windows.Forms.TextBox userRadiusInputTxt;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label diameterOutputLbl;
        private System.Windows.Forms.Label surfaceAreaLbl;
        private System.Windows.Forms.Label surfaceAreaOutputLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label volumeOutputLbl;
        private System.Windows.Forms.Button userInputCalculationBtn;
        private System.Windows.Forms.PictureBox sphereAndBall1;
        private System.Windows.Forms.PictureBox sphereAndBall2;
    }
}

