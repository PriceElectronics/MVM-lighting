namespace MVMConfigApplication
{
    partial class MVMConfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MVMConfigurator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deviceTab = new MVMConfigApplication.DeviceTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deviceTab2 = new MVMConfigApplication.DeviceTab();
            this.sceneTab = new System.Windows.Forms.TabPage();
            this.userScenes = new MVMConfigApplication.UserScenes();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.sceneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Enabled = false;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.resetToolStripMenuItem.Text = "Reset All";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.sceneTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 487);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deviceTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MVM Gateway";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deviceTab
            // 
            this.deviceTab.cmdLine = "Click \"New\" or \"Open\" to Continue";
            this.deviceTab.deviceTabText = this.tabPage1.Text;
            this.deviceTab.DI = "";
            this.deviceTab.DIcmd = "";
            this.deviceTab.Location = new System.Drawing.Point(28, 15);
            this.deviceTab.MAC = "";
            this.deviceTab.MACcmd = "";
            this.deviceTab.Name = "deviceTab";
            this.deviceTab.Size = new System.Drawing.Size(377, 440);
            this.deviceTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deviceTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sensor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deviceTab2
            // 
            this.deviceTab2.cmdLine = "Click \"New\" or \"Open\" to Continue";
            this.deviceTab2.deviceTabText = this.tabPage2.Text;
            this.deviceTab2.DI = "";
            this.deviceTab2.DIcmd = "";
            this.deviceTab2.Location = new System.Drawing.Point(28, 15);
            this.deviceTab2.MAC = "";
            this.deviceTab2.MACcmd = "";
            this.deviceTab2.Name = "deviceTab2";
            this.deviceTab2.Size = new System.Drawing.Size(377, 440);
            this.deviceTab2.TabIndex = 2;
            // 
            // sceneTab
            // 
            this.sceneTab.Controls.Add(this.userScenes);
            this.sceneTab.Location = new System.Drawing.Point(4, 22);
            this.sceneTab.Name = "sceneTab";
            this.sceneTab.Padding = new System.Windows.Forms.Padding(3);
            this.sceneTab.Size = new System.Drawing.Size(432, 461);
            this.sceneTab.TabIndex = 2;
            this.sceneTab.Text = "User Scene";
            this.sceneTab.UseVisualStyleBackColor = true;
            // 
            // userScenes
            // 
            this.userScenes.cmdLine = "Click \"New\" or \"Open\" to Continue";
            this.userScenes.Location = new System.Drawing.Point(23, 15);
            this.userScenes.Name = "userScenes";
            this.userScenes.scene1_cmd = "";
            this.userScenes.scene2_cmd = "";
            this.userScenes.scene3_cmd = "";
            this.userScenes.scene4_cmd = "";
            this.userScenes.sceneTabText = "deviceTab";
            this.userScenes.Size = new System.Drawing.Size(377, 440);
            this.userScenes.TabIndex = 0;
            this.userScenes.user_scene_1 = "";
            this.userScenes.user_scene_2 = "";
            this.userScenes.user_scene_3 = "";
            this.userScenes.user_scene_4 = "";
            this.userScenes.sceneTabText = this.sceneTab.Text;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MVMConfigApplication.MVMConfigurator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MVM Configurator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.sceneTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DeviceTab deviceTab;
        private DeviceTab deviceTab2;
        private System.Windows.Forms.TabPage sceneTab;
        private UserScenes userScenes;
    }
}

