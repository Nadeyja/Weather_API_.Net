using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_API
{
    internal class Weather
    {
       
        public float temp { get; set; }
        public override string ToString()
        {
            return $"{this.temp}";
        }
    }
}
