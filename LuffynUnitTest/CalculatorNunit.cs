using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luffy
{
    [TestFixture]
    public class CalculatorNunit
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange             
            Calculator cal = new Calculator();

            //Act
            int result = cal.AddNumber(5, 4);

            //Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void IsOddNumber_InputEvenNumber_ReturnFalse()
        {
            //arrange
            Calculator cal = new();


            //act
            bool result = cal.IsOddNumber(4);
            //assert

            //Assert.AreEqual(false, result);
            Assert.That(result, Is.EqualTo(false));
            //Assert.IsFalse(result);


        }
        [Test]
        [TestCase(9)]
        [TestCase(11)]// passing parameter more than one 

        public void IsOddNumber_InputOddNumber_ReturnTrue(int a)
        {
            //arrange
            Calculator cal = new();


            //act
            bool result = cal.IsOddNumber(a);
            //assert

            //Assert.AreEqual(true, result);
            Assert.That(result, Is.EqualTo(true));
            //Assert.IsTrue(result);


        }
        [Test]
        [TestCase(10,ExpectedResult =false)]
        [TestCase(17, ExpectedResult = true)]

        public bool IsOddNumber_InoutNumber_ReturnTrueIfOdd(int a)
        {
            Calculator cal = new();
            return cal.IsOddNumber(a);

        }
    }
}
