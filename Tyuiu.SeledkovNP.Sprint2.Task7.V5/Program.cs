using Tyuiu.SeledkovNP.Sprint2.Task7.V5.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task7.V5
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
            Console.WriteLine("* Тема: Итоговый проект                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами X*");
            Console.WriteLine("* Y в заштрихованной области.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            // фото

            Console.WriteLine("Введите значение  Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение  Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

           
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка НЕ находится в заштрихованной области");
            }

            Console.ReadKey();

        }
    }
}
