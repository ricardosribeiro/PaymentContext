using System;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment: Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, string address, Email email)
        {
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            PaidNumber = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public DateTime PaidDate{get; private set;}
        public DateTime ExpireDate{get; private set;}
        public decimal Total{get; private set;}
        public decimal TotalPaid{get; private set;}
        public string PaidNumber{get; private set;}
        public string Payer{get; private set;}
        public Document Document{get; private set;}
        public string Address {get; private set;}
        public Email Email { get; private set; }
    }    
}