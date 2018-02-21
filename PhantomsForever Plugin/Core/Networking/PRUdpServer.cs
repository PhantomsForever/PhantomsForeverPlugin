using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Networking
{
    public class PRUdpServer
    {
        private Socket _udpServer;
        private byte[] Buffer = new byte[0x10000];
        public PRUdpServer()
        {
            _udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }
        public void Start()
        {
            _udpServer.Listen(1500);
            EndPoint tempEndpoint = new IPEndPoint(IPAddress.Any, 0x00000000);
            _udpServer.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref tempEndpoint, PRUdpReceiveCallback, null);
        }

        private void PRUdpReceiveCallback(IAsyncResult ar)
        {
            EndPoint tempEndpoint = new IPEndPoint(IPAddress.Any, 0x00000000);
            _udpServer.EndReceiveFrom(ar, ref tempEndpoint);
        }
        public void Send(byte[] buff, IPEndPoint ep)
        {
            _udpServer.SendTo(buff, ep);
        }
    }
}