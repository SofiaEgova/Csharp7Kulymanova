using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using AutoFixture;
using Moq;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string name = "Boris";
            var bank = new Bank();

            // Act
            bank.createClient(name);

            //Assert 
            Assert.IsNotNull(bank.getClient(name));
        }

        [TestMethod()]
        public void TestMethod2()
        {
            // Arrange
            var mockClient = new ClientFake();
            var account = new Account(1);

            // Act
            mockClient.addAccount(account);

            //Assert 
            Assert.AreEqual(mockClient.acc.getId(),account.getId());
        }
    }
}
