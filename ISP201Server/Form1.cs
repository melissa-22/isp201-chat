using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ISP201Server
{
    public partial class Form1 : Form
    {
        class ClientInfo
        {
            public Socket socket;
            public string name;

            public override string ToString()
            {
                return name + " (" + socket.RemoteEndPoint + ")";
            }
        }

        TcpListener listener;
        List<ClientInfo> clients;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBind_Click(object sender, EventArgs e)
        {
            try
            {
                int localPort = Int32.Parse(textBoxLog.Text);

                IPEndPoint localPoint = new IPEndPoint(IPAddress.Any, localPort);
                listener = new TcpListener(localPoint);
                listener.Start();
                clients = new List<ClientInfo>();

                timer1.Enabled = true;
               textBoxLocalPort.AppendText("Открыт ТСР порт " + textBoxLocalPort.Text + "\n");
            }
            catch (Exception exc)
            {
                textBoxLocalPort.AppendText(exc.Message + "\n");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try

            {
                CheckListener();

                for (int i = clients.Count - 1; i > 0; i--)
                {
                    ClientInfo client = clients[i];

                    if (client.socket.Available > 0) 
                    {
                        byte[] data = new byte[client.socket.Available];
                        int data_size = client.socket.Receive(data);
                        string text_data = Encoding.UTF8.GetString(data, 0, data_size);

                        DoClient(client, text_data);
                    }
                }
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + "\n");
            }
        }

        private void CheckListener()
        {
            if (listener.Pending())             
            { 
             ClientInfo newClieint = new ClientInfo();
                newClieint.socket = listener.AcceptSocket();
                clients.Add(newClieint);
               textBoxLocalPort.AppendText("\n Пользователь" +  newClieint.socket.RemoteEndPoint + " подключился\n");
            }   
        }

        private void DoClient(ClientInfo client, string text_data)
        {
            if(text_data.StartsWith("name"))
            {
                client.name = text_data.Substring(4);
                listBoxClients.Items.Add(client);
                SendToClients("new" + client.name, client);
                textBoxLocalPort.AppendText("\n Пользователь" + client.socket.RemoteEndPoint + " выбрал имя "  +  client.name + "\n");
            }
            if (text_data == "quit")
            {
                SendToClients("exit" + client.name, client);
                textBoxLocalPort.AppendText("Пользователь" + client.socket.RemoteEndPoint + " покинул комнату\n");
                client.socket.Shutdown(SocketShutdown.Both);
                client.socket.Close();
                listBoxClients.Items.Remove(client);
                clients.Remove(client);
            }
            if(text_data.StartsWith("message"))
            {
                string message = text_data.Substring(8);
                SendToClients( "\n" + "message" + client.name + ": " + message, client); 
                textBoxLocalPort.AppendText( "\n" + client.name+ ": " + message);   
            }
        }

        private void SendToClients(string command, ClientInfo exceptof)
        {
            
            for (int i = 0; i < clients.Count; i++)
            {
                ClientInfo client = clients[i];

                if (client !=exceptof)
                {
                    try
                    {
                        byte[] data = Encoding.UTF8.GetBytes(command);
                        client.socket.Send(data);
                    }
                    catch (Exception exc)
                    {
                        textBoxLog.AppendText(exc.Message + "\n");
                    }
                }
            }
        }

    }
}