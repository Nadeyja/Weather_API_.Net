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
            string json = await downloadData();
            textBox1.Text = json;
            var weather = JsonSerializer.Deserialize<Weather>(json);
            listBox1.Items.Clear();
        }
        private async Task<string> downloadData()
        {
            HttpClient client = new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?lat=51.107&lon=17.038&appid=489b28773a9262397afee68bebaf4abb&units=metric";
            string json = await client.GetStringAsync(call);
            return json;
        }

    }
}