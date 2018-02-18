using LindsayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LindsayPlugin.Interfaces;

namespace PhantomsForever_Plugin
{
    [PluginName("Phantoms Forever GRP")]
    [PluginDescription("The server for GRP")]
    [PluginAuthor("The PhantomsForever Developers")]
    [PluginType(typeof(PhantomsForeverPlugin))]
    public class PhantomsForeverPlugin : LPlugin
    {
        internal static PhantomsForeverPlugin Instance;
        public IPluginManager Manager;
        public void Load(IPluginManager _manager)
        {
            Instance = this;
            Manager = _manager;
        }

        public void Unload()
        {
            Instance = null;
        }
    }
}