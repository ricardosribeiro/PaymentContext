using System;
using Flunt.Validations;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment: Payment
    {
        public BoletoPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email, string barCode, string boletoNumber) 
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(BarCode, "BoletoPaymento.BarCode","Código de barras é obrigatório")
                .IsNullOrEmpty(BoletoNumber,"BoletoPayment.BoletoNumber", "Número do boleto é obrigatório")
            );        
        }

        public string BarCode { get; private set; }    
        public string BoletoNumber{get; private set;}
    }
}