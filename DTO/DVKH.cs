using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_Client.DTO
{
    class DVKH
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public DVKH(int id, string name)
        {
            MaDV = id;
            TenDV = name;
        }
        public DVKH() { }
    }
}
