using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MVMConfigApplication
{
    public partial class MVMConfigurator : Form
    {
        XmlDocument xmlFile;
        string filepath = "";

        public MVMConfigurator()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlFile = ActionsClass.loadDefaultXML();
            show();

            //Load file path
            deviceTab.showDefaultProperties();
            deviceTab2.showDefaultProperties();
            userScenes.showDefaultProperties();
        }

        //Open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filepath = open.FileName;

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                xmlFile = ActionsClass.LoadXML(open.FileName);

                show();

                deviceTab.showProperties(xmlFile);
                deviceTab2.showProperties(xmlFile);
                userScenes.showProperties();

                read.Dispose();
            }

            
        }
        
        private void show()
        {
            ActionsClass.findDeviceConnected(xmlFile);
            ActionsClass.displaySceneList(xmlFile);
            ActionsClass.setXmlDocument(xmlFile);
            showDisplay();
        }

        private void showDisplay()
        {
            //Load file path
            deviceTab.cmdLine = ("Loaded " + filepath);
            deviceTab2.cmdLine = ("Loaded " + filepath);
            userScenes.cmdLine = ("Loaded " + filepath);

            deviceTab.showDisplay();
            deviceTab2.showDisplay();
            userScenes.showDisplay();

            resetToolStripMenuItem.Enabled = true;
            
        }
        
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

    }

    
}
