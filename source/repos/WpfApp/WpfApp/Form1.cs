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

namespace WpfApp
{
    public partial class Form1 : Form
    {
        XmlDocument xmlFile;
        string filepath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlFile = ActionsClass.LoadXML();
            ActionsClass.displaySceneList(xmlFile);
            showProperties();
            showCommand();
            enableButton();
        }

        //Save file
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (xmlFile == null) 
            {
                label7.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    var settings = new XmlWriterSettings();
                    settings.OmitXmlDeclaration = true;
                    settings.Indent = true;
                    filepath = save.FileName;

                    XmlWriter write = XmlWriter.Create(save.FileName, settings);
                    xmlFile.Save(write);

                    write.Dispose();

                    label1.Text = "Saved";
                }
            }

            //Save file path
            label7.Text = ("Saved " + filepath);
            label8.Text = ("Saved " + filepath);
            label9.Text = ("Saved" + filepath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filepath = save.FileName;

                    XmlWriter write = XmlWriter.Create(save.FileName);
                    xmlFile.Save(write);

                    write.Dispose();

                    label2.Text = "Saved";

                }
            }

            //Save file path
            label7.Text = ("Saved " + filepath);
            label8.Text = ("Saved " + filepath);
            label9.Text = ("Saved" + filepath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filepath = save.FileName;

                    ActionsClass.saveSceneTitle(xmlFile);
                    XmlWriter write = XmlWriter.Create(save.FileName);
                    xmlFile.Save(write);

                    write.Dispose();

                    label3.Text = "Saved";
                    label4.Text = "Saved";
                    label5.Text = "Saved";
                    label6.Text = "Saved";

                }
            }

            //Save file path
            label7.Text = ("Saved " + filepath);
            label8.Text = ("Saved " + filepath);
            label9.Text = ("Saved" + filepath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (xmlFile == null)
            {
                label7.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filepath = save.FileName;

                    ActionsClass.saveSceneTitle(xmlFile);
                    XmlWriter write = XmlWriter.Create(save.FileName);
                    xmlFile.Save(write);

                    write.Dispose();

                    label1.Text = "Saved";

                }
            }
        }

        //Open file
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "XML File (*.xml)|*.xml| All Files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filepath = open.FileName;

                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                xmlFile = ActionsClass.LoadXML(open.FileName);
                ActionsClass.displaySceneList(xmlFile);

                read.Dispose();
                showProperties();
                showCommand();
                enableButton();

            }

            
        }

        private void showProperties()
        {
            //Load file path
            label7.Text = ("Loaded " + filepath);
            label8.Text = ("Loaded " + filepath);
            label9.Text = ("Loaded " + filepath);

            textBox1.Text = ActionsClass.displaybacDevice(xmlFile, "pic", "devInst");
            textBox2.Text = ActionsClass.displaybacDevice(xmlFile, "pic", "macAddr");
            textBox3.Text = ActionsClass.displaybacDevice(xmlFile, "sensor", "devInst");
            textBox4.Text = ActionsClass.displaybacDevice(xmlFile, "sensor", "macAddr");


            textBox5.Text = ActionsClass.getScene(0);
            textBox6.Text = ActionsClass.getScene(1);
            textBox7.Text = ActionsClass.getScene(2);
            textBox8.Text = ActionsClass.getScene(3);

        }

        private void showCommand()
        {
            label1.Text = "Press Enter to save";
            label2.Text = "Press Enter to save";

        }

        private void enableButton()
        {
            //Enable all the buttons if xml exists
            resetToolStripMenuItem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void textBox1_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label7.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.saveMACAddr(xmlFile, "pic", textBox1.Text, "devInst", textBox1.Text);
                    checkBox6.Checked = true;
                    label1.Text = "Modified";
                }
            }

        }

        private void textBox2_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label7.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.saveMACAddr(xmlFile, "pic", textBox1.Text, "macAddr", textBox2.Text);
                    checkBox6.Checked = true;
                    label1.Text = "Modified";
                }
            }
            
        }

        private void textBox3_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label7.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.saveMACAddr(xmlFile, "sensor", textBox3.Text, "devInst", textBox3.Text);
                    checkBox6.Checked = true;
                    label1.Text = "Modified";
                }
            }

        }

        private void textBox4_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.saveMACAddr(xmlFile, "sensor", textBox3.Text, "macAddr", textBox4.Text);
                    checkBox4.Checked = true;
                    label2.Text = "Modified";
                }
            }
        }

        private void textBox5_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.setScene(0, textBox5.Text);
                    checkBox3.Checked = true;
                    label3.Text = "Modified";

                }
            }
        }

        private void textBox6_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.setScene(1, textBox6.Text);
                    checkBox1.Checked = true;
                    label4.Text = "Modified";
                }
            }
        }

        private void textBox7_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.setScene(2, textBox7.Text);
                    checkBox2.Checked = true;
                    label5.Text = "Modified";
                }
            }
        }

        private void textBox8_Enter(object sender, KeyPressEventArgs e)
        {
            if (xmlFile == null)
            {
                label8.Text = "No file has been selected. Please select \"New\" or \"Open\" to select a file.";
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ActionsClass.setScene(3, textBox8.Text);
                    checkBox5.Checked = true;
                    label6.Text = "Modified";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "pic", "devInst");
            textBox2.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "pic", "macAddr");
            checkBox6.Checked = false;
            label1.Text = "Press Enter to Save";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "sensor", "devInst");
            textBox4.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "sensor", "macAddr");
            checkBox4.Checked = false;
            label2.Text = "Press Enter to Save";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ActionsClass.displaySceneList(ActionsClass.LoadXML());

            //Scene 1
            textBox5.Text = ActionsClass.getScene(0);
            checkBox3.Checked = false;
            label3.Text = "Press Enter to Save";

            //Scene 2
            textBox6.Text = ActionsClass.getScene(1);
            checkBox1.Checked = false;
            label4.Text = "Press Enter to Save";

            //Scene 3
            textBox7.Text = ActionsClass.getScene(2);
            checkBox2.Checked = false;
            label5.Text = "Press Enter to Save";

            //Scene 4
            textBox8.Text = ActionsClass.getScene(3);
            checkBox5.Checked = false;
            label6.Text = "Press Enter to Save";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

    }

    public class ActionsClass
    {
        public XmlDocument xmlFile = LoadXML();
        public static string[] sceneStrings = new string[4];

        public static XmlDocument LoadXML(string xmlFilePath = "C:\\Users\\joslynk\\Desktop\\C#\\readXMLApplication\\project1.xml")
        {
            XmlDocument doc = new XmlDocument();
            
            if ((File.Exists(xmlFilePath)) && (new FileInfo(xmlFilePath).Length != 0))
            {
                doc.Load(xmlFilePath);
            }

            return doc;
        }

        //output the string that contains the property value 
        public static string displaybacDevice(XmlDocument doc, string name, string property)
        {
            XmlNodeList list = doc.GetElementsByTagName("bacDevice");
            string[] properties = new string[] {"id", "devInst", "macAddr", "devName"}; //don't think i use this
            string output = "";
            int hex2int = 0;
            string bacDeviceID = "";

            for (int i = 0; i < list.Count; i++)
            {
                XmlNode node = list[i];
                String devName = node.Attributes["devName"].InnerText;

                if (node != null)
                {
                    //if devName is the same as name specified
                    if ((devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) && (property != null))
                    {
                        bacDeviceID = node.Attributes["id"].InnerText;
                        output = node.Attributes[property].InnerText;
                        if (property.CompareTo("macAddr") >= 0)
                        {
                            hex2int = Convert.ToInt32(output, 16);
                            output = hex2int.ToString();
                        }

                    }
                }
            }
            return output;
        }

        public static void displaySceneList(XmlDocument doc)
        {
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName("LvTextCtrl");
            int j = 0;

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string name = lvTextNode.Attributes["name"].InnerText;

                    while (childNode != null)
                    {
                        if (childNode.Name == "dpList")
                        {
                            XmlNode lvDataPoint = childNode.FirstChild;
                        }
                        else if ((childNode.Name == "text") && (name.Contains("Scene")))
                        {
                            sceneStrings[j] = childNode.InnerText;
                            j++;
                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }

        }

        public static void saveSceneTitle(XmlDocument doc)
        {
            int index = 0;
            XmlNodeList lvTextCtrl_list = doc.GetElementsByTagName("LvTextCtrl");

            for (int i = 0; i < lvTextCtrl_list.Count; i++)
            {
                XmlNode lvTextNode = lvTextCtrl_list[i];

                if (lvTextNode != null)
                {
                    XmlNode childNode = lvTextNode.FirstChild;
                    string name = lvTextNode.Attributes["name"].InnerText;

                    while (childNode != null)
                    {
                        if (childNode.Name == "dpList")
                        {
                            XmlNode lvDataPoint = childNode.FirstChild;
                        }
                        else if ((childNode.Name == "text") && (name.Contains("Scene")) && (index < sceneStrings.GetLength(0)))
                        {
                            childNode.InnerText = sceneStrings[index];
                            index++;

                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }
        }

        public static void saveMACAddr(XmlDocument doc, string name, string devInst, string prop, string newValue)
        {
            int int2hex = Int32.Parse(newValue);

            if (doc != null)
            {
                XmlNodeList list = doc.GetElementsByTagName("bacDevice");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNode node = list[i];
                    String devName = node.Attributes["devName"].InnerText;
                    if (devName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        switch (prop)
                        {
                            case "macAddr":
                                if (devInst.Equals(node.Attributes["devInst"].InnerText))
                                {
                                    node.Attributes[prop].InnerText = int2hex.ToString("X2");
                                }
                                break;
                            case "devInst":
                                node.Attributes[prop].InnerText = newValue;
                                break;
                            default:
                                break;
                        }
                        
                    }
                }
            }
                

        }

        public static void setScene(int index, string scene)
        {
            sceneStrings[index] = scene;
        }

        public static string getScene(int index)
        {
            return sceneStrings[index];
        }
    }
}
