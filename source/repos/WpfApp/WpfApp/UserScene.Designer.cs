namespace WpfApp
{
    partial class UserScene
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
            this.scene = new System.Windows.Forms.GroupBox();
            this.cmd = new System.Windows.Forms.Label();
            this.modScene = new System.Windows.Forms.CheckBox();
            this.stringScene = new System.Windows.Forms.TextBox();
            this.scene.SuspendLayout();
            this.SuspendLayout();
            // 
            // scene
            // 
            this.scene.Controls.Add(this.cmd);
            this.scene.Controls.Add(this.modScene);
            this.scene.Controls.Add(this.stringScene);
            this.scene.Location = new System.Drawing.Point(3, 3);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(157, 64);
            this.scene.TabIndex = 0;
            this.scene.TabStop = false;
            this.scene.Text = "User Scene ";
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(24, 42);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(0, 13);
            this.cmd.TabIndex = 2;
            // 
            // modScene
            // 
            this.modScene.AutoSize = true;
            this.modScene.Enabled = false;
            this.modScene.Location = new System.Drawing.Point(131, 22);
            this.modScene.Name = "modScene";
            this.modScene.Size = new System.Drawing.Size(15, 14);
            this.modScene.TabIndex = 1;
            this.modScene.UseVisualStyleBackColor = true;
            // 
            // stringScene
            // 
            this.stringScene.Enabled = false;
            this.stringScene.Location = new System.Drawing.Point(25, 19);
            this.stringScene.Name = "stringScene";
            this.stringScene.Size = new System.Drawing.Size(100, 20);
            this.stringScene.TabIndex = 0;
            this.stringScene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stringScene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Scene_Enter);
            // 
            // UserScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scene);
            this.Name = "UserScene";
            this.Size = new System.Drawing.Size(167, 74);
            this.scene.ResumeLayout(false);
            this.scene.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox scene;
        private System.Windows.Forms.TextBox stringScene;
        private System.Windows.Forms.CheckBox modScene;
        private System.Windows.Forms.Label cmd;
    }
}
