using CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static TcpChannel channel;
        
        static void Main(string[] args)
        {
            startServer();
            Log.Print("Waiting for connections");
            Console.ReadLine();
        }

        static private  void startServer()
        {
            channel = new TcpChannel(7777);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MyService), "MyService", WellKnownObjectMode.Singleton);
            Log.Print("Server Spawned");
        }
    }
}
