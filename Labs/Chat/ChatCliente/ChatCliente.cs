using System;
using CommonLib;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    class ChatCliente : MarshalByRefObject, InterfaceCliente
    {
        private delegate void delDVRS(string s);
        private Form1 fc;

        public ChatCliente(Form1 f)
        {
            this.fc = f;
        }

        public void receiveMessage(string message)
        {
            fc.BeginInvoke(new delDVRS(fc.addmsg), new object[] { message });
        }

    }
}
