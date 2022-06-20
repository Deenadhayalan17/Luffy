namespace Luffy
{
    public class Customer
    {
        public int Discount = 15;
        public string GreetMessage { get; set; }

        public string GreetAndJoinName(string FirstName,string SecondName)
        {
            GreetMessage= $"Hello, {FirstName} {SecondName}";
            Discount = 20;
            return GreetMessage;
        }
    }

  
}
