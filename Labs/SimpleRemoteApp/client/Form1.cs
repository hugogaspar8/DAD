
using CommonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace client
{
    public partial class Form1 : Form
    {
       
        TcpChannel channel;
        IServerServices service;
        ClientService _clientService;
        string _nick;
        int _port;
        public Form1()
        {
            InitializeComponent();
            _clientService = new ClientService(this);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Connect" )
            {

                _nick = nick.Text;
                _port = Int32.Parse(port.Text);
                channel = new TcpChannel(_port);
                RemotingServices.Marshal(_clientService, _nick, typeof(ClientService));
                ChannelServices.RegisterChannel(channel, false);
                service = (IServerServices)Activator.GetObject(typeof(IServerServices), "tcp://localhost:7777/MyService");
                service.registerClient(_nick, "tcp://localhost:" + _port + "/" + _nick);
                button1.Text = "Disconnect";
                appendMessage("-> Connected <-");
                nick.Enabled = false;
                port.Enabled = false;
                button2.Enabled = true;
                message.Enabled = true;
            }
            else
            {
                service.close(_nick);
                service = null;
                button1.Text = "Connect";
                nick.Enabled = true;
                port.Enabled = true;
                conversation.Clear();
                message.Clear();
                message.Enabled = false;
                button2.Enabled = false;
                channel.StopListening(null);
                RemotingServices.Disconnect(this);
                ChannelServices.UnregisterChannel(channel);
                channel = null;

            }
           
        }


        public void appendMessage(string message)
        {
            this.conversation.Text += message + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (service != null)
            {
                service.sendMessage(_nick, _nick + ": " + message.Text);
                appendMessage("Me: " + message.Text);
                this.message.Text = "";
            }
        }
    }
}
