using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
          var name = new Name("Teste", "Teste");
          foreach (var not in name.Notifications) 
          {
            Console.WriteLine(not.ToString());
          }
        //   var subscription = new Subscription(null);
        //   var student = new Student("Gabriel", "Padilha", "123.456.789-01", "gabriel@gmail.com");
        //   student.AddSubscription(subscription);
        }
      }
}
