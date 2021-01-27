using System;
namespace HelloWorld
{
    class Program
    {
        [Flags]
        public enum Day
        {
            Нулевой_день = 0b_0000000, //пока такой костыль, чтоб дни шли от 1 до 7 (а не от 0 до 6);
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }
        static void Main(string[] args)
        {
            Day office1 = Day.Понедельник | Day.Вторник | Day.Среда | Day.Четверг | Day.Пятница | Day.Суббота | Day.Воскресенье;
            Day office2 = Day.Вторник | Day.Среда | Day.Четверг | Day.Пятница;

            Console.WriteLine("Введите порядковый № дня недели от 1 до 7");
            int day = int.Parse(Console.ReadLine());

            Day d = (Day)Enum.GetValues(typeof(Day)).GetValue(day);
            string i = Enum.GetName(typeof(Day), d);
            Day time1 = office1 & d;
            Day time2 = office2 & d;

            bool open1 = time1 == d;
            bool open2 = time2 == d;

            string of1;
            string of2;

            if (open1)
            {
                of1 = "Офис 1 открыт";
            }
            else
            {
                of1 = "Офис 1 закрыт";
            }
            if (open2)
            {
                of2 = "Офис 2 открыт";
            }
            else
            {
                of2 = "Офис 2 закрыт";
            }
            Console.WriteLine("Сегодня  "+i+"   "+of1+"  " +of2);
        }
    }
}
