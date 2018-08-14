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
    public partial class MACAddress : UserControl
    {
        public MACAddress()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return macString.Text; }
            set { macString.Text = value; }
        }

        public string TextCMD
        {
            get { return cmd.Text; }
            set { cmd.Text = value; }
        }

        //When user input different MAC
        public void mac_Enter(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                ActionsClass.saveMACAddr(ActionsClass.xmlFile, "pic", macString.Text, "devInst", macString.Text);
                cmd.Text = "Modified";
            }


        }

        //Enable value once loaded
        public void showDisplay()
        {
            macString.Enabled = true;
            cmd.Text = "Press Enter to Save";
        }
    }

    
}
