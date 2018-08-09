using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp
{
    public partial class UserScene : UserControl
    {
        int sceneNumber = 0;
        public UserScene()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return stringScene.Text; }
            set { stringScene.Text = value; }
        }

        public bool Checked
        {
            get { return modScene.Checked; }
            set { modScene.Checked = value; }
        }

        public string TextCMD
        {
            get { return cmd.Text; }
            set { cmd.Text = value; }
        }

        public string boxText
        {
            get { return scene.Text; }
            set { scene.Text = value; }
        }

        public int index
        {
            get { return sceneNumber; }
            set { sceneNumber = value; }
        }

        //When user input different DI
        private void Scene_Enter(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                ActionsClass.setScene(sceneNumber, stringScene.Text);
                modScene.Checked = true;
                cmd.Text = "Modified";
            }
        }

        public void showDisplay()
        {
            stringScene.Enabled = true;
            cmd.Text = "Press Enter to Save";
        }

        public void getScene(int index)
        {
            stringScene.Text = ActionsClass.getScene(index);
            cmd.Text = "Press Enter to Save";
        }
        
        public void getdefaultScene(int index)
        {
            stringScene.Text = ActionsClass.getdefaultScene(index);
            cmd.Text = "Press Enter to Save";
        }
    }
}
