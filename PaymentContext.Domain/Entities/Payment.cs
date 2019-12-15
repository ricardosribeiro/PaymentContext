using System;
using Flunt.Validations;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment: Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
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

            AddNotifications(Document, Email, Address);
            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(PaidNumber, "Payment.PaidNumber", "Número do pagamento é obrigatório")
                .HasMinLen(Payer, 3, "Payment.Payer", "Pagador dever ter no mínimo 3 caracteres")
                .HasMaxLen(Payer, 100, "Payment.Payer", "Pagador deve ter no máximo 100 caracteres")
                .IsGreaterThan(ExpireDate, PaidDate, "Payment.ExpireDate","Data de expiração deve ser maior que Data de pagamento")
                .IsGreaterOrEqualsThan(TotalPaid, Total, "Payment.TotalPaid", "Total pago deve ser maior que Total")                
            );
        }

        public DateTime PaidDate{get; private set;}
        public DateTime ExpireDate{get; private set;}
        public decimal Total{get; private set;}
        public decimal TotalPaid{get; private set;}
        public string PaidNumber{get; private set;}
        public string Payer{get; private set;}
        public Document Document{get; private set;}
        public Address Address {get; private set;}
        public Email Email { get; private set; }
    }    
}