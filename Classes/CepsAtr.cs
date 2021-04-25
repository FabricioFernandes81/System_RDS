using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_RDS
{
    public class CepsAtr
    {
        public int status { get; set; }
        public bool ok { get; set; }
        public string code { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string statusText { get; set; }
    }

    public class Woeid
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string cid { get; set; }
        public int woeid { get; set; }
    }


}


