using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CreditcardValidator.Test.Unit
{
    [TestFixture]
    public class NameValidatorTestUnit
    {
        private NameValidator _uut;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _uut = new NameValidator();
        }

        [Test]
        public void Name_CheckFornameAndLastname()
        {
            //Arrange
            string Teststring = "Bjarke Hansen";
            
            //Act an Assert
            Assert.That(_uut.ValidateName(Teststring), Is.EqualTo(true));
        }

    }
}
