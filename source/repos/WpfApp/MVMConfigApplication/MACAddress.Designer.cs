namespace MVMConfigApplication
{
    partial class MACAddress
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
            this.MACbox = new System.Windows.Forms.GroupBox();
            this.cmd = new System.Windows.Forms.Label();
            this.macString = new System.Windows.Forms.TextBox();
            this.modMAC = new System.Windows.Forms.CheckBox();
            this.MACbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MACbox
            // 
            this.MACbox.Controls.Add(this.cmd);
            this.MACbox.Controls.Add(this.macString);
            this.MACbox.Controls.Add(this.modMAC);
            this.MACbox.Location = new System.Drawing.Point(0, 0);
            this.MACbox.Name = "MACbox";
            this.MACbox.Size = new System.Drawing.Size(200, 100);
            this.MACbox.TabIndex = 0;
            this.MACbox.TabStop = false;
            this.MACbox.Text = "MAC Address";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(46, 66);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(101, 13);
            this.cmd.TabIndex = 2;
            this.cmd.Text = "Press Enter to Save";
            // 
            // macString
            // 
            this.macString.Enabled = false;
            this.macString.Location = new System.Drawing.Point(43, 44);
            this.macString.MaxLength = 127;
            this.macString.Name = "macString";
            this.macString.Size = new System.Drawing.Size(100, 20);
            this.macString.TabIndex = 1;
            this.macString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.macString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mac_Enter);
            // 
            // modMAC
            // 
            this.modMAC.AutoSize = true;
            this.modMAC.Enabled = false;
            this.modMAC.Location = new System.Drawing.Point(149, 47);
            this.modMAC.Name = "modMAC";
            this.modMAC.Size = new System.Drawing.Size(15, 14);
            this.modMAC.TabIndex = 0;
            this.modMAC.UseVisualStyleBackColor = true;
            // 
            // MACAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MACbox);
            this.Name = "MACAddress";
            this.Size = new System.Drawing.Size(210, 110);
            this.MACbox.ResumeLayout(false);
            this.MACbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MACbox;
        private System.Windows.Forms.Label cmd;
        private System.Windows.Forms.TextBox macString;
        private System.Windows.Forms.CheckBox modMAC;
    }
}
