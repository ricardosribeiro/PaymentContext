using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
   public class Name:ValueObject
   {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName.ToUpper();
            LastName = lastName.ToUpper();
            
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3,"FirstName", "Nome deve ter no mínimo {1} caracteres.")
                .HasMaxLen(FirstName, 50,"FirstName","Nome deve ter no máximo {1} caracteres")
                .HasMinLen(LastName, 3, "LastName", "Sobrenome deve ter no mínimo {1} caracteres")
                .HasMaxLen(LastName, 50,"LastName", "Sobrenome deve ter no máximo {1}caracteres")          
            );
        }

        public string FirstName  { get; private set; }
        public string LastName { get; private set; }
   }


    
}