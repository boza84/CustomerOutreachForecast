using DAL.Models;
using DAL.OpenWeather;
using Services.Interfaces;
using System.Linq;

namespace Services
{
    public class HomeControllerMapper : IHomeControllerMapper
    {
        public CustomerForecastViewModel MapWeatherDataToViewModel(OpenWeatherResponse weatherData)
        {
            var weatherDataGroupedByDate = weatherData.TemperatureList.GroupBy(x => x.DtTxt.AddHours(-3).Date).Select(grp => grp.ToList()).ToList();

            var returnModel = new CustomerForecastViewModel
            {
                Location = weatherData.City.Name,
                DailyForecasts = weatherDataGroupedByDate.Select(dayWeather => new DailyForecast
                {
                    Date = dayWeather.FirstOrDefault().DtTxt,
                    PeriodForcasts = dayWeather.Select(x => new PeriodForcast
                    {
                        EngamentMethod = CalculateEngamentMethod(x.Main.Temp, x.Weather.FirstOrDefault().Main),
                        PeriodStartTime = x.DtTxt.AddHours(-3),
                        PeriodEndTime = x.DtTxt
                    }).ToList()
                }).ToList()
            };

            return returnModel;
        }

        private string CalculateEngamentMethod(double temp, string weather)
        {
            if (temp < 55 || weather.Equals("Rain"))
                return "The best method to engage a customer at this period is via a phone call.";

            if (temp < 75)
                return "The best method to engage a customer at this period is via email.";

            return "The best method to engage a customer at this period is via a text message.";
        }
    }
}
