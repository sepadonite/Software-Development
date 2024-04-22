namespace Prog3Start
{
    partial class LaptopForm
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
            this.components = new System.ComponentModel.Container();
            this.manuLabel = new System.Windows.Forms.Label();
            this.manuTextBox = new System.Windows.Forms.TextBox();
            this.cpuGroup = new System.Windows.Forms.GroupBox();
            this.cpuPDTextBox = new System.Windows.Forms.TextBox();
            this.cpuPDLabel = new System.Windows.Forms.Label();
            this.cpuSocTextBox = new System.Windows.Forms.TextBox();
            this.cpuSocketLabel = new System.Windows.Forms.Label();
            this.cpuClockTextBox = new System.Windows.Forms.TextBox();
            this.cpuCLabel = new System.Windows.Forms.Label();
            this.cpuModTextBox = new System.Windows.Forms.TextBox();
            this.cpuModLabel = new System.Windows.Forms.Label();
            this.cpuMText = new System.Windows.Forms.TextBox();
            this.cpuMLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.laptopErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.modTextBox = new System.Windows.Forms.TextBox();
            this.modLabel = new System.Windows.Forms.Label();
            this.fixTDPTextBox = new System.Windows.Forms.TextBox();
            this.tdpLabel = new System.Windows.Forms.Label();
            this.cpuGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laptopErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // manuLabel
            // 
            this.manuLabel.AutoSize = true;
            this.manuLabel.Location = new System.Drawing.Point(48, 39);
            this.manuLabel.Name = "manuLabel";
            this.manuLabel.Size = new System.Drawing.Size(73, 13);
            this.manuLabel.TabIndex = 5;
            this.manuLabel.Text = "Manufacturer:";
            // 
            // manuTextBox
            // 
            this.manuTextBox.Location = new System.Drawing.Point(128, 39);
            this.manuTextBox.Name = "manuTextBox";
            this.manuTextBox.Size = new System.Drawing.Size(114, 20);
            this.manuTextBox.TabIndex = 0;
            this.manuTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.manuTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // cpuGroup
            // 
            this.cpuGroup.Controls.Add(this.cpuPDTextBox);
            this.cpuGroup.Controls.Add(this.cpuPDLabel);
            this.cpuGroup.Controls.Add(this.cpuSocTextBox);
            this.cpuGroup.Controls.Add(this.cpuSocketLabel);
            this.cpuGroup.Controls.Add(this.cpuClockTextBox);
            this.cpuGroup.Controls.Add(this.cpuCLabel);
            this.cpuGroup.Controls.Add(this.cpuModTextBox);
            this.cpuGroup.Controls.Add(this.cpuModLabel);
            this.cpuGroup.Controls.Add(this.cpuMText);
            this.cpuGroup.Controls.Add(this.cpuMLabel);
            this.cpuGroup.Location = new System.Drawing.Point(26, 138);
            this.cpuGroup.Name = "cpuGroup";
            this.cpuGroup.Size = new System.Drawing.Size(231, 172);
            this.cpuGroup.TabIndex = 3;
            this.cpuGroup.TabStop = false;
            this.cpuGroup.Text = "CPU Information";
            // 
            // cpuPDTextBox
            // 
            this.cpuPDTextBox.Location = new System.Drawing.Point(86, 134);
            this.cpuPDTextBox.Name = "cpuPDTextBox";
            this.cpuPDTextBox.Size = new System.Drawing.Size(114, 20);
            this.cpuPDTextBox.TabIndex = 4;
            this.cpuPDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.cpuPDTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // cpuPDLabel
            // 
            this.cpuPDLabel.AutoSize = true;
            this.cpuPDLabel.Location = new System.Drawing.Point(6, 134);
            this.cpuPDLabel.Name = "cpuPDLabel";
            this.cpuPDLabel.Size = new System.Drawing.Size(68, 13);
            this.cpuPDLabel.TabIndex = 9;
            this.cpuPDLabel.Text = "Power Draw:";
            // 
            // cpuSocTextBox
            // 
            this.cpuSocTextBox.Location = new System.Drawing.Point(86, 108);
            this.cpuSocTextBox.Name = "cpuSocTextBox";
            this.cpuSocTextBox.Size = new System.Drawing.Size(114, 20);
            this.cpuSocTextBox.TabIndex = 3;
            this.cpuSocTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.cpuSocTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // cpuSocketLabel
            // 
            this.cpuSocketLabel.AutoSize = true;
            this.cpuSocketLabel.Location = new System.Drawing.Point(6, 108);
            this.cpuSocketLabel.Name = "cpuSocketLabel";
            this.cpuSocketLabel.Size = new System.Drawing.Size(47, 13);
            this.cpuSocketLabel.TabIndex = 8;
            this.cpuSocketLabel.Text = "Socket: ";
            // 
            // cpuClockTextBox
            // 
            this.cpuClockTextBox.Location = new System.Drawing.Point(86, 82);
            this.cpuClockTextBox.Name = "cpuClockTextBox";
            this.cpuClockTextBox.Size = new System.Drawing.Size(114, 20);
            this.cpuClockTextBox.TabIndex = 2;
            this.cpuClockTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.cpuClockTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // cpuCLabel
            // 
            this.cpuCLabel.AutoSize = true;
            this.cpuCLabel.Location = new System.Drawing.Point(6, 82);
            this.cpuCLabel.Name = "cpuCLabel";
            this.cpuCLabel.Size = new System.Drawing.Size(71, 13);
            this.cpuCLabel.TabIndex = 7;
            this.cpuCLabel.Text = "Clock Speed:";
            // 
            // cpuModTextBox
            // 
            this.cpuModTextBox.Location = new System.Drawing.Point(86, 56);
            this.cpuModTextBox.Name = "cpuModTextBox";
            this.cpuModTextBox.Size = new System.Drawing.Size(114, 20);
            this.cpuModTextBox.TabIndex = 1;
            this.cpuModTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.cpuModTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // cpuModLabel
            // 
            this.cpuModLabel.AutoSize = true;
            this.cpuModLabel.Location = new System.Drawing.Point(6, 56);
            this.cpuModLabel.Name = "cpuModLabel";
            this.cpuModLabel.Size = new System.Drawing.Size(39, 13);
            this.cpuModLabel.TabIndex = 6;
            this.cpuModLabel.Text = "Model:";
            // 
            // cpuMText
            // 
            this.cpuMText.Location = new System.Drawing.Point(86, 30);
            this.cpuMText.Name = "cpuMText";
            this.cpuMText.Size = new System.Drawing.Size(114, 20);
            this.cpuMText.TabIndex = 0;
            this.cpuMText.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.cpuMText.Validated += new System.EventHandler(this.text_Validated);
            // 
            // cpuMLabel
            // 
            this.cpuMLabel.AutoSize = true;
            this.cpuMLabel.Location = new System.Drawing.Point(6, 30);
            this.cpuMLabel.Name = "cpuMLabel";
            this.cpuMLabel.Size = new System.Drawing.Size(73, 13);
            this.cpuMLabel.TabIndex = 5;
            this.cpuMLabel.Text = "Manufacturer:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(100, 327);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // laptopErrorProv
            // 
            this.laptopErrorProv.ContainerControl = this;
            // 
            // modTextBox
            // 
            this.modTextBox.Location = new System.Drawing.Point(128, 65);
            this.modTextBox.Name = "modTextBox";
            this.modTextBox.Size = new System.Drawing.Size(114, 20);
            this.modTextBox.TabIndex = 1;
            this.modTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.modTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Location = new System.Drawing.Point(48, 65);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(39, 13);
            this.modLabel.TabIndex = 6;
            this.modLabel.Text = "Model:";
            // 
            // fixTDPTextBox
            // 
            this.fixTDPTextBox.Location = new System.Drawing.Point(128, 91);
            this.fixTDPTextBox.Name = "fixTDPTextBox";
            this.fixTDPTextBox.Size = new System.Drawing.Size(114, 20);
            this.fixTDPTextBox.TabIndex = 2;
            this.fixTDPTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.fixTDPTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // tdpLabel
            // 
            this.tdpLabel.AutoSize = true;
            this.tdpLabel.Location = new System.Drawing.Point(48, 91);
            this.tdpLabel.Name = "tdpLabel";
            this.tdpLabel.Size = new System.Drawing.Size(60, 13);
            this.tdpLabel.TabIndex = 7;
            this.tdpLabel.Text = "Fixed TDP:";
            // 
            // LaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 371);
            this.Controls.Add(this.fixTDPTextBox);
            this.Controls.Add(this.tdpLabel);
            this.Controls.Add(this.modTextBox);
            this.Controls.Add(this.modLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cpuGroup);
            this.Controls.Add(this.manuTextBox);
            this.Controls.Add(this.manuLabel);
            this.Name = "LaptopForm";
            this.Text = "Create Laptop";
            this.cpuGroup.ResumeLayout(false);
            this.cpuGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laptopErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manuLabel;
        private System.Windows.Forms.TextBox manuTextBox;
        private System.Windows.Forms.GroupBox cpuGroup;
        private System.Windows.Forms.TextBox cpuMText;
        private System.Windows.Forms.Label cpuMLabel;
        private System.Windows.Forms.TextBox cpuModTextBox;
        private System.Windows.Forms.Label cpuModLabel;
        private System.Windows.Forms.TextBox cpuPDTextBox;
        private System.Windows.Forms.Label cpuPDLabel;
        private System.Windows.Forms.TextBox cpuSocTextBox;
        private System.Windows.Forms.Label cpuSocketLabel;
        private System.Windows.Forms.TextBox cpuClockTextBox;
        private System.Windows.Forms.Label cpuCLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ErrorProvider laptopErrorProv;
        private System.Windows.Forms.TextBox fixTDPTextBox;
        private System.Windows.Forms.Label tdpLabel;
        private System.Windows.Forms.TextBox modTextBox;
        private System.Windows.Forms.Label modLabel;
    }
}