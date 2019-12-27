namespace PaymentContext.Domain.Repositorie
{
    public interface IStudentRepository
    {
        bool EmailExists(string email);
        bool DocumentExists(string document);
        void Create();    
    } 
}