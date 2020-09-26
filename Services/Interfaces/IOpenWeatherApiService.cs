using DAL.OpenWeather;

namespace Services.Interfaces
{
    public interface IOpenWeatherApiService
    {
        OpenWeatherResponse GetWeatherData();
    }
}
