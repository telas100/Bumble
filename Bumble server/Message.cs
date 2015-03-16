using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bumble_server
{
    class Message
    {
        private string _pseudo;
        public string pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }
        private string _message;
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _channelName;
        public string channelName
        {
            get { return _channelName; }
            set { _channelName = value; }
        }
        private bool _connectChannel=false;
        public bool connectChannel
        {
            get { return _connectChannel; }
            set { _connectChannel = value; }
        }
        private bool _disconnectChannel=false;
        public bool disconnectChannel
        {
            get { return _disconnectChannel; }
            set { _disconnectChannel = value; }
        }
        private bool _timeout=false;
        public bool timeout
        {
            get { return timeout; }
            set { _timeout = value; }
        }
        private bool _afk=false;
        public bool afk
        {
            get { return _afk; }
            set { _afk = value; }
        }

        private bool _ping;
        public bool ping
        {
            get { return _ping; }
            set { _ping = value; }
        }

        private bool _login;
        public bool login
        {
            get { return _login; }
            set { _login = value; }
        }
    }
}
