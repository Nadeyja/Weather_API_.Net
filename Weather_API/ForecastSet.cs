using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Weather_API
{
    [Table("Forecasts")]
    public class ForecastSet : DbContext
    {
        public virtual DbSet<Forecast>? Forecasts { get; set; }
    }
}
