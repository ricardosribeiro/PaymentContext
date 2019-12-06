using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student()
        {
            var student = new Student("Ricardo", "Ribeiro", "42.346.683-5", "hello@outlook.com.br");   
            student.AddSubscription(new Subscription(null));                       
        }
    }
}