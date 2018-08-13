using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MVMConfigApplication
{
    public partial class UserScenes : UserControl
    {
        string filepath = "";

        public UserScenes()
        {
            InitializeComponent();
        }

        public string sceneTabText
        {
            get { return groupBoxTab.Text; }
            set { groupBoxTab.Text = value; }
        }

        public string cmdLine
        {
            get { return cmd.Text; }
            set { cmd.Text = value; }
        }

        //User Scene 1 
        public string user_scene_1
        {
            get { return userScene1.Text; }
            set { userScene1.Text = value; }
        }

        public bool scene1_Checked
        {
            get { return userScene1.Checked; }
            set { userScene1.Checked = value; }
        }

        public string scene1_cmd
        {
            get { return userScene1.TextCMD; }
            set { userScene1.TextCMD = value; }
        }

        //User Scene 2 
        public string user_scene_2
        {
            get { return userScene2.Text; }
            set { userScene2.Text = value; }
        }

        public bool scene2_Checked
        {
            get { return userScene2.Checked; }
            set { userScene2.Checked = value; }
        }

        public string scene2_cmd
        {
            get { return userScene2.TextCMD; }
            set { userScene2.TextCMD = value; }
        }

        //User Scene 3 
        public string user_scene_3
        {
            get { return userScene3.Text; }
            set { userScene3.Text = value; }
        }

        public bool scene3_Checked
        {
            get { return userScene3.Checked; }
            set { userScene3.Checked = value; }
        }

        public string scene3_cmd
        {
            get { return userScene3.TextCMD; }
            set { userScene3.TextCMD = value; }
        }

        //User Scene 4
        public string user_scene_4
        {
            get { return userScene4.Text; }
            set { userScene4.Text = value; }
        }

        public bool scene4_Checked
        {
            get { return userScene4.Checked; }
            set { userScene4.Checked = value; }
        }

        public string scene4_cmd
        {
            get { return userScene4.TextCMD; }
            set { userScene4.TextCMD = value; }
        }

        //Save
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (ActionsClass.xmlFile == null)
            {
                cmd.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    var settings = new XmlWriterSettings();
                    settings.OmitXmlDeclaration = true;
                    settings.Indent = true;
                    filepath = save.FileName;

                    ActionsClass.saveSceneTitle(ActionsClass.getXmlDocument());
                    XmlWriter write = XmlWriter.Create(save.FileName, settings);
                    ActionsClass.getXmlDocument().Save(write);

                    write.Dispose();

                    userScene1.TextCMD = "Saved";
                    userScene2.TextCMD = "Saved";
                    userScene3.TextCMD = "Saved";
                    userScene4.TextCMD = "Saved";

                    userScene1.Checked = true;
                    userScene2.Checked = true;
                    userScene3.Checked = true;
                    userScene4.Checked = true;

                }
            }
        }

        //Reset
        private void reset_Click(object sender, EventArgs e)
        {
            save.Enabled = true;
            reset.Enabled = true;

            userScene1.Checked = false;
            userScene2.Checked = false;
            userScene3.Checked = false;
            userScene4.Checked = false;

            showDefaultProperties();

        }

        public void showDefaultProperties()
        {
            userScene1.getdefaultScene(0);
            userScene2.getdefaultScene(1);
            userScene3.getdefaultScene(2);
            userScene4.getdefaultScene(3);
        }

        public void showProperties()
        {
            userScene1.getScene(0);
            userScene2.getScene(1);
            userScene3.getScene(2);
            userScene4.getScene(3);
        }

        public void showDisplay()
        {
            save.Enabled = true;
            reset.Enabled = true;

            userScene1.showDisplay();
            userScene2.showDisplay();
            userScene3.showDisplay();
            userScene4.showDisplay();
        }

    }
}
