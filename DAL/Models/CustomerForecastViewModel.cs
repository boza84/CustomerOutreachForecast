using System.Collections.Generic;

namespace DAL.Models
{
    public class CustomerForecastViewModel
    {
        public string Location { get; set; }

        public List<DailyForecast> DailyForecasts { get; set; }
    }
}