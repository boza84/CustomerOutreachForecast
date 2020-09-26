using Newtonsoft.Json;
using System;

namespace DAL.OpenWeather
{
    [Serializable]
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}