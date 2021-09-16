using System;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace LegacyAppTesting.ConsoleApp.Tests.Unit
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMockBoredClient()
        {
            var mockClient = new Mock<IBoredClient>();
            mockClient.Setup(x => x.FindSomethingToDo()).Returns(Task.FromResult(new BoredResponse()
            {
                Activity = "Extreme Ironing",
                Accessibility = 0.1,
                Key = "EXTREME_IRONING",
                Participants = 1,
                Price = 10,
                Type = "Extreme Sports"
            }));
            //Setup
            new TestBoredClientFactory().SetClient(mockClient.Object);
            var result = new BoredomSuggestionService().FindSomethingToDo().Result;
            
            Assert.AreEqual("Extreme Ironing", result.Activity);
            Assert.AreEqual("EXTREME_IRONING", result.Key);
            Assert.AreEqual("Extreme Sports", result.Type);
        }
    }
}