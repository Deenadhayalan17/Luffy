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
        private Customer customer { get; set; }

        [SetUp]
        public void Setup()
        {
            customer = new Customer();

        }
        [Test] 
        public void GreetAndJoinName_InputFirstNameAndLastName_returnFullName()
        {
            //Arrange
            //var customer = new Customer();
            //Act
            string fullname =customer.GreetAndJoinName("Deena", "Dhayalan");
            //Assert
            Assert.Multiple(() => {
                Assert.That(fullname, Is.EqualTo("Hello, Deena Dhayalan"));
                Assert.AreEqual(fullname, "Hello, Deena Dhayalan");
                Assert.That(fullname, Does.Contain(","));
                Assert.That(fullname, Does.Contain("Deena Dhayalan"));//case sensitive 
                Assert.That(fullname, Does.Contain("Deena dhayalan").IgnoreCase);//so we use ignore case
                Assert.That(fullname, Does.StartWith("Hello,"));
                Assert.That(fullname, Does.EndWith("Dhayalan"));
                Assert.That(fullname, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));

            });
            
        }
        [Test]

        public void GreetAndJoinName_nocall_ReturnNull()
        {
            //arrange
            //var customer = new Customer();

            //act

            //assert
            Assert.IsNull(customer.GreetMessage);
        }

        [Test]
        public void DiscountCheck_DefaultCUstomer_ResturnDiscountInrange()
        {
            int output = customer.Discount;

            Assert.That(output, Is.InRange(15, 25));
        }
        [Test]
        public void GreetAndJoinName_EmptyFirstName_ThrowException()
        {
            var expectiondetails = Assert.Throws<ArgumentException>(
                ()=> customer.GreetAndJoinName("","Ben"));
            Assert.AreEqual("Empty First Name", expectiondetails.Message);

            Assert.That(() =>customer.GreetAndJoinName("","Mass"),
                Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));

            // check only exception 

            Assert.Throws<ArgumentException>(
                     () => customer.GreetAndJoinName("", "Ben"));

            Assert.That(() => customer.GreetAndJoinName("", "Mass"),
                Throws.ArgumentException);
        }
        [Test]

        public void CustomerType_CreateCustomerLessThan100_ReturnBasicCustomer()
        {
            customer.OrderTotal = 20;
            var result = customer.GetCustomerdetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }
        [Test]
        public void CustomerType_CreateCustomerGreaterThan100_ReturnPlatinumCustomer()
        {
            customer.OrderTotal = 120;
            var result = customer.GetCustomerdetails();
            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
        }

    }
}
