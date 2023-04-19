using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_API
{
    public class Forecast
    {
        public int ID { set; get; }
        public double Temp { set; get; }
        public uint HoursForward { set; get; }
    }
}
