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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            FormServer m = new FormServer();
            m.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            FormClient m = new FormClient();
            m.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
