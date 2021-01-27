using System;

namespace DZ2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0026;
            DateTime dTime = DateTime.Now;
            var term = 218_203_57;
            var merch = 971_000_027_149;
            string mCard = "000_000_004_1010";
            string e1 = "0119";
            double sum = 298.00;
            double comission = 0.00;


            Console.WriteLine("     *****************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     |               СБЕРБАНК                |");
            Console.ResetColor();
            Console.WriteLine("     |          PAPA GRILL IRKUTSK           |");
            Console.WriteLine("     |   "+dTime+"  "+"  чек №   "+a+"   |"  );
            Console.WriteLine("     |   ПАО СБЕРБАНК                ОПЛАТА  |");
            Console.WriteLine("     |   Терминал:                  "+term+" |");
            Console.WriteLine("     |   Мерчант:               "+merch+" |");
            Console.WriteLine("     |   MASTERCARD        A"+mCard+" |");
            Console.WriteLine("     |   Карта: (Е1)        ************"+e1+" |");
            Console.WriteLine("     |   Клиент:                             |");
            Console.WriteLine("     |   Сумма (Руб):                        |");
            Console.WriteLine("     |                                "+sum.ToString("0.00")+" |");
            Console.WriteLine("     |   Комиссия за операцию -     "+comission.ToString("0.00")+"Руб. |");
            Console.WriteLine("     |                                       |");
            Console.WriteLine("     |             ОДОБРЕНО                  |");
            Console.WriteLine("     *****************************************");

        }
    }
}
