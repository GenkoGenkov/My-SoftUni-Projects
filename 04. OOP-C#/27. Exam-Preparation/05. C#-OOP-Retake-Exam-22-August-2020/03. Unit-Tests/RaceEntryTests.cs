using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
        }

        [Test]
        public void CounterIsZeroByDefault()
        {
            Assert.That(raceEntry.Counter, Is.Zero);
        }

        [Test]
        public void CounterrIncreasesWhenAddingDriver()
        {
            raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla", 400, 500)));

            Assert.That(raceEntry.Counter, Is.EqualTo(1));
        }

        [Test]
        public void AddDriverThroesExceptionWhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriverThroesExceptionWhenDriverNameExist()
        {
            var driverName = "Nasko";

            raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla S", 400, 500)));

            Assert.Throws<InvalidOperationException>(() => 
            raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla Cybertruck", 300, 700))));
        }

        [Test]
        public void AddDriverReturnsExpectedresultMessage()
        {
            var driverName = "Nasko";

            var actual = raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla S", 400, 500)));
            var expected = $"Driver {driverName} added in race.";

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void CalculateAverageHorsePowerThrowsExceptionWhenParticipantArelessThenRequired(int n)
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());

            raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla S", 400, 500)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePowerReturnsExpectedResult()
        {
            int n = 10;
            double expected = 0;

            for (int i = 0; i < n; i++)
            {
                int hp = 450 + i;
                expected += hp;

                raceEntry.AddDriver(new UnitDriver($"Name-{i}", new UnitCar("Model", hp, 550)));
            }

            expected /= n;

            double actual = raceEntry.CalculateAverageHorsePower();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}