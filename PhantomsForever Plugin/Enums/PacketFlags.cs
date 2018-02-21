using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Enums
{
    public enum PacketFlags
    {
        FLAG_ACK,
        FLAG_RELIABLE,
        FLAG_NEED_ACK,
        FLAG_HAS_SIZE,
        FLAG_MULTI_ACK
    }
}