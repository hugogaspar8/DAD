using System;
using CommonLib;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        

        TcpChannel ch;
        ChatCliente cc;
        InterfaceServidor s;



        public Form1()
        {
            InitializeComponent();
            cc = new ChatCliente(this);
        }


        private void send_Click(object sender, EventArgs e)
        {
            if(s != null)
            {
                s.sendMessage(nick.Text, nick.Text + ": " + message.Text);
                addmsg("Me: " + message.Text);
                this.message.Text = "";
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            ch = new TcpChannel(Int32.Parse(porto.Text));
            RemotingServices.Marshal(cc, nick.Text, typeof(ChatCliente));
            ChannelServices.RegisterChannel(ch, false);
            s = (InterfaceServidor)Activator.GetObject(typeof(InterfaceServidor), "tcp://localhost:7777/ChatServidor");
            s.registerClient(nick.Text, "tcp://localhost:" + porto.Text + "/" + nick.Text);
        }

        public void addmsg(string m)
        {
            this.chat.Text += message + "\r\n";
        }
    }
}
