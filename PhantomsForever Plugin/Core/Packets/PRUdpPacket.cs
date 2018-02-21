using PhantomsForever_Plugin.Core.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Packets
{
    public class PRUdpPacket
    {
        private byte[] PacketBytes;
        public PRUdpPacket(byte[] data)
        {
            PacketBytes = data;

        }
        public void Send(PRUdpServer server, IPEndPoint ep)
        {
            server.Send(PacketBytes, ep);
        }
    }
}