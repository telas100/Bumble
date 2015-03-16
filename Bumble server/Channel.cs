using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bumble_server
{
    class Channel
    {
        private string _channelName;
        public string channelName
        {
            get { return _channelName; }
            set { _channelName = value; }
        }

        private List<Client> _clientList;
        public List<Client> clientList
        {
            get { return _clientList; }
            set { _clientList = value; }
        }

    }
}
