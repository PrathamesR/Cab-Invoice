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

        [Test]
        public void Test2()
        {
            Ride ride1 = new Ride(2, 3);
            Ride ride2 = new Ride(4, 8);
            Ride ride3 = new Ride(5, 10);
            double expected = 131;
            Invoice invoice = new Invoice();
            invoice.AddRide(ride1);
            invoice.AddRide(ride2);
            invoice.AddRide(ride3);

            Assert.AreEqual(expected, invoice.GetAggregate());
        }


        [Test]
        public void Test3()
        {
            Ride ride1 = new Ride(2, 3);
            Ride ride2 = new Ride(4, 8);
            Ride ride3 = new Ride(5, 10);

            Invoice invoice = new Invoice();
            invoice.AddRide(ride1);
            invoice.AddRide(ride2);
            invoice.AddRide(ride3);

            Assert.AreEqual(131, invoice.GetAggregate());
            Assert.AreEqual(43.666666666666666, invoice.GetAverage());
            Assert.AreEqual(3, invoice.NumberOfRides());
        }
    }
}