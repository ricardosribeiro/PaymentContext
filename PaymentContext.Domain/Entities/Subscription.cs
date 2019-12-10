using System;
using System.Collections.Generic;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription: Entity
    {
        private  List<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = false;

            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate{get; private set;}
        public DateTime? ExpireDate{get; private set;}        
        public bool Active {get; private set;}
        public IReadOnlyCollection<Payment> Payments {get {return _payments;}}

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }
        public void TurnOn()
        {
           Active = true;
           LastUpdateDate = DateTime.Now;
        }
        public void TurnOff()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }

    }
}