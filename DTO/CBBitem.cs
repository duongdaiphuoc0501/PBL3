using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Client.DTO
{
    class CBBitem
    {
        public string id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
