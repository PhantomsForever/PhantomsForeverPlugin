using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Objects
{
    [DataContract]
    public class Configuration
    {
        private string key;
        private string value;
        [DataMember]
        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        [DataMember]
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value.ToString();
            }
        }

    }
}