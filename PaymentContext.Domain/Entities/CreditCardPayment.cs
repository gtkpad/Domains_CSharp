using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
      public CreditCardPayment(
        string cardHolderName, 
        string cardNumber,
        string lastTransactionNumber, 
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
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
      }

      public string CardHolderName { get; private set; }

      public string CardNumber { get; private set; }
    
      public string LastTransactionNumber { get; private set; }
    }
}