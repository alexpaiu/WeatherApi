using System;
using System.Net;
using System.Web.Script.Serialization;

namespace WeatherApi.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&APPID=da794fc3bcbfc36af0bc149b3fdff45b&units=metric";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }


    }
}
