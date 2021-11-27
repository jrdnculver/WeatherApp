using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace weatherApp
{
    public class WeatherStatus
    {
        public string city {get; set;}

		public string result { get; set; }

		public returnedWeather forecast { get; set; }

		public void useAPI()
        {
			Primary.weather.city = Primary.primary.primaryCityEntry.Text;

			var api = "4ebd95f8142ca8aca6a5b44945d4f199";

			var url = $"https://api.openweathermap.org/data/2.5/weather?q={Primary.weather.city}&units=metric&appid={api}";

			Primary.weather.getWeatherCast(url);
		}

        public async void getWeatherCast(string url)
        {
			using (HttpResponseMessage response = await Primary.http.GetAsync(url))

			using (HttpContent content = response.Content)
			{
				Primary.weather.result = await content.ReadAsStringAsync();

				string json = Primary.weather.result;

				forecast = JsonConvert.DeserializeObject<returnedWeather>(json);

				Primary.weather.setText();

			}
		}

		public void setText()
        {
			Primary.primary.returnWeatherText.Text = forecast.Weather[0].description;
			Primary.primary.returnTemperatureText.Text = convertTemp(forecast.Main.temp);
			Primary.primary.returnFeelsLikeText.Text = convertTemp(forecast.Main.feels_like);
			Primary.primary.returnTempHighText.Text = convertTemp(forecast.Main.temp_max);
			Primary.primary.returnTempLowText.Text = convertTemp(forecast.Main.temp_min);
			Primary.primary.returnPressureText.Text = forecast.Main.pressure;
			Primary.primary.returnHumidityText.Text = forecast.Main.humidity;
        }

		public string convertTemp(string temp)
        {
			double celsius = double.Parse(temp);

			double fahr = (celsius * 1.8 + 32);

			string result = fahr.ToString("f1");

			return result;
        }
	}
}