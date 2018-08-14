namespace MVMConfigApplication
{
    partial class UserScenes
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
            this.cmd = new System.Windows.Forms.Label();
            this.userScene4 = new MVMConfigApplication.UserScene();
            this.userScene3 = new MVMConfigApplication.UserScene();
            this.userScene2 = new MVMConfigApplication.UserScene();
            this.userScene1 = new MVMConfigApplication.UserScene();
            this.groupBoxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTab
            // 
            this.groupBoxTab.Controls.Add(this.userScene4);
            this.groupBoxTab.Controls.Add(this.userScene3);
            this.groupBoxTab.Controls.Add(this.userScene2);
            this.groupBoxTab.Controls.Add(this.userScene1);
            this.groupBoxTab.Controls.Add(this.reset);
            this.groupBoxTab.Controls.Add(this.save);
            this.groupBoxTab.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTab.Name = "groupBoxTab";
            this.groupBoxTab.Size = new System.Drawing.Size(368, 405);
            this.groupBoxTab.TabIndex = 2;
            this.groupBoxTab.TabStop = false;
            this.groupBoxTab.Text = "User Scene";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(192, 323);
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
            this.save.Location = new System.Drawing.Point(62, 323);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 25);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(3, 417);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(173, 13);
            this.cmd.TabIndex = 3;
            this.cmd.Text = "Click \"New\" or \"Open\" to Continue";
            // 
            // userScene4
            // 
            this.userScene4.Location = new System.Drawing.Point(192, 197);
            this.userScene4.Name = "userScene4";
            this.userScene4.Size = new System.Drawing.Size(167, 74);
            this.userScene4.TabIndex = 11;
            this.userScene4.TextCMD = "";
            this.userScene4.boxText = "User Scene 4";
            this.userScene4.index = 3;
            // 
            // userScene3
            // 
            this.userScene3.Location = new System.Drawing.Point(6, 197);
            this.userScene3.Name = "userScene3";
            this.userScene3.Size = new System.Drawing.Size(167, 74);
            this.userScene3.TabIndex = 10;
            this.userScene3.TextCMD = "";
            this.userScene3.boxText = "User Scene 3";
            this.userScene3.index = 2;
            // 
            // userScene2
            // 
            this.userScene2.Location = new System.Drawing.Point(192, 76);
            this.userScene2.Name = "userScene2";
            this.userScene2.Size = new System.Drawing.Size(167, 74);
            this.userScene2.TabIndex = 9;
            this.userScene2.TextCMD = "";
            this.userScene2.boxText = "User Scene 2";
            this.userScene2.index = 1;
            // 
            // userScene1
            // 
            this.userScene1.Location = new System.Drawing.Point(6, 76);
            this.userScene1.Name = "userScene1";
            this.userScene1.Size = new System.Drawing.Size(167, 74);
            this.userScene1.TabIndex = 8;
            this.userScene1.TextCMD = "";
            this.userScene1.boxText = "User Scene 1";
            this.userScene1.index = 0;
            // 
            // UserScenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.groupBoxTab);
            this.Name = "UserScenes";
            this.Size = new System.Drawing.Size(377, 440);
            this.groupBoxTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTab;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label cmd;
        private UserScene userScene1;
        private UserScene userScene2;
        private UserScene userScene3;
        private UserScene userScene4;
    }
}
