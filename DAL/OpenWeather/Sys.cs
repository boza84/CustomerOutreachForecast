using Newtonsoft.Json;
using System;

namespace DAL.OpenWeather
{
    [Serializable]
    public class Sys
    {
        [JsonProperty("pod")]
        public string Pod { get; set; }
    }
}