using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription(){
            var name  = new Name("Bruce","Wayne");
            var document = new Document("33987689893", Domain.Enums.EDocumentType.CPF);
            var email = new Email("bruce.wayne@outlook.com");
            var address = new Address("Rua 2", "Campinas", "13061202","SP","Brasil");
            var student = new Student(name, document, email, address);
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadNoActiveSubscription(){
            Assert.Fail();
        }
    }
}