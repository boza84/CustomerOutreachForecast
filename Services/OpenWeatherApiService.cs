using DAL.OpenWeather;
using Newtonsoft.Json;
using Services.Interfaces;
using System;
using System.Net.Http;

namespace Services
{
    public class OpenWeatherApiService : IOpenWeatherApiService
    {
        private const string OpenWeatherApiUrl = "http://api.openweathermap.org/data/2.5/forecast?q=minneapolis,us&units=imperial&APPID=09110e603c1d5c272f94f64305c09436";

        public OpenWeatherResponse GetWeatherData()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(OpenWeatherApiUrl)).Result;
                return JsonConvert.DeserializeObject<OpenWeatherResponse>(response);
            }
        }
    }
}