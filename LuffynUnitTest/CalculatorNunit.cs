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
    }
}
