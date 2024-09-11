using BANK.classes;

List<User> clients = new List<User>();
while (true)
{
    Console.WriteLine("Tanlang (raqam bilan):");
    Console.WriteLine("1: Foydalanuvchilar uchun");
    Console.WriteLine("2: Bank hodimlari uchun");
    Console.Write("Tanlov: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1: {
            Console.WriteLine("Tanlang (raqam bilan):");
            Console.WriteLine("1: Yangi foydalanuvchilar uchun");
            Console.WriteLine("2: Bankda shoti bor foydalanuvchilar");
            Console.Write("Tanlov: ");
            int numberUser = int.Parse(Console.ReadLine());
            foreach (var item in clients)
            {
                Console.WriteLine(item);
            }

            switch (numberUser)
            {
                case 1: {
                    Console.WriteLine("1: Foydalanuvchi ismi");
                    string name = Console.ReadLine();
                    Console.WriteLine("2: Foydalanuvchi accountNumberi");
                    int accounNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("3: Foydalanuvchilar balansi $");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    bool boolean = true;
                    clients.Add(new User(name, accounNumber, balance, boolean));
                };
                break;
                case 2:
                {
                    foreach (var blockitem in clients)
                    {
                        

                        Console.WriteLine("1: AccountNumberingizni kiriting");
                        int userAccount = int.Parse(Console.ReadLine());
                        foreach (var item in clients)
                        {
                            if (userAccount == item.AccountNumber)
                            {
                                if (item.Bool == false)
                                {
                                    Console.WriteLine($"sizning bu {item.Name} akkauntingiz bank tomonidan bloklangan");
                                } else{
                                    Console.WriteLine("Tanlang (raqam bilan):");
                                    Console.WriteLine("1: Depozit qoyish");
                                    Console.WriteLine("2: Pul o'tkazmalari");
                                    Console.WriteLine("2: Pul Yechib olish");
                                    Console.Write("Tanlov: ");
                                    int workUsers = int.Parse(Console.ReadLine());

                                    switch (workUsers)
                                    {
                                        case 1:

                                        {
                                        Console.WriteLine("depozit summasi: ");
                                        decimal depSum = decimal.Parse(Console.ReadLine());
                                        item.Balance += depSum;

                                        Console.WriteLine(item);
                                        }
                                        break;
                                    
                                        case 2:
                                        {
                                            Console.WriteLine("Kimga pul otkazasiz accounNumberini kiriting: ");
                                            int inpAccNum = int.Parse(Console.ReadLine());
                                            foreach (var items in clients)
                                            {
                                                if (inpAccNum == items.AccountNumber)
                                                {
                                                    Console.WriteLine("summani kiritng: ");
                                                    decimal inpsendmoney = int.Parse(Console.ReadLine());
                                                    item.Balance -= inpsendmoney;

                                                    items.Balance += inpsendmoney;
                                                    Console.WriteLine(items);
                                                }
                                            }
                                        }
                                        break;
                                    
                                        case 3: 
                                        {
                                            Console.WriteLine("Qanch pul yechib olasiz: ");
                                            int inpMinusMoney = int.Parse(Console.ReadLine());
                                            item.Balance -= inpMinusMoney;
                                        }
                                        break;
                                    } 
                                }
                            }
                        }
                    }
                }

                break;
            }
        };
        break;
        
        case 2:
        {
            Console.WriteLine("Tanlang (raqam bilan):");
            Console.WriteLine("1: Mijoz hisobini yopish");
            Console.WriteLine("2: Mijoz uchun hisob ochish");
            Console.Write("Tanlov: ");
            int findBank = int.Parse(Console.ReadLine());

            switch (findBank)
            {
                case 1:
                {
                    foreach (var bankItem in clients)
                    {                        
                        Console.Write("accountNumberni kiriting: ");
                        int bankblock = int.Parse(Console.ReadLine());

                        if (bankblock == bankItem.AccountNumber)
                        {
                            bankItem.Bool = false;
                            Console.WriteLine($"Bu '{bankItem.Name}' foydalanuvchi blocklandi.");
                        }
                    }
                }
                break;

                case 2:
                {
                    Console.WriteLine("1: Foydalanuvchi ismi");
                    string name = Console.ReadLine();
                    Console.WriteLine("2: Foydalanuvchi accountNumberi");
                    int accounNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("3: Foydalanuvchilar balansi $");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    bool boolean = true;
                    clients.Add(new User(name, accounNumber, balance, boolean));
                }
                break;
            }
        }
        break;
    
    }
}


