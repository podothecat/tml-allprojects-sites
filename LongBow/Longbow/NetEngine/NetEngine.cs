﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace NetEngine
{
    public class NetEngine                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
    {

        void ThreadProc()
        {
            Message Msg;

            while(true)
            {
                DispatchMsg(out Msg);

                if (Msg != null)
                {
                    ;
                }
            }
        }

        Socket GetSocket(Int32 i)
        {
            return SocketList[i];
        }

        Message DispatchMsg(out Message Msg)
        {
            Msg = null; 

            if (MsgQueue.Count > 0)
            {
                Msg = MsgQueue.Dequeue();
            }

            return Msg;
        }


        private Queue<Message>  MsgQueue        = new Queue<Message>();
        private List<Socket>    SocketList      = new List<Socket>();
    }
}
