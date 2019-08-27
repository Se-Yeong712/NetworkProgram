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
    public partial class FormServer : Form
    {

        String user = "server";


        TcpListener Server; // 소켓 서버
        TcpClient Client; // 클라이언트
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream; // 네트워크 스트림 연결
        Thread ReceiveThread;
        bool Connected;
        private delegate void AddTextDelegate(string strText);

        public FormServer()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            this.serverip.Text = "10.96.123.179";
            this.serverport.Text = "5000";

           

        }


        private void Listen()
        {
            AddTextDelegate AddText = new AddTextDelegate(serverchat.AppendText);
            IPAddress addr = IPAddress.Parse("10.96.123.179"); // 서버 ip
            int port = 5000; // 서버 포트
            Server = new TcpListener(addr, port);
            Server.Start(); // 서버 시작
            Invoke(AddText, "채팅방이 열렸습니다.!" + "\r\n");
            Client = Server.AcceptTcpClient(); // 클라이언트 연결 수락
            Connected = true;
            Invoke(AddText, "참여자가 들어왔습니다." + "\r\n");
            stream = Client.GetStream(); // 클라이언트 스트림 값 받아오기
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            ReceiveThread = new Thread(new ThreadStart(Receive)); // 값을 받기 위한 쓰레드
            ReceiveThread.Start();


        }

        private void Receive() // 클라이언트에게 받기
        {
            AddTextDelegate AddText = new AddTextDelegate(serverchat.AppendText);
            while (Connected)
            {
                Thread.Sleep(1);
                if (stream.CanRead) // 받아온 데이터가 있다면 출력
                {
                    string tempStr = Reader.ReadLine();
                    if (tempStr.Length > 0)
                    {

                        Invoke(AddText, tempStr + "\r\n");
                    }
                }
            }



        }

        private void send_Click(object sender, EventArgs e)
        {
            serverchat.AppendText(user+" : " + servermessage.Text + "\r\n"); // 화면에 출력
            Writer.WriteLine(user+" : "+servermessage.Text); // 보내버리기
            Writer.Flush();
            servermessage.Clear();

        }

        private void off_Click(object sender, EventArgs e)
        {
            serverchat.AppendText("채팅을 종료합니다. \r\n"); 
            Writer.WriteLine("채팅을 종료합니다."); 
            Writer.Flush();

            Connected = false;
            Close();

        }

        private void rename_Click(object sender, EventArgs e)
        {
            serverchat.AppendText(user + "님이 " + servername.Text + "로 변경하셨습니다. \r\n");
            Writer.WriteLine(user + "님이 " + servername.Text + "로 변경하셨습니다.");
            Writer.Flush();
            user = servername.Text;
            servername.Clear();
        }
    }
}
