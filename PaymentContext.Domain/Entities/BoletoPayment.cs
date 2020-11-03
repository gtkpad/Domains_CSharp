using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
      public BoletoPayment(
        string barCode, 
        string boletoNumber, 
        string number, 
        DateTime paidDate, 
        DateTime expireDate, 
        decimal paid, 
        decimal totalPaid, 
        string payer, 
        string document, 
        string address, 
        string email) : base(
          number, 
          paidDate, 
          expireDate, 
          paid, 
          totalPaid, 
          payer, 
          document, 
          address, 
          email)
      {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
      }

      public string BarCode { get; private set; }

      public string BoletoNumber { get; private set; }
    }
}