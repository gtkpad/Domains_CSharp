using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
  [TestClass]
  public class SubscriptionHandlerTests
  {
    // Red, Green, Refactor

    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
      var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
      var command = new CreateBoletoSubscriptionCommand();

      command.FirstName = "Bruce";
      command.LastName = "Wayne";
      command.Document = "99999999999";
      command.Email = "email@email.com";

      command.BarCode = "123456789123";
      command.BoletoNumber = "4894123";
      command.PaymentNumber = "6465654";
      command.PaidDate = DateTime.Now;
      command.ExpireDate = DateTime.Now.AddMonths(1);
      command.Total = 60;
      command.TotalPaid = 60;
      command.Payer = "WAYNE CORP";
      command.PayerDocument = "12345678911";
      command.PayerDocumentType = EDocumentType.CPF;
      command.PayerEmail = "batman@dc.com";
      command.Street = "Rua 1";
      command.Number = "123";
      command.Neighborhood = "Centro";
      command.City = "Gothan";
      command.State = "RS";
      command.Country = "BR";
      command.ZipCode = "12375000";

      handler.Handle(command);
      Assert.AreEqual(false, handler.Valid);
    }
  }
}
