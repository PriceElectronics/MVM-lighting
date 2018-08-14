using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVMConfigApplication
{
    public partial class DeviceInstance : UserControl
    {
        public DeviceInstance()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return stringDI.Text; }
            set { stringDI.Text = value; }
        }

        public string TextCMD
        {
            get { return cmd.Text; }
            set { cmd.Text = value; }
        }

        //When user input different DI
        public void DI_Enter(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActionsClass.saveMACAddr(ActionsClass.xmlFile, "pic", stringDI.Text, "devInst", stringDI.Text);
                cmd.Text = "Modified";
            }
            
        }

        public void showDisplay()
        {
            stringDI.Enabled = true;
            cmd.Text = "Press Enter to Save";
        }

    }

}
