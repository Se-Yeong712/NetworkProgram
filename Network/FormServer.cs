using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Network
{
    public partial class FormServer : Form
    {

        String ip = "";
        String port = "5000";
        String name = "";
        String message = "";
        String resultmessage = "";

        public FormServer()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            ip = this.serverip.Text;
            


        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            this.serverport.Text = port;
        }
    }
}
