using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace weatherApp
{
    public partial class Primary : Form
    {
        public static Primary primary;
        public static HttpClient http = new HttpClient();
        public static WeatherStatus weather = new WeatherStatus();
        public static returnedWeather returned = new returnedWeather();

        public Primary()
        {
            InitializeComponent();
            primary = this;
        }

        private void primarySubmitBtn_Click(object sender, EventArgs e)
        {
            weather.useAPI();
        }
    }
}
