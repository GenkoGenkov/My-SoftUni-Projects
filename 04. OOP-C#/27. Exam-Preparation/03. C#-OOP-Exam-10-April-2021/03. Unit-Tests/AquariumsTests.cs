namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void ConstructorInitializeCorrectly()
        {
            string name = "name";
            int cap = 1;

            Aquarium aquarium = new Aquarium(name, cap);

            Assert.AreEqual(aquarium.Name, name);
            Assert.AreEqual(aquarium.Capacity, cap);
        }

        [Test]
        public void SetNameThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 1));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(string.Empty, 1));
        }

        [Test]
        public void CapasityThrowsExeption()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("aa", -1));
        }

        [Test]
        public void CountShouldWorkCorrectly()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            aquarium.Add(new Fish("a"));

            int expectedCount = 1;

            Assert.AreEqual(expectedCount, aquarium.Count);
        }

        [Test]
        public void AddShouldThrowException()
        {
            Aquarium aquarium = new Aquarium("testA", 0);

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("fishy")));

        }

        [Test]
        public void RemoveShouldThrowException()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(null));
        }

        [Test]
        public void RemoveShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            aquarium.Add(new Fish("hmm"));
            aquarium.RemoveFish("hmm");

            Assert.AreEqual(aquarium.Count, 0);
        }

        [Test]
        public void SellFishShouldThrowException()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(null));
        }

        [Test]
        public void SellFishShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            aquarium.Add(new Fish("hmm"));

            Fish fish = aquarium.SellFish("hmm");

            Assert.AreEqual(fish.Name, "hmm");
            Assert.AreEqual(fish.Available, false);
        }

        [Test]
        public void ReportShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("a", 1);

            aquarium.Add(new Fish("hmm"));

            Fish fish = aquarium.SellFish("hmm");

            string expectedMessage = $"Fish available at a: hmm";

            Assert.AreEqual(expectedMessage, aquarium.Report());
        }
    }
}
