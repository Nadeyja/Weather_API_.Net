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

            //string json = await weatherInterface.downloadData();
            //textBox1.Text = json;
            //var weather = jsonserializer.deserialize<weatherinterface>(json);

            string city = cityTextBox.Text;

            await weatherInterface.makeWeatherForecast(cityTextBox, OutputTextBox);
        }

    }
}