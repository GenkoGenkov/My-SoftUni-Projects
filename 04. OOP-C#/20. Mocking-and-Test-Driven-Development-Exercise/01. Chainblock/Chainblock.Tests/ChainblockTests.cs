using Chainblock.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chainblock.Tests
{
    public class ChainblockTests
    {
        private IChainblock chainblock;

        [SetUp]
        public void SetUp()
        {
            chainblock = new Chainblock();
        }

        [Test]
        public void AddMethodShouldAddUniqueRecords()
        {
            ITransaction transaction = new Transaction(
                456,
                TransactionStatus.Successfull,
                "Niki",
                "Stoyan",
                50);

            chainblock.Add(transaction);

            bool exist = chainblock.Contains(transaction);

            Assert.True(exist);
            Assert.AreEqual(1, chainblock.Count);
        }

        [Test]
        public void AddMethodMustAddOnlyUniqueTransactions()
        {
            ITransaction transaction = new Transaction(
                12345,
                TransactionStatus.Successfull,
                "Niki",
                "Stoyan",
                50);

            ITransaction duplicatedTransaction = new Transaction(
                12345,
                TransactionStatus.Successfull,
                "Niki",
                "Stoyan",
                50);

            chainblock.Add(transaction);
            chainblock.Add(duplicatedTransaction);

            bool transactionExist = chainblock.Contains(transaction);

            int expectedCount = 1;

            Assert.IsTrue(transactionExist);
            Assert.AreEqual(expectedCount, chainblock.Count);
        }

        [Test]
        public void ChangeTransactionStatusShouldChangeTransactionStatus()
        {
            int transactionId = 85643;

            ITransaction transaction = new Transaction(
                transactionId,
                TransactionStatus.Aborted,
                "Kiro",
                "Ivo",
                100);

            chainblock.Add(transaction);

            chainblock.ChangeTransactionStatus(transactionId, TransactionStatus.Failed);

            ITransaction chainblockTransaction = chainblock.GetById(transactionId);

            Assert.AreEqual(TransactionStatus.Failed, chainblockTransaction.Status);
        }

        [Test]
        public void ChangeTransactionStatusShouldFailWhenTransactionDoesNotExist()
        {
            ITransaction transaction = new Transaction(
                6325,
                TransactionStatus.Successfull,
                "Ivan",
                "Kiro",
                34);

            chainblock.Add(transaction);

            Assert.Throws<ArgumentException>(() => chainblock.ChangeTransactionStatus(3333, TransactionStatus.Unauthorized));
        }

        [Test]
        public void RemoveTransactionByIdShouldRemoveTransactionIfExist()
        {
            ITransaction transaction = new Transaction(
                1,
                TransactionStatus.Failed,
                "Kiro",
                "Nasko",
                500);

            chainblock.Add(transaction);

            chainblock.RemoveTransactionById(1);

            bool exist = chainblock.Contains(1);

            Assert.AreEqual(0, chainblock.Count);
            Assert.IsFalse(exist);
        }

        [Test]
        public void RemoveTransactionByIdShouldThrowExceptionIfTransactionDoesNotExist()
        {
            ITransaction transaction = new Transaction(
                1,
                TransactionStatus.Failed,
                "Kiro",
                "Nasko",
                500);

            chainblock.Add(transaction);

            Assert.Throws<InvalidOperationException>(() => chainblock.RemoveTransactionById(15));
        }

        [Test]
        public void GetByIdShouldThrowExceptionIfInvaliIdIsPassed()
        {
            Assert.Throws<InvalidOperationException>(() => chainblock.GetById(123));
        }
    }    
}
