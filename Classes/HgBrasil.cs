using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_RDS
{
    class HgBrasil
    {
        public string by { get; set; }
        public bool valid_key { get; set; }
        public Results results { get; set; }
        public double execution_time { get; set; }
        public bool from_cache { get; set; }

    }

    public class Forecast
    {
        public string date { get; set; }
        public string weekday { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public string description { get; set; }
        public string condition { get; set; }
    }

    public class Results
    {
        public int temp { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string condition_code { get; set; }
        public string description { get; set; }
        public string currently { get; set; }
        public string cid { get; set; }
        public string city { get; set; }
        public string img_id { get; set; }
        public int humidity { get; set; }
        public string wind_speedy { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string condition_slug { get; set; }
        public string city_name { get; set; }
        public List<Forecast> forecast { get; set; }
    }

//    public class Root
//    {
 //   }

}
