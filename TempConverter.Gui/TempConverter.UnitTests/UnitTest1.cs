using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TempConverter.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Temperature temp;

        [TestInitialize]
        public void Setup()
        {
            temp = new Temperature();
        }

        [TestMethod]
        public void TestFromFahrenheit()
        {
            temp.ChangeTemp(32, (int)Temperature.Temps.Fahrenheit);
            Assert.AreEqual(0, temp.Celsius);
            Assert.AreEqual(273.15M, temp.Kelvin);
        }

        [TestMethod]
        public void TestFromCelsius()
        {
            temp.ChangeTemp(0, (int)Temperature.Temps.Celsius);
            Assert.AreEqual(32, temp.Fahrenheit);
            Assert.AreEqual(273.15M, temp.Kelvin);
        }

        [TestMethod]
        public void TestFromKelvin()
        {
            temp.ChangeTemp(100, (int)Temperature.Temps.Kelvin);
            Assert.AreEqual(-173.15M, temp.Celsius);
            Assert.AreEqual(-279.67M, temp.Fahrenheit);
        }

        [TestMethod]
        public void TestSameInputAndOutput()
        {
            temp.ChangeTemp(100, (int)Temperature.Temps.Celsius);
            Assert.AreEqual(100, temp.Celsius);
            temp.ChangeTemp(100, (int)Temperature.Temps.Fahrenheit);
            Assert.AreEqual(100, temp.Fahrenheit);
            temp.ChangeTemp(100, (int)Temperature.Temps.Kelvin);
            Assert.AreEqual(100, temp.Kelvin);
        }

        [TestMethod]
        public void TestValidateTemp()
        {
            
        }
    }
}
