using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bumble_server
{
    class Program
    {
        public static string filename = "chans.xml";
        // Incoming data from the client.
        public static string data = null;
        public static List<Client> clientList = new List<Client>();
        public static List<Channel> channelList;

        static void Main(string[] args)
        {
            string choice;

            /*Console.WriteLine("Welcome to the Bumble chat manager!\n\n" +
                "1- Modify the server\n" +
                "2- Launch the server\n" +
                "What is your choice? : ");
            while (((choice = Console.ReadLine()) != "1") && (choice != "2"))
            {
                Console.WriteLine("\nPick a number between 1 and 2\n" +
                    "What is your choice? : ");
            }

            Console.Clear();
            switch (choice)
            {
                case "1":
                    modifyServer();
                    break;

                case "2":*/
                    launchServer();
                    //break;
           //}

        }

        public static void modifyServer()
        {
            //Add some channel
            //Delete some channel
            SaveXml(channelList);
        }

        public static void launchServer()
        {
            channelList = LoadXml();
            startListening();
        }

        public static List<Channel> LoadXml()
        {
            List<Channel> s = null;
            try
            {
                XmlSerializer xd = new XmlSerializer(typeof(List<Channel>));
                using (StreamReader rd = new StreamReader(filename))
                {
                    s = xd.Deserialize(rd) as List<Channel>;
                }
            }
            catch (Exception)
            {
                s = new List<Channel>();
            }
            return s;
        }

        public static void SaveXml(List<Channel> s)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Channel>));
            using (StreamWriter wr = new StreamWriter(filename))
            {
                xs.Serialize(wr, s);
            }
        }

        public static void startListening()
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            // Dns.GetHostName returns the name of the 
            // host running the application.

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, 80);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and 
            // listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                //Rajouter des trucs de maintient en vie de la connexion, AFK + si perte de connexion avec le serveur, le
                //client affiche genre "rebranchez votre cable" ou autre.
                //+gestions des erreurs

                // Start listening for connections.
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.
                    Socket handler = listener.Accept();
                    
                    Byte[] myBuffer = new byte[256];
                    int nbByteReceived = handler.Receive(myBuffer);

                    //Gestion du client et de son mot de passe

                    Client newClient = new Client(Encoding.UTF8.GetString(myBuffer), handler);
                    clientList.Add(newClient);

                    Thread threadExchange = new Thread(() => clientExchange(newClient));
                    Thread threadClientConnected = new Thread(() => clientConnected(newClient));
                    threadExchange.Start();
                    threadClientConnected.Start();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }

        #region thread
        public static void clientExchange(Client client)
        {
            /*
            string jsonMessage;
            while (client.connected)
            {
                
                
            }
            if (!client.connected)
            {
                string jsonDisconnectMessage;
                Message message = new Message();
                message.timeout = true;
                message.pseudo = client.pseudo;
                message.disconnectChannel = true;

                //jsonDisconnectMessage=Jso
            }
            
            else
            {
                foreach (Client c in channelList.Find(x => x.channelName == message.channelName).clientList)
                {
                    c.socket.Send(myBuffer);
                }

                if (message.afk == true)
                {
                    break;
                }
            }
        
            client.socket.Close();
            clientList.Remove(client);
              */
        }
        public static Message getMessage(Socket sock)
        {
            string jsonMessage;
            Byte[] myBuffer = new byte[1024];
            sock.Receive(myBuffer);
            jsonMessage = Encoding.UTF8.GetString(myBuffer);
            Message message = JsonConvert.DeserializeObject<Message>(jsonMessage);
            return message;
        }

        public static void sendMessage(Message message, Socket sock)
        {
            string jsonMessage = JsonConvert.SerializeObject(message);
            Byte[] myBuffer = new byte[1024];
            myBuffer = Encoding.UTF8.GetBytes(jsonMessage);
            sock.Send(myBuffer);
        }

        public static void sendMessage(Byte[] myBuffer, Socket sock)
        {
            sock.Send(myBuffer);
        }

        public static void clientConnected(Client client)
        {
            int i = 0;
            while (true)
            {
                if (client.socket.Send(Encoding.UTF8.GetBytes("Are you alive")) == 0)
                {
                    i++;
                    if (i == 3)
                    {
                        client.connected = false;
                        break;
                    }
                }
                else
                {
                    i = 0;
                }
                Thread.Sleep(5000);
            }
        }
        #endregion
    }
}
