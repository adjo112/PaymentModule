using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using PaymentModule.Controllers;

namespace PaymentTests
{
    public class PayTests
    {
        ProcessPaymentController processPaymentController;
       


        [SetUp]
        public void Setup()
        {
            processPaymentController = new ProcessPaymentController();
           
        }

        [TearDown]
        public void TearDown()
        {
            processPaymentController = null;
        }

        [Test]
        public void Test1()
        {
            int expectedResult = 5000;
            ObjectResult result = (ObjectResult)processPaymentController.ProcessPayment("11112222333344", 20000, 15000);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public void Test2()
        {
            int expectedResult = 20000;
            ObjectResult result = (ObjectResult)processPaymentController.ProcessPayment("12345678912345", 30000, 10000);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public void Test3()
        {
            int expectedResult = 15000;
            ObjectResult result = (ObjectResult)processPaymentController.ProcessPayment("55554444222288", 45000, 30000);
            Assert.AreEqual(expectedResult, result.Value);
            
        }
    }
}