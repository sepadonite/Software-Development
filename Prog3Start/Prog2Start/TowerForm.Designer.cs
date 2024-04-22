namespace Prog3Start
{
    partial class TowerForm
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
            this.gpuGroup = new System.Windows.Forms.GroupBox();
            this.gpuPDTextBox = new System.Windows.Forms.TextBox();
            this.gpuPDLabel = new System.Windows.Forms.Label();
            this.gpuVRAMTextBox = new System.Windows.Forms.TextBox();
            this.vramLabel = new System.Windows.Forms.Label();
            this.gpuModTextBox = new System.Windows.Forms.TextBox();
            this.gpuModLabel = new System.Windows.Forms.Label();
            this.gpuManTextBox = new System.Windows.Forms.TextBox();
            this.gpuManLabel = new System.Windows.Forms.Label();
            this.mbGroup = new System.Windows.Forms.GroupBox();
            this.mbPDTextBox = new System.Windows.Forms.TextBox();
            this.mbPDLabel = new System.Windows.Forms.Label();
            this.mbSocketTextBox = new System.Windows.Forms.TextBox();
            this.mbSocketLbl = new System.Windows.Forms.Label();
            this.mbModTextBox = new System.Windows.Forms.TextBox();
            this.mbModLabel = new System.Windows.Forms.Label();
            this.mbManTextBox = new System.Windows.Forms.TextBox();
            this.mbManLabel = new System.Windows.Forms.Label();
            this.fansTextBox = new System.Windows.Forms.TextBox();
            this.fansLabel = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Label();
            this.panelComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.towerErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.cpuGroup.SuspendLayout();
            this.gpuGroup.SuspendLayout();
            this.mbGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towerErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // manuLabel
            // 
            this.manuLabel.AutoSize = true;
            this.manuLabel.Location = new System.Drawing.Point(48, 39);
            this.manuLabel.Name = "manuLabel";
            this.manuLabel.Size = new System.Drawing.Size(73, 13);
            this.manuLabel.TabIndex = 7;
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
            // gpuGroup
            // 
            this.gpuGroup.Controls.Add(this.gpuPDTextBox);
            this.gpuGroup.Controls.Add(this.gpuPDLabel);
            this.gpuGroup.Controls.Add(this.gpuVRAMTextBox);
            this.gpuGroup.Controls.Add(this.vramLabel);
            this.gpuGroup.Controls.Add(this.gpuModTextBox);
            this.gpuGroup.Controls.Add(this.gpuModLabel);
            this.gpuGroup.Controls.Add(this.gpuManTextBox);
            this.gpuGroup.Controls.Add(this.gpuManLabel);
            this.gpuGroup.Location = new System.Drawing.Point(287, 173);
            this.gpuGroup.Name = "gpuGroup";
            this.gpuGroup.Size = new System.Drawing.Size(231, 137);
            this.gpuGroup.TabIndex = 5;
            this.gpuGroup.TabStop = false;
            this.gpuGroup.Text = "GPU Information";
            // 
            // gpuPDTextBox
            // 
            this.gpuPDTextBox.Location = new System.Drawing.Point(86, 108);
            this.gpuPDTextBox.Name = "gpuPDTextBox";
            this.gpuPDTextBox.Size = new System.Drawing.Size(114, 20);
            this.gpuPDTextBox.TabIndex = 3;
            this.gpuPDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.gpuPDTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // gpuPDLabel
            // 
            this.gpuPDLabel.AutoSize = true;
            this.gpuPDLabel.Location = new System.Drawing.Point(6, 108);
            this.gpuPDLabel.Name = "gpuPDLabel";
            this.gpuPDLabel.Size = new System.Drawing.Size(68, 13);
            this.gpuPDLabel.TabIndex = 7;
            this.gpuPDLabel.Text = "Power Draw:";
            // 
            // gpuVRAMTextBox
            // 
            this.gpuVRAMTextBox.Location = new System.Drawing.Point(86, 82);
            this.gpuVRAMTextBox.Name = "gpuVRAMTextBox";
            this.gpuVRAMTextBox.Size = new System.Drawing.Size(114, 20);
            this.gpuVRAMTextBox.TabIndex = 2;
            this.gpuVRAMTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.gpuVRAMTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // vramLabel
            // 
            this.vramLabel.AutoSize = true;
            this.vramLabel.Location = new System.Drawing.Point(6, 82);
            this.vramLabel.Name = "vramLabel";
            this.vramLabel.Size = new System.Drawing.Size(41, 13);
            this.vramLabel.TabIndex = 6;
            this.vramLabel.Text = "VRAM:";
            // 
            // gpuModTextBox
            // 
            this.gpuModTextBox.Location = new System.Drawing.Point(86, 56);
            this.gpuModTextBox.Name = "gpuModTextBox";
            this.gpuModTextBox.Size = new System.Drawing.Size(114, 20);
            this.gpuModTextBox.TabIndex = 1;
            this.gpuModTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.gpuModTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // gpuModLabel
            // 
            this.gpuModLabel.AutoSize = true;
            this.gpuModLabel.Location = new System.Drawing.Point(6, 56);
            this.gpuModLabel.Name = "gpuModLabel";
            this.gpuModLabel.Size = new System.Drawing.Size(39, 13);
            this.gpuModLabel.TabIndex = 5;
            this.gpuModLabel.Text = "Model:";
            // 
            // gpuManTextBox
            // 
            this.gpuManTextBox.Location = new System.Drawing.Point(86, 30);
            this.gpuManTextBox.Name = "gpuManTextBox";
            this.gpuManTextBox.Size = new System.Drawing.Size(114, 20);
            this.gpuManTextBox.TabIndex = 0;
            this.gpuManTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.gpuManTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // gpuManLabel
            // 
            this.gpuManLabel.AutoSize = true;
            this.gpuManLabel.Location = new System.Drawing.Point(6, 30);
            this.gpuManLabel.Name = "gpuManLabel";
            this.gpuManLabel.Size = new System.Drawing.Size(73, 13);
            this.gpuManLabel.TabIndex = 4;
            this.gpuManLabel.Text = "Manufacturer:";
            // 
            // mbGroup
            // 
            this.mbGroup.Controls.Add(this.mbPDTextBox);
            this.mbGroup.Controls.Add(this.mbPDLabel);
            this.mbGroup.Controls.Add(this.mbSocketTextBox);
            this.mbGroup.Controls.Add(this.mbSocketLbl);
            this.mbGroup.Controls.Add(this.mbModTextBox);
            this.mbGroup.Controls.Add(this.mbModLabel);
            this.mbGroup.Controls.Add(this.mbManTextBox);
            this.mbGroup.Controls.Add(this.mbManLabel);
            this.mbGroup.Location = new System.Drawing.Point(287, 28);
            this.mbGroup.Name = "mbGroup";
            this.mbGroup.Size = new System.Drawing.Size(231, 139);
            this.mbGroup.TabIndex = 4;
            this.mbGroup.TabStop = false;
            this.mbGroup.Text = "Motherboard Information";
            // 
            // mbPDTextBox
            // 
            this.mbPDTextBox.Location = new System.Drawing.Point(86, 108);
            this.mbPDTextBox.Name = "mbPDTextBox";
            this.mbPDTextBox.Size = new System.Drawing.Size(114, 20);
            this.mbPDTextBox.TabIndex = 3;
            // 
            // mbPDLabel
            // 
            this.mbPDLabel.AutoSize = true;
            this.mbPDLabel.Location = new System.Drawing.Point(6, 108);
            this.mbPDLabel.Name = "mbPDLabel";
            this.mbPDLabel.Size = new System.Drawing.Size(68, 13);
            this.mbPDLabel.TabIndex = 7;
            this.mbPDLabel.Text = "Power Draw:";
            // 
            // mbSocketTextBox
            // 
            this.mbSocketTextBox.Location = new System.Drawing.Point(86, 82);
            this.mbSocketTextBox.Name = "mbSocketTextBox";
            this.mbSocketTextBox.Size = new System.Drawing.Size(114, 20);
            this.mbSocketTextBox.TabIndex = 2;
            this.mbSocketTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.mbSocketTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // mbSocketLbl
            // 
            this.mbSocketLbl.AutoSize = true;
            this.mbSocketLbl.Location = new System.Drawing.Point(6, 82);
            this.mbSocketLbl.Name = "mbSocketLbl";
            this.mbSocketLbl.Size = new System.Drawing.Size(47, 13);
            this.mbSocketLbl.TabIndex = 6;
            this.mbSocketLbl.Text = "Socket: ";
            // 
            // mbModTextBox
            // 
            this.mbModTextBox.Location = new System.Drawing.Point(86, 56);
            this.mbModTextBox.Name = "mbModTextBox";
            this.mbModTextBox.Size = new System.Drawing.Size(114, 20);
            this.mbModTextBox.TabIndex = 1;
            this.mbModTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.mbModTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // mbModLabel
            // 
            this.mbModLabel.AutoSize = true;
            this.mbModLabel.Location = new System.Drawing.Point(6, 56);
            this.mbModLabel.Name = "mbModLabel";
            this.mbModLabel.Size = new System.Drawing.Size(39, 13);
            this.mbModLabel.TabIndex = 5;
            this.mbModLabel.Text = "Model:";
            // 
            // mbManTextBox
            // 
            this.mbManTextBox.Location = new System.Drawing.Point(86, 30);
            this.mbManTextBox.Name = "mbManTextBox";
            this.mbManTextBox.Size = new System.Drawing.Size(114, 20);
            this.mbManTextBox.TabIndex = 0;
            this.mbManTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.text_Validating);
            this.mbManTextBox.Validated += new System.EventHandler(this.text_Validated);
            // 
            // mbManLabel
            // 
            this.mbManLabel.AutoSize = true;
            this.mbManLabel.Location = new System.Drawing.Point(6, 30);
            this.mbManLabel.Name = "mbManLabel";
            this.mbManLabel.Size = new System.Drawing.Size(73, 13);
            this.mbManLabel.TabIndex = 4;
            this.mbManLabel.Text = "Manufacturer:";
            // 
            // fansTextBox
            // 
            this.fansTextBox.Location = new System.Drawing.Point(128, 65);
            this.fansTextBox.Name = "fansTextBox";
            this.fansTextBox.Size = new System.Drawing.Size(114, 20);
            this.fansTextBox.TabIndex = 1;
            this.fansTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            this.fansTextBox.Validated += new System.EventHandler(this.int_Validated);
            // 
            // fansLabel
            // 
            this.fansLabel.AutoSize = true;
            this.fansLabel.Location = new System.Drawing.Point(36, 65);
            this.fansLabel.Name = "fansLabel";
            this.fansLabel.Size = new System.Drawing.Size(85, 13);
            this.fansLabel.TabIndex = 8;
            this.fansLabel.Text = "Number of Fans:";
            // 
            // panelLabel
            // 
            this.panelLabel.AutoSize = true;
            this.panelLabel.Location = new System.Drawing.Point(48, 91);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(61, 13);
            this.panelLabel.TabIndex = 9;
            this.panelLabel.Text = "Panel Type";
            // 
            // panelComboBox
            // 
            this.panelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelComboBox.FormattingEnabled = true;
            this.panelComboBox.Items.AddRange(new object[] {
            "glass",
            "metal"});
            this.panelComboBox.Location = new System.Drawing.Point(128, 92);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(114, 21);
            this.panelComboBox.TabIndex = 2;
            this.panelComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            this.panelComboBox.Validated += new System.EventHandler(this.comboBox_Validated);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(233, 326);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // towerErrorProv
            // 
            this.towerErrorProv.ContainerControl = this;
            // 
            // TowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 371);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panelComboBox);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.fansTextBox);
            this.Controls.Add(this.fansLabel);
            this.Controls.Add(this.mbGroup);
            this.Controls.Add(this.gpuGroup);
            this.Controls.Add(this.cpuGroup);
            this.Controls.Add(this.manuTextBox);
            this.Controls.Add(this.manuLabel);
            this.Name = "TowerForm";
            this.Text = "Create Tower";
            this.cpuGroup.ResumeLayout(false);
            this.cpuGroup.PerformLayout();
            this.gpuGroup.ResumeLayout(false);
            this.gpuGroup.PerformLayout();
            this.mbGroup.ResumeLayout(false);
            this.mbGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towerErrorProv)).EndInit();
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
        private System.Windows.Forms.GroupBox gpuGroup;
        private System.Windows.Forms.TextBox gpuPDTextBox;
        private System.Windows.Forms.Label gpuPDLabel;
        private System.Windows.Forms.TextBox gpuVRAMTextBox;
        private System.Windows.Forms.Label vramLabel;
        private System.Windows.Forms.TextBox gpuModTextBox;
        private System.Windows.Forms.Label gpuModLabel;
        private System.Windows.Forms.TextBox gpuManTextBox;
        private System.Windows.Forms.Label gpuManLabel;
        private System.Windows.Forms.GroupBox mbGroup;
        private System.Windows.Forms.TextBox mbPDTextBox;
        private System.Windows.Forms.Label mbPDLabel;
        private System.Windows.Forms.TextBox mbSocketTextBox;
        private System.Windows.Forms.Label mbSocketLbl;
        private System.Windows.Forms.TextBox mbModTextBox;
        private System.Windows.Forms.Label mbModLabel;
        private System.Windows.Forms.TextBox mbManTextBox;
        private System.Windows.Forms.Label mbManLabel;
        private System.Windows.Forms.TextBox fansTextBox;
        private System.Windows.Forms.Label fansLabel;
        private System.Windows.Forms.Label panelLabel;
        private System.Windows.Forms.ComboBox panelComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ErrorProvider towerErrorProv;
    }
}