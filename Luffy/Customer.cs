using System;

namespace Luffy
{
    public class Customer
    {
        public int Discount = 15;
        public int OrderTotal;

        
        public string GreetMessage { get; set; }

        public string GreetAndJoinName(string FirstName,string SecondName)
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                throw new ArgumentException("Empty First Name");
            }
            GreetMessage= $"Hello, {FirstName} {SecondName}";
            Discount = 20;
            return GreetMessage;
        }
        public CustomerType GetCustomerdetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }
    }
    public class CustomerType { }

    public class BasicCustomer : CustomerType { }

    public class PlatinumCustomer : CustomerType { }




}
