using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student: Entity
    {

        private List<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email; 
            Address = address;

            _subscriptions = new List<Subscription>();  

            AddNotifications(Name, Document, Email);     
        }

        public Name Name{get; private set;}
        public Document Document { get; private set; }
        public Email Email {get; private set;}
        public Address Address {get; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions {get {return _subscriptions;}}

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
