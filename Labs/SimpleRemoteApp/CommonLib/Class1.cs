﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public interface IServerServices
    {
        void registerClient(string nick, string url);
        void sendMessage(string nick, string message);
        void close(string nick);
    }
    public interface IClientServices
    {
        void receiveMessage(string message);
    }
}
