using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bumble_server
{
    class Client
    {
        private string _pseudo;
        public string pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }
        private Socket _socket;
        public Socket socket
        {
            get { return _socket; }
            set { _socket = value; }
        }
        private bool _connected;
        public bool connected
        {
            get { return _connected; }
            set { _connected = value; }
        }
        private DateTime _lastUpdate;
        public DateTime lastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

        public Client(string pseudo, Socket socket)
        {
            this.pseudo = pseudo;
            this.socket = socket;
            this._connected = true;
        }
    }
}
