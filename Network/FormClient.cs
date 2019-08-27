using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Network
{
    public partial class FormClient : Form
    {

        String user = "client";

        TcpListener Server;
        TcpClient Client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;
        Thread ReceiveThread;
        bool Connected;
        private delegate void AddTextDelegate(string strText);
        

        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            this.clientip.Text = "10.96.127.179";
            this.clientport.Text = "5000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String IP = "10.96.123.179"; // 접속 할 서버 아이피를 입력
            int port = 5000; // 포트
            Client = new TcpClient();
            Client.Connect(IP, port);
            stream = Client.GetStream();
            Connected = true;
            clientchat.AppendText("채팅방에 참여했습니다." + "\r\n");
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientchat.AppendText(user + " : " + clientmessage.Text + "\r\n");
            Writer.WriteLine(user + " : " +clientmessage.Text); // 보내버리기
            Writer.Flush();
            clientmessage.Clear();
         
        }


        private void Receive() // 서버로 부터 값 받아오기
        {
            AddTextDelegate AddText = new AddTextDelegate(clientchat.AppendText);
            while (Connected)
            {
                Thread.Sleep(1);
                if (stream.CanRead)
                {
                    string tempStr = Reader.ReadLine();
                    if (tempStr.Length > 0)
                    {                
                        Invoke(AddText,tempStr + "\r\n");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientchat.AppendText(user+"님이 나갔습니다. \r\n");
            Writer.WriteLine(user + "님이 나갔습니다.");
            Writer.Flush();

            Connected = false;
            Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientchat.AppendText(user + "님이 " + clientname.Text + "로 변경하셨습니다. \r\n");
            Writer.WriteLine(user + "님이 " + clientname.Text + "로 변경하셨습니다.");
            Writer.Flush();
            user = clientname.Text;
            clientname.Clear();
        }
    }
}
