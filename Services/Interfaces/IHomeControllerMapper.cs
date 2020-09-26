using DAL.Models;
using DAL.OpenWeather;

namespace Services.Interfaces
{
    public interface IHomeControllerMapper
    {
        CustomerForecastViewModel MapWeatherDataToViewModel(OpenWeatherResponse weatherData);
    }
}
