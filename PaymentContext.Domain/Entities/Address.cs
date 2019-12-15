using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Address: Entity   
    {
        public Address (string street, string city, string postalCode, string state, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            State = state;
            Country = country;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "Rua deve ter no mínimo 3 caracteres")
                .HasMaxLen(Street, 200, "Address.Street", "Rua deve ter no máximo 200 caracteres")
                .HasMinLen(City, 3, "Address.City", "Cidade  deve ter no mínimo 3 caracteres")
                .HasMaxLen(City, 50, "Address.City", "Cidade deve ter no máximo 50 caracteres")
                .HasExactLengthIfNotNullOrEmpty(PostalCode, 8 ,"Address.PostalCode", "CEP deve ter 8 caracteres" )
                .HasExactLengthIfNotNullOrEmpty(State, 2, "Address.State", "Estado deve ter 2 caracteres")
                .HasMinLen(Country, 3, "Address.Country", "Pais deve ter no mínimo 3 caractres")
                .HasMaxLen(Country,50, "Address.Country", "Pais deve ter no máximo 50 caracteres")
            );
        }
        public string Street {get; private set;}
        public string City { get; private set; }
        public string PostalCode { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

    }
}