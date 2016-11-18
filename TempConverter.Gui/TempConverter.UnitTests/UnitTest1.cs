using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TempConverter.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFromFahrenheit()
        {
            Assert.AreEqual(0M, Temperature.FromFahrenheight(32).Celsius);
            Assert.AreEqual(273.15M, Temperature.FromFahrenheight(32).Kelvin);
        }

        [TestMethod]
        public void TestFromCelsius()
        {
            Assert.AreEqual(32M, Temperature.FromCelsius(0).Fahrenheit);
            Assert.AreEqual(373.15M, Temperature.FromCelsius(100).Kelvin);
        }

        [TestMethod]
        public void TestFromKelvin()
        {
            Assert.AreEqual(-459.67M, Temperature.FromKelvin(0).Fahrenheit);
            Assert.AreEqual(-273.15M, Temperature.FromKelvin(0).Celsius);
        }
    }
}
