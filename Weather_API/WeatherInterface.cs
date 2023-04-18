using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Weather_API
{
    internal class WeatherInterface
    {
        private readonly string _apiKey = "489b28773a9262397afee68bebaf4abb";

        private double _temperature;
        private double _lon;
        private double _lat;

        private Uri generateRequestUrl(string queryString)
        {
            string scheme = "http";

            return new Uri($"{scheme}://api.openweathermap.org/data/2.5/forecast?appid={_apiKey}&q={queryString}");
        }

        private async Task<string> makeApiQuery(Uri urlQuery)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(urlQuery);

            return json;
        }

        private void unravelJsonToObject(string apiResponse)
        {
            if (apiResponse == null)
            {
                throw new ArgumentNullException();
            } else {
                var jsonObject = JsonDocument.Parse(apiResponse);
                JObject o = JObject.Parse(apiResponse);

                this._temperature = (double)o.SelectToken("$.list[0].main.temp")!;
                this._temperature = this.evalKelvinToCelsius(this._temperature);

                this._lon = (double)o.SelectToken("$.city.coord.lon")!;
                this._lat = (double)o.SelectToken("$.city.coord.lat")!;    
            }
        }

        private double evalKelvinToCelsius(double tempKelvin)
        {
            double tempCelsius = Math.Round(tempKelvin - 273.15, 2);
            return tempCelsius;
        }

        public async Task makeWeatherForecast(TextBox cityTextBox, TextBox outputTextBox)
        {
            string city = cityTextBox.Text;

            Uri urlRequestUrl = this.generateRequestUrl(city);
            string jsonResponse = await this.makeApiQuery(urlRequestUrl);

            if (jsonResponse == null)
            {
                throw new ArgumentNullException("Bad call");
            } else {
                this.unravelJsonToObject(jsonResponse);

                outputTextBox.Text = this._temperature.ToString() + " °C";
            }
        }
    }
}
