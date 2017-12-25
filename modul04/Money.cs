using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul04
{
    public class Money
    {
        private int denomination;

        private int countDenomination;
        public int Denomination
        {
            get
            {
                return denomination;
            }
            set
            {
                if ((value > 0) && (value < 5000))
                {
                    denomination = value;
                }
            }
        }

        public int CountDenomination
        {
            get
            {
                return countDenomination;
            }
            set
            {
                if ((value > 0) && (value < 5000))
                {
                    countDenomination = value;
                }
            }
        }
        public int Summ
        {
            get
            {
                return denomination * countDenomination;
            }
            private set
            {

            }
        }

        public void Show()
        {
            Console.WriteLine("У вас {0} купюр по {1}тг", countDenomination, denomination);
        }

        public void Buying(int n)
        {
            if(n <= (denomination * countDenomination))
            {
                Console.WriteLine("У вас хвотает средст на покупку предмета");
            }
            else
            {
                Console.WriteLine("У вас недастаточно средст на покупку предмета");
            }
        }

        public void FullBuying(int n)
        {
            if(n <= (denomination * countDenomination))
            {
                int countItem = (denomination * countDenomination) / n;
                Console.WriteLine("На ваше средства можно {0} предметов купить");
            }
        }
    }
}
