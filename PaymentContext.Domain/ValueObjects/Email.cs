using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Email:ValueObject
    {
        public Email(string address)
        {
            Address = address;

            if(string.IsNullOrEmpty(Address))
                AddNotification(Address, "Invalid address");
        }

        public string Address { get; private set; }
    }
}