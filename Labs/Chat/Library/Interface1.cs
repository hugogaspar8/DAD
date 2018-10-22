using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public interface InterfaceCliente
    {
        void receiveMessage(string message);
    }
    public interface InterfaceServidor
    {
        void registerClient(string nick, string url);
        void sendMessage(string nick, string url);
        void close(string nick);
    }
}
