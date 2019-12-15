using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Document: ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            if(string.IsNullOrEmpty(Number))
                AddNotification(Number, "Invalid number");    

            if(Type.Equals(EDocumentType.CNPJ) && Number.Length!=18)
                AddNotification(Number, "Invalid CNPJ");

            if(Type.Equals(EDocumentType.CPF) && Number.Length!=14)
                AddNotification(Number, "Invalid CPF");            
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

    }
}