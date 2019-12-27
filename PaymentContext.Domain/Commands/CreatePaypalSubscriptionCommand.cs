using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreatePaypalSubscriptionCommand: ICommand
    {
        public string FirstName  { get;  set; }
        public string LastName { get;  set; }
        public string Document { get;  set; }
        public string Email { get;  set; }

        public string TransactionCode{get;  set;}        
        public string PaidNumber{get;  set;}
        public DateTime PaidDate{get;  set;}
        public DateTime ExpireDate{get;  set;}
        public decimal Total{get;  set;}
        public decimal TotalPaid{get;  set;}
        public string Payer{get;  set;}
        public string PayerEmail { get;  set; }
        public Document PayerDocument{get;  set;}
        public EDocumentType PayerDocumentType{get;set;}
        public string Street {get; private set;}
        public string City { get; private set; }
        public string PostalCode { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }




    }
}