using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
          var subscription = new Subscription(null);
          var student = new Student("Gabriel", "Padilha", "123.456.789-01", "gabriel@gmail.com");
          student.AddSubscription(subscription);
        }
      }
}
