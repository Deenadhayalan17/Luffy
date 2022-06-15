namespace Luffy
{
    public class Customer
    {
        public string GreetMessage { get; set; }

        public string GreetAndJoinName(string FirstName,string SecondName)
        {
            GreetMessage= $"Hello, {FirstName} {SecondName}";
            return GreetMessage;
        }
    }

  
}
