namespace BANK.classes
{
    public class User
    {
        public string Name {get; set;}
        public int AccountNumber {get; set;}
        public decimal Balance {get; set;}
        public bool Bool {get; set;}

       public User (string name, int accounNumber, decimal balance, bool boolean)
       {
            Name = name;
            AccountNumber = accounNumber;
            Balance = balance;
            Bool = boolean;
       }
       public override string ToString()
        {
            return $"Ism: {Name}, Hisob raqam: {AccountNumber}, Balans: {Balance}";
        }
    }
}