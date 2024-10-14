using Tyuiu.SeledkovNP.Sprint2.Task5.V8.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Селедков Н. П. | Смартб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m       *");
            Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным n и m определить дату*");
            Console.WriteLine("* предыдущего дня (принять, что n и m не характеризуют 1 января).         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            // Первый дольжень идты день
            string res;

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                res = "Eror 404";

            }
            else
            {
                res = "Предыдущая дата:" + ds.FindDateOfPreviousDay(m, n);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
