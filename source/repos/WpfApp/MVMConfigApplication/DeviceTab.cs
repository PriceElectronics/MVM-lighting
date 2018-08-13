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
    public partial class DeviceTab : UserControl
    {
        string filepath = "";
        public DeviceTab()
        {
            InitializeComponent();
            
        }

        public string deviceTabText
        {
            get { return groupBoxTab.Text; }
            set { groupBoxTab.Text = value; }
        }

        //Device Instance 
        public string DI
        {
            get { return deviceInstance.Text; }
            set { deviceInstance.Text = value; }
        }

        public bool DIChecked
        {
            get { return deviceInstance.Checked; }
            set { deviceInstance.Checked = value; }
        }

        public string DIcmd
        {
            get { return deviceInstance.TextCMD; }
            set { deviceInstance.TextCMD = value; }

        }

        //MAC Address
        public string MAC
        {
            get { return macAddress.Text; }
            set { macAddress.Text = value; }
        }

        public bool MACChecked
        {
            get { return deviceInstance.Checked; }
            set { deviceInstance.Checked = value; }
        }

        public string MACcmd
        {
            get { return deviceInstance.TextCMD; }
            set { deviceInstance.TextCMD = value; }

        }

        //Tab Command Line
        public string cmdLine
        {
            get { return cmd.Text; }
            set { cmd.Text = value; }
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

                    XmlWriter write = XmlWriter.Create(save.FileName, settings);
                    ActionsClass.getXmlDocument().Save(write);

                    write.Dispose();

                    macAddress.TextCMD = "Saved";
                    macAddress.Checked = true;

                    deviceInstance.TextCMD = "Saved";
                    deviceInstance.Checked = true;

                    
                }
            }
        }

        //Reset
        private void reset_Click(object sender, EventArgs e)
        {
            showDefaultProperties();
            showDisplay();

            deviceInstance.Checked = false;
            macAddress.Checked = false;

            deviceInstance.TextCMD = "Press Enter to Save";
            macAddress.TextCMD = "Press Enter to Save";
        }

        public void showDefaultProperties()
        {
            if (groupBoxTab.Text.Equals("MVM Gateway"))
            {
                deviceInstance.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "pic", "devInst");
                macAddress.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "pic", "macAddr");
            }
            else if (groupBoxTab.Text.IndexOf("Sensor", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                deviceInstance.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "sensor", "devInst");
                macAddress.Text = ActionsClass.displaybacDevice(ActionsClass.LoadXML(), "sensor", "macAddr");
            }
        }

        public void showProperties(XmlDocument doc)
        {
            if (groupBoxTab.Text.Equals("MVM Gateway"))
            {
                deviceInstance.Text = ActionsClass.displaybacDevice(doc, "pic", "devInst");
                macAddress.Text = ActionsClass.displaybacDevice(doc, "pic", "macAddr");
            }
            else if (groupBoxTab.Text.IndexOf("Sensor", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                deviceInstance.Text = ActionsClass.displaybacDevice(doc, "sensor", "devInst");
                macAddress.Text = ActionsClass.displaybacDevice(doc, "sensor", "macAddr");
            }
        }

        public void showDisplay()
        {
            save.Enabled = true;
            reset.Enabled = true;

            macAddress.showDisplay();
            deviceInstance.showDisplay();

        }

    }

    
}
