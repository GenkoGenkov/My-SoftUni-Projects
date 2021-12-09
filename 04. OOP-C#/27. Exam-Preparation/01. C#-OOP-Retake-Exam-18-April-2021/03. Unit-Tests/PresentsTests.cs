using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presents.Tests
{
    [TestFixture]
    public class BagTests
    {
        private Bag bag;
        private Present present;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
            present = new Present("Mincho", 188.5);
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Assert.IsNotNull(bag);
        }

        [Test]
        public void CreateMethodShouldCreateProperly()
        {
            string creationMessage = $"Successfully added present {present.Name}.";

            var returnedMessage = bag.Create(present);

            Assert.AreEqual(creationMessage, returnedMessage);
        }

        [Test]
        public void CreateMethodShouldThrowAnExceptionIfPresentIsNull()
        {
            Present present = null;
            //string nullExceptionMessage = "Value cannot be null. (Parameter 'Present is null')";

            var ex = Assert.Throws<ArgumentNullException>(() =>
            bag.Create(present));
            //Assert.AreEqual(nullExceptionMessage, ex.Message);
        }

        [Test]
        public void CreateMethodShouldThrowAnExceptionIfPresentAlreadyExist()
        {
            var expectedExceptionMessage = "This present already exists!";

            bag.Create(present);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            bag.Create(present));

            Assert.AreEqual(expectedExceptionMessage, ex.Message);
        }

        [Test]
        public void RemoveMethodShouldRemovePerfectly()
        {
            bag.Create(present);

            bool isRemoved = bag.Remove(present);

            Assert.IsTrue(isRemoved);
        }

        [Test]
        public void GetPresentWithLeastMagicShouldWorkProperly()
        {
            Present present2 = new Present("Pencho", 350.5);
            Present present3 = new Present("Percho", 388.5);
            Present presentWithLeastMagic = new Present("IAmWithLeastMagic", 3.5);

            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Create(presentWithLeastMagic);
            var returnedPresent = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(presentWithLeastMagic, returnedPresent);
        }

        [Test]
        public void GetPresentMethodShouldReturnTheCorrectPresent()
        {
            Present present2 = new Present("Pencho", 350.5);
            var expectedPresent = present;

            bag.Create(present);
            bag.Create(present2);
            var returnedPresent = bag.GetPresent(present.Name);

            Assert.AreEqual(expectedPresent, returnedPresent);
        }

        [Test]
        public void GetPresentsMethodShouldWorkProperly()
        {
            int expectedCount = 3;
            Present present2 = new Present("Pencho", 350.5);
            Present present3 = new Present("Percho", 388.5);

            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            var returnedPresentsCollection = bag.GetPresents();

            Assert.AreEqual(expectedCount, returnedPresentsCollection.Count);
        }
    }
}
