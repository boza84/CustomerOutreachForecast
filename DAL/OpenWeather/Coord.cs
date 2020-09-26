using Newtonsoft.Json;
using System;

namespace DAL.OpenWeather
{
    [Serializable]
    public class Coord
    {
        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }

        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
    }
}