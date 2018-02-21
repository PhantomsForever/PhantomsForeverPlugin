using PhantomsForever_Plugin.Core.Extensions;
using PhantomsForever_Plugin.Core.Networking;
using PhantomsForever_Plugin.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Packets
{
    public class PRUdpPacket
    {
        private byte[] PacketBytes;
        private byte[] CheckSum;
        public PRUdpPacket(byte[] data)
        {
            PacketBytes = data;

        }
        public byte[] CalculateChecksum(byte[] b = null)
        {
            PacketBytes = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(PacketBytes).ljust((PacketBytes.Length + 3) & ~3, '\0'));
            var words = Struct.Unpack(string.Format("<{0}il", Math.Truncate((decimal)PacketBytes.Length / 4)), PacketBytes);
            try
            {
                var result = BitConverter.GetBytes((int)Sum.Do(words) & 0xffffffff);
                var rarr = new byte[b.Length + result.Length];
                using (var _mem = new MemoryStream(rarr))
                {
                    _mem.Write(b, 0, b.Length);
                    _mem.Write(result, 0, result.Length);
                    return _mem.ToArray();
                }
            }
            catch(Exception)
            {
                return BitConverter.GetBytes((int)Sum.Do(words) & 0xffffffff);
            }
        }
        public void Send(PRUdpServer server, IPEndPoint ep)
        {
            server.Send(PacketBytes, ep);
        }
    }
}