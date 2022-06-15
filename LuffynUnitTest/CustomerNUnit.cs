using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luffy
{
    [TestFixture]
    public class CustomerNUnit
    {
        [Test]
        public void GreetAndJoinName_InputFirstNameAndLastName_returnFullName()
        {
            //Arrange
            var customer = new Customer();
            //Act
            string fullname =customer.GreetAndJoinName("Deena", "Dhayalan");
            //Assert
            Assert.That(fullname, Is.EqualTo("Hello, Deena Dhayalan"));
            Assert.AreEqual(fullname, "Hello, Deena Dhayalan");

        }
    }
}
