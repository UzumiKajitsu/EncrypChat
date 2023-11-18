using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
            string message = "Client : " + txb_Message.Text;
            AddMessage(message);
        }

        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Can't connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            client.Close();
        }

        void Send()
        {
            int Key = int.Parse(txb_Key.Text);
            string txbMessage = txb_Message.Text.ToString();

            string EncrypMessage = CaesarCipher.Encipher(txbMessage, Key);
            if (txb_Message.Text != string.Empty)
            {
                client.Send(Serialize(EncrypMessage));
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    int Key = int.Parse(txb_Key.Text);
                    string DecrypMessage = CaesarCipher.Decipher(message, Key);

                    string messadd = "Server : " + DecrypMessage;
                    AddMessage(messadd);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string s)
        {
            lsv_Message.Items.Add(new ListViewItem() { Text = s });
            txb_Message.Clear();
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
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txb_Key_TextChanged(object sender, EventArgs e)
        {
        }

        private void txb_Message_TextChanged(object sender, EventArgs e)
        {
        }

        private void lsv_Message_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


    }
}