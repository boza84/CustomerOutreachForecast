using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DAL.OpenWeather
{
    [Serializable]
    public class OpenWeatherResponse
    {
        [JsonProperty("cod")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("cnt")]
        public int Cnt { get; set; }

        [JsonProperty("list")]
        public List<TemperatureList> TemperatureList { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }
    }
}