using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
   public class Name:ValueObject
   {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName.Equals(string.Empty)?string.Empty:FirstName.Trim().ToUpper();
            LastName = lastName.Equals(string.Empty)? string.Empty: lastName.Trim().ToUpper();
        }

        public string FirstName  { get; private set; }
        public string LastName { get; private set; }
   }


    
}