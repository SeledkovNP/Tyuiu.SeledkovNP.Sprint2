using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {

        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 800;
            res[1] = x != 1075;
            res[2] = y < x;
            res[3] = x > y + 899;
            res[4] = y + 800 <= x;
            res[5] = y >= x;

            return res;

        }

    }
}
