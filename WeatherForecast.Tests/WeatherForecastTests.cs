using System;
using Xunit;

namespace WeatherForecast.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void TemperatureConvertTest()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 31
            };
            
            Assert.Equal(87, weatherForecast.TemperatureF);
        }
    }
}