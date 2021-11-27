using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using weatherApp.classes;

namespace weatherApp
{
    public class returnedWeather
    {
        public coord Coord { get; set; }
        public List<weather> Weather { get; set; }

        public string bases {get; set;}
        public main Main { get; set; }
        public string visibiliity { get; set; }
        public wind Wind { get; set; }
        public clouds Clouds { get; set; }
        public sys Sys { get; set; }
        public string timezone { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }

    }

    
}
