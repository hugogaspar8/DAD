using CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class ClientService : MarshalByRefObject, IClientServices
    {
        private delegate void delDVRS(string message);
        private Form1 chatForm;
        public ClientService(Form1 formToInvoke)
        {
            this.chatForm = formToInvoke;    
        }
        public void receiveMessage(string message)
        {
            chatForm.BeginInvoke(new delDVRS(chatForm.appendMessage), new object[] { message });
        }
    }
}
