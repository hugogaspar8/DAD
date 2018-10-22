using CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServidor
{
    class MyService : MarshalByRefObject, InterfaceServidor
    {
        Dictionary<string, string> clients;
        IClientServices service;

        public MyService()
        {
            clients = new Dictionary<string, string>();
        }

        public void close(string nick)
        {
            Log.Print("User [{0}] disconnected", nick);
            this.sendMessage(nick, "-> " + nick + " disconnected ! <-");
            clients.Remove(nick);
        }

        public void registerClient(string nick, string url)
        {
            bool hasValue = false;
            foreach (KeyValuePair<string, string> _reg in clients)
            {
                if (_reg.Key == nick)
                {
                    hasValue = true;
                    break;
                }
            }
            if (!hasValue)
            {
                clients[nick] = url;
                this.sendMessage(nick, "-> " + nick + " Connected ! <-");
            }
            Log.Print("User [{0}] registered at [{1}]", nick, url);
        }

        public void sendMessage(string nick, string message)
        {
            foreach (KeyValuePair<string, string> _reg in clients)
            {
                if (_reg.Key != nick)
                {
                    service = (IClientServices)Activator.GetObject(typeof(IClientServices), _reg.Value);
                    service.receiveMessage(message);
                }
            }
            Log.Print("origin [" + nick + "]   message [" + message + "]");

        }


    }
}
