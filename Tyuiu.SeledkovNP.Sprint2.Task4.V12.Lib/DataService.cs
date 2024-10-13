using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            // ':' это разделения условий                    '/' это деление
            
            //                               условие:              первое                                                                             второе
            double z = Math.Sqrt(x) > y * 2    ?     Math.Pow(7 + 2 / Math.Pow(y, 2), x)    :     (Math.Pow(3 * x, x) - Math.Pow(Math.Cos(y), 2) + 10) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 12);
            return Math.Round(z, 3);

        }
    }
}
