using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.test
{
    public class UnitTest1
    {
        static ILogger<WeatherForecastController> logger = null;
        WeatherForecastController cnlrWeather = new WeatherForecastController(logger);
        
         [Fact]
        public void SampleTest2()
        {
            var ret = cnlrWeather.Get(17);
            Assert.Equal("13", ret);
        }

        [Fact]
        public void GetReturnsId()
        {
            var ret = cnlrWeather.Get(13);
            Assert.Equal("13", ret);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
