using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= -1) && (x <= (Math.Sqrt(2) / 2)) && (y >= -1) && (y <= 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }
    }
}
