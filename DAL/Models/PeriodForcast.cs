using System;

namespace DAL.Models
{
    public class PeriodForcast
    {
        public DateTime PeriodStartTime { get; set; }
        public DateTime PeriodEndTime { get; set; }
        public string EngamentMethod { get; set; }
    }
}