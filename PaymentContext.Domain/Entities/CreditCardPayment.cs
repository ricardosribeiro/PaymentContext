using System;
using Flunt.Validations;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment: Payment
    {
        public CreditCardPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email, string cardHolderName, string cardNumber, string lastTransactionNumber) 
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(CardHolderName,3, "CreditCardPayment.CardHolderName","Nome do titular deve ter no mínimo 3 caracteres")
                .HasMaxLen(CardHolderName,50, "CreditCardPayment.CardHolderName","Nome do titular deve ter no máximo 50 caracteres")
            );
        }

        public string CardHolderName { get; private set; }
        public string CardNumber{get; private set;}
        public string LastTransactionNumber{get; private set;}
    }
}