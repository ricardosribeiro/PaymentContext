using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
     
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid(){
                var doc = new Document("123", EDocumentType.CNPJ);
                Assert.IsTrue(doc.Invalid);
        }
        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid(){
            var doc = new Document("57986515000120", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);        
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid(){
            var doc = new Document("123",EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }
        
        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid(){
            var doc = new Document("33987689893",EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}