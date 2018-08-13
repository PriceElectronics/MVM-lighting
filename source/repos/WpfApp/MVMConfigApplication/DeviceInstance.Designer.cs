namespace MVMConfigApplication
{
    partial class DeviceInstance
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
            this.DIBox = new System.Windows.Forms.GroupBox();
            this.cmd = new System.Windows.Forms.Label();
            this.modDI = new System.Windows.Forms.CheckBox();
            this.stringDI = new System.Windows.Forms.TextBox();
            this.DIBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DIBox
            // 
            this.DIBox.Controls.Add(this.cmd);
            this.DIBox.Controls.Add(this.modDI);
            this.DIBox.Controls.Add(this.stringDI);
            this.DIBox.Location = new System.Drawing.Point(0, 0);
            this.DIBox.Name = "DIBox";
            this.DIBox.Size = new System.Drawing.Size(200, 100);
            this.DIBox.TabIndex = 0;
            this.DIBox.TabStop = false;
            this.DIBox.Text = "Device Instance";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(46, 60);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(101, 13);
            this.cmd.TabIndex = 2;
            this.cmd.Text = "Press Enter to Save";
            // 
            // modDI
            // 
            this.modDI.AutoSize = true;
            this.modDI.Enabled = false;
            this.modDI.Location = new System.Drawing.Point(149, 40);
            this.modDI.Name = "modDI";
            this.modDI.Size = new System.Drawing.Size(15, 14);
            this.modDI.TabIndex = 1;
            this.modDI.UseVisualStyleBackColor = true;
            // 
            // stringDI
            // 
            this.stringDI.Enabled = false;
            this.stringDI.Location = new System.Drawing.Point(43, 37);
            this.stringDI.Name = "stringDI";
            this.stringDI.Size = new System.Drawing.Size(100, 20);
            this.stringDI.TabIndex = 0;
            this.stringDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stringDI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DI_Enter);
            // 
            // DeviceInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DIBox);
            this.Name = "DeviceInstance";
            this.Size = new System.Drawing.Size(210, 110);
            this.DIBox.ResumeLayout(false);
            this.DIBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DIBox;
        private System.Windows.Forms.TextBox stringDI;
        private System.Windows.Forms.CheckBox modDI;
        private System.Windows.Forms.Label cmd;
    }
}
