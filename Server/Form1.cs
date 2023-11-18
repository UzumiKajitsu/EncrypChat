using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public partial class Form1 : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> ClientList;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        void Connect()
        {
            ClientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        ClientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in ClientList)
            {
                Send(item);
            }
            AddMessage("Server : " + txb_Message.Text);
            txb_Message.Clear();
        }


        void Send(Socket client)
        {
            int Key = int.Parse(txb_Key.Text);
            string txbMessage = txb_Message.Text.ToString();

            string EncrypMessage = CaesarCipher.Encipher(txbMessage, Key);

            if (txb_Message.Text != string.Empty)
            {
                client.Send(Serialize(EncrypMessage));
            }
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    int Key = int.Parse(txb_Key.Text);
                    string DecrypMessage = CaesarCipher.Decipher(message, Key);
                    foreach (Socket item in ClientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(Serialize(message));
                        }
                    }
                    string messadd = "Client : " + DecrypMessage;
                    AddMessage(messadd);
                }
            }
            catch
            {
                ClientList.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            lsv_Message.Items.Add(new ListViewItem() { Text = s });
        }

        Byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);

        }

        void Close()
        {
            server.Close();
        }
    }
}