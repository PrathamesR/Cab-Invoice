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

            Ride ride = new Ride(distance,time,Ride.Type.NORMAL);
            double fare = ride.CalculateFare();

            Assert.AreEqual(expected, fare);
        }

        [Test]
        public void Test2()
        {
            Ride ride1 = new Ride(2, 3, Ride.Type.NORMAL);
            Ride ride2 = new Ride(4, 8, Ride.Type.NORMAL);
            Ride ride3 = new Ride(5, 10, Ride.Type.NORMAL);
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
            Ride ride1 = new Ride(2, 3, Ride.Type.NORMAL);
            Ride ride2 = new Ride(4, 8, Ride.Type.NORMAL);
            Ride ride3 = new Ride(5, 10, Ride.Type.NORMAL);

            Invoice invoice = new Invoice();
            invoice.AddRide(ride1);
            invoice.AddRide(ride2);
            invoice.AddRide(ride3);

            Assert.AreEqual(131, invoice.GetAggregate());
            Assert.AreEqual(43.666666666666666, invoice.GetAverage());
            Assert.AreEqual(3, invoice.NumberOfRides());
        }

        [Test]
        public void Test4()
        {
            Ride ride1 = new Ride(2, 3, Ride.Type.NORMAL);
            Ride ride2 = new Ride(4, 8, Ride.Type.NORMAL);
            Ride ride3 = new Ride(5, 10, Ride.Type.NORMAL); 

            Invoice invoice = new Invoice();
            invoice.AddRide(ride1);
            invoice.AddRide(ride2);
            invoice.AddRide(ride3);

            RideRepository rr = new RideRepository();

            rr.NewRide(ride1,"User 1");
            rr.NewRide(ride2,"User 1");
            rr.NewRide(ride3,"User 1");
            Invoice invoice1 = rr.GetInvoice("User 1");

            Assert.IsTrue(invoice.Equals(invoice1));
        }

        [Test]
        public void Test5()
        {
            double expected = 15;
            double distance = 1.3;
            double time = 2;

            double expected2 = 23.5;
            double distance2 = 1.3;
            double time2 = 2;


            Ride ride = new Ride(distance, time, Ride.Type.NORMAL);
            double fare = ride.CalculateFare();
            Ride ride2 = new Ride(distance2, time2, Ride.Type.PREMIUM);
            double fare2 = ride2.CalculateFare();

            Assert.AreEqual(expected, fare);
            Assert.AreEqual(expected2, fare2);
        }
    }
}