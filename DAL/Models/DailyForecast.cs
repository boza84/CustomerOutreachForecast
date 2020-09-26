using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class DailyForecast
    {
        public DateTime Date { get; set; }
        public List<PeriodForcast> PeriodForcasts { get; set; }
    }
}