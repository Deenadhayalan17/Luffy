using Luffy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuffyMSTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
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
