using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLearning.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(5)]
        [TestCase(25)]
        [TestCase(55)]
        [TestCase(55)]
        public void Ask_Multiples5_ReturnsFizzBuzz(int number)
        {
            string result = FizzBuzz.Ask(number);
            Assert.That(result, Is.EquivalentTo("Buzz"));
        }
    }
}
