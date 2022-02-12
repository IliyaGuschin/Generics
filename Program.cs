using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount<int> Acc1 = new BankAccount<int>();
            Acc1.Name = "Соколов Петр Федорович";
            Acc1.Number = 12345;
            Acc1.Account = 5000;
            Acc1.ToPrint();

            BankAccount<string> Acc2 = new BankAccount<string>();
            Acc2.Name = "Лабутенко Прокл Кузьмич";
            Acc2.Number = "78901";
            Acc2.Account = 25000;
            Acc2.ToPrint();

            BankAccount<double> Acc3 = new BankAccount<double>();
            Acc3.Name = "Перекидкин Кит Фомич";
            Acc3.Number = 77777.77;
            Acc3.Account = 125000.25;
            Acc3.ToPrint();

        }

        class BankAccount<T>
        {
            public string Name { get; set; }

            public T Number { get; set; }

            public double Account { get; set; }

            public void ToPrint()
            {
                Console.WriteLine("\n");
                Console.WriteLine("Владелец счета {0}", this.Name);
                Console.WriteLine("Номер счета {0}", this.Number);
                Console.WriteLine("Баланс счета {0}", this.Account);
            }

        }
    }
}

