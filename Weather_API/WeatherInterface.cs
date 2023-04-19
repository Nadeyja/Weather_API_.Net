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

        private void unravelJsonToObject(string apiResponse, uint hoursForward)
        {
            if (apiResponse == null)
            {
                throw new ArgumentNullException();
            } else {
                var jsonObject = JsonDocument.Parse(apiResponse);
                JObject o = JObject.Parse(apiResponse);

                string tokenSelection = "$.list["+ hoursForward +"].main.temp";
                this._temperature = (double)o.SelectToken(tokenSelection)!;
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

        public async Task<double> makeWeatherForecast(TextBox cityTextBox, TextBox outputTextBox, uint hoursForward)
        {
            string city = cityTextBox.Text;

            Uri urlRequestUrl = this.generateRequestUrl(city);
            string jsonResponse = await this.makeApiQuery(urlRequestUrl);

            if (jsonResponse == null)
            {
                throw new ArgumentNullException("Bad call");
            } else {
                this.unravelJsonToObject(jsonResponse, hoursForward);

                outputTextBox.Text = this._temperature.ToString() + " °C";
                return this._temperature;
            }
        }
    }
}
