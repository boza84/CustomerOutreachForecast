using Newtonsoft.Json;
using System;

namespace DAL.OpenWeather
{
    [Serializable]
    public class Rain
    {
        [JsonProperty("3h")]
        public double ThreeH { get; set; }
    }
}