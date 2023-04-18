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

            //string json = await weatherInterface.downloadData();
            //textBox1.Text = json;
            //var weather = jsonserializer.deserialize<weatherinterface>(json);

            string city = cityTextBox.Text;

            //My DB connection string source, not gonna work on the university computer
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pasma\Source\Repos\Weather_API_.Net\Weather_API\WeatherDB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);


            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                OutputTextBox.Text = "Connected";
            } 
            else
            {
                OutputTextBox.Text = "Database error";
            }

            //Main call of making a forecast only using an API without saving to DB
            //
            //await weatherInterface.makeWeatherForecast(cityTextBox, OutputTextBox);
        }

    }
}