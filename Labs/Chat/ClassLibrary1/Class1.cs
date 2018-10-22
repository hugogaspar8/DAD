using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public interface InterfaceCliente
    {
        void receiveMessage(string message);
    }
    public interface InterfaceServidor
    {
        void registerClient(string nick, string url);
        void sendMessage(string nick, string message);
        
    }
}
