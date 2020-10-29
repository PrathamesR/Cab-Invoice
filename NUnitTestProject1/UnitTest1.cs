using NUnit.Framework;
using CabInvoiceGenerator;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double expected = 15;
            double distance = 1.3;
            double time = 2;

            Ride ride = new Ride(distance,time);
            double fare = ride.CalculateFare();

            Assert.AreEqual(expected, fare);
        }
    }
}