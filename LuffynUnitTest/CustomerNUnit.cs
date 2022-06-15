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
            Assert.That(fullname, Does.Contain(","));
            Assert.That(fullname, Does.Contain("Deena Dhayalan"));//case sensitive 
            Assert.That(fullname, Does.Contain("Deena dhayalan").IgnoreCase);//so we use ignore case
            Assert.That(fullname, Does.StartWith("Hello,"));
            Assert.That(fullname, Does.EndWith("Dhayalan"));
            Assert.That(fullname, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));



        }
    }
}
