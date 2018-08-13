namespace MVMConfigApplication
{
    partial class DeviceTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTab = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.macAddress = new MVMConfigApplication.MACAddress();
            this.deviceInstance = new MVMConfigApplication.DeviceInstance();
            this.cmd = new System.Windows.Forms.Label();
            this.groupBoxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTab
            // 
            this.groupBoxTab.Controls.Add(this.reset);
            this.groupBoxTab.Controls.Add(this.save);
            this.groupBoxTab.Controls.Add(this.macAddress);
            this.groupBoxTab.Controls.Add(this.deviceInstance);
            this.groupBoxTab.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTab.Name = "groupBoxTab";
            this.groupBoxTab.Size = new System.Drawing.Size(368, 405);
            this.groupBoxTab.TabIndex = 1;
            this.groupBoxTab.TabStop = false;
            this.groupBoxTab.Text = "deviceTab";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(192, 347);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(111, 25);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(41, 347);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 25);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // macAddress
            // 
            this.macAddress.Checked = false;
            this.macAddress.Location = new System.Drawing.Point(79, 194);
            this.macAddress.Name = "macAddress";
            this.macAddress.Size = new System.Drawing.Size(210, 110);
            this.macAddress.TabIndex = 5;
            this.macAddress.TextCMD = "";
            // 
            // deviceInstance
            // 
            this.deviceInstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deviceInstance.Checked = false;
            this.deviceInstance.Location = new System.Drawing.Point(79, 44);
            this.deviceInstance.Margin = new System.Windows.Forms.Padding(0);
            this.deviceInstance.Name = "deviceInstance";
            this.deviceInstance.Size = new System.Drawing.Size(206, 110);
            this.deviceInstance.TabIndex = 4;
            this.deviceInstance.TextCMD = "";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(3, 417);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(173, 13);
            this.cmd.TabIndex = 2;
            this.cmd.Text = "Click \"New\" or \"Open\" to Continue";
            // 
            // DeviceTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.groupBoxTab);
            this.Name = "DeviceTab";
            this.Size = new System.Drawing.Size(377, 440);
            this.groupBoxTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTab;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button save;
        private MACAddress macAddress;
        private DeviceInstance deviceInstance;
        private System.Windows.Forms.Label cmd;
    }
}
