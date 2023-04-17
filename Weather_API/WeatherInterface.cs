using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Weather_API
{
    internal class WeatherInterface
    {
        private readonly string _apiKey = "489b28773a9262397afee68bebaf4abb";

        private int _maxTemperature;
        private int _minTemperature;
        private int _lon;
        private int _lat;


        private Uri generateRequestUrl(string queryString)
        {
            string scheme = "http";

            return new Uri($"{scheme}://api.openweathermap.org/data/2.5/weather?appid={_apiKey}&q={queryString}");
        }

        private async Task<string> makeApiQuery()
        {
            HttpClient client = new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?city=wroclaw&appid=489b28773a9262397afee68bebaf4abb&units=metric";
            string json = await client.GetStringAsync(call);

            return json;
        }

        public void displayData(string apiResponse)
        {
            if (apiResponse == null)
            {
                throw new ArgumentNullException();
            } else {
                dynamic jsonObject = JsonNode.Parse(apiResponse);
                this._maxTemperature = jsonObject.temp_min; 
            }
        }
    }
}
