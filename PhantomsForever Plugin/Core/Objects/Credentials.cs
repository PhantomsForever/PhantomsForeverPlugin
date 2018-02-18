using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Objects
{
    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class CredentialsResponse
    {
        public string Username { get; set; }
        public List<int> Token { get; set; }
    }
}