using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul04
{
    class Program
    {
        static void Main(string[] args)
        {
            int denomination;
            int countDenomination;
            int n;
            Money money = new Money();
            Console.WriteLine("У вас купюры какого наминала:");
            denomination = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколька купюр такого наминала:");
            countDenomination = int.Parse(Console.ReadLine());
            money.Denomination = denomination;
            money.CountDenomination = countDenomination;
            money.Show();
            Console.WriteLine("Сколько стоит товар который вы хотите купить:");
            n = int.Parse(Console.ReadLine());
            money.Buying(n);
            money.FullBuying(n);
        }
    }
}
