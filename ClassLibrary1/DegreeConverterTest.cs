using NUnit.Framework;
using TestLearning;

namespace ClassLibrary1
{
    [TestFixture]
    public class DegreeConverterTest
    {
        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            DegreeConverter covnerter = new DegreeConverter();
            double output = covnerter.ToFahrenheit(0);

            Assert.That(output, Is.EqualTo(32));

        }
        [Test]
        public void ToCelsius_1Fahrenheit_Returns0()
        {
            var converter = new DegreeConverter();
            double output = converter.ToCelsius(1);

            Assert.That(output, Is.EqualTo(0));
        }
    }
}