using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class Mensagem : MarshalByRefObject
    {
        public Mensagem()
        {
            Log.Print("Mensagem instatiated");
        }
        public string getMessage()
        {
            Log.Print("getMessage() called");
            return "hello";
        }

    }
    public interface ISS
    {
        void registerClient(string nick, string URI);
        void sendMessageToClient(string nick, string message);
    }

    public interface ISC
    {
        void receiveMessage(string message);
    }
}
