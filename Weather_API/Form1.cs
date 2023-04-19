using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;

namespace Weather_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WeatherInterface weatherInterface = new WeatherInterface();

            var context = new ForecastSet();
            //context.Forecasts.Add(new Forecast { Temp = 16, Date = DateTime.Now });
            //context.SaveChanges();

            uint hoursForward = uint.Parse(HourTextbox.Text);
            hoursForward = hoursForward - hoursForward % 3;
            HourTextbox.Text = hoursForward.ToString();

            var forecastQueried = (from s in context.Forecasts
                                   where s.HoursForward == hoursForward
                                   select s).ToList<Forecast>();

            if (forecastQueried.Count == 0)
            {
                double temp = await weatherInterface.makeWeatherForecast(cityTextBox, OutputTextBox, hoursForward);
                context.Forecasts.Add(new Forecast { Temp = temp, HoursForward = hoursForward });
            }
            else
            {
                OutputTextBox.Text = "ID: " + forecastQueried[0].ID + " , Temperature:" + forecastQueried[0].Temp + " °C, Date: " + forecastQueried[0].HoursForward.ToString() + "\n";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var context = new ForecastSet();

            var queryAll = context.Forecasts
                .SqlQuery("select * from Forecasts").ToList<Forecast>();

            foreach(var forecast in queryAll)
                context.Forecasts.Remove(forecast);

            context.SaveChanges();
            OutputTextBox.Text = "";
        }
    }
}