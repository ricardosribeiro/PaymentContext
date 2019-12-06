using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {

        private List<Subscription> _subscriptions;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;     

            _subscriptions = new List<Subscription>();       
        }

        public string FirstName{get; private set;}
        public string LastName{get; private set;}        
        public string Document { get; private set; }
        public string Email {get; private set;}
        public string Address {get; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions {get {return _subscriptions;}}

        public void SetName(string firstName, string lastName)
        {
            FirstName = string.IsNullOrEmpty(firstName)?string.Empty:firstName.ToUpper();
            LastName = string.IsNullOrEmpty(lastName)?string.Empty:lastName.ToUpper();
        }

        public void SetAddress(string address)
        {
           Address = string.IsNullOrEmpty(address)? string.Empty: address.ToUpper();
        }
        
        public void AddSubscription(Subscription subscription)
        {       
            TurnOffAllSubscription();
            _subscriptions.Add(subscription);         
        }     
         
        private void TurnOffAllSubscription()
        {
            if(_subscriptions.Any())
            foreach(var sub in _subscriptions)
                sub.TurnOff();
        }      
   
    }
}
