using System;
using CommonLib;

namespace ChatServidor
{
    class ChatServidor : MarshalByRefObject, InterfaceServidor
    {
       void InterfaceServidor.registerClient(string nick, string url)
        {

        }

        void InterfaceServidor.sendMessage(string nick, string message)
        {

        }

        void InterfaceServidor.close(string url)
        {

        }
    }
    
}
