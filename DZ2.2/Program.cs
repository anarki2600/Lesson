using System;

namespace DZ2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float min;
            float max;
            float aver;

            Console.WriteLine("Введите минимальную температуру   ");
            min = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру  ");
            max = float.Parse(Console.ReadLine());

            aver = (min + max) / 2;
            Console.WriteLine("Средняя температура :  " + aver + "°C");

        first:
            Console.WriteLine("Введите порядковый номер текущего месяца от 1 до 12");
            string month = Console.ReadLine();              //Проверка корректного ввода данных;                           
            if (int.TryParse(month, out int num))
                Console.Write("Строка содержит только цифры     ");
            else
            {
                Console.Write("Нужно ввести только цифры     ");  //Если ввели не цифры, то заново переходим к first;
                goto first;
            }

            int month2 = Int32.Parse(month);       //Проверяем четность введённых данных;

            if (month2 % 2 == 1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }

            DateTime newDate = new DateTime(DateTime.Now.Year, month2, 1);   //Вывод названия месяца по его номеру;
            Console.WriteLine("Сейчас месяц :  " + newDate.ToString("MMMM"));

            if (aver > 0) // Задаем два условия 1- если t°>0, тогда период года hot; 2- если t°<0, тогда период года cold;
            {
                goto hot;
            }
            else
            {
                goto cold;
            }

        hot:
            switch (month2)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine(" Дождливая Зима ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Тёплая Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Жаркое Лето");
                    break;
                default:
                    Console.WriteLine("Хорошая Осень");
                    break;
            }
            {
                return;  //Прерываем программу, чтоб не выполнялось условие (холодно), когда уже выполнелось условие (тепло);
            }

        cold:
            switch (month2)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Снежная Зима ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Холодно для Весны");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Аномальное Лето");
                    break;
                default:
                    Console.WriteLine("Холодная Осень");
                    break;


            }
        }
    }
}
