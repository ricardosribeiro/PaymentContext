using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student: Entity
    {

        private List<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email; 
            _subscriptions = new List<Subscription>();       
        }

        public Name Name{get; private set;}
        public Document Document { get; private set; }
        public Email Email {get; private set;}
        public string Address {get; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions {get {return _subscriptions;}}


        public void SetAddress(string address)
        {
           Address = address.Equals(string.Empty)? string.Empty: address.ToUpper();
        }
        
        public void AddSubscription(Subscription subscription)
        {       
            TurnOffAllSubscriptions();
            _subscriptions.Add(subscription);         
        }     
         
        private void TurnOffAllSubscriptions()
        {
            if(_subscriptions.Any())
            foreach(var sub in _subscriptions)
                sub.TurnOff();
        }      
   
    }
}
