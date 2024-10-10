using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {

            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c);                  //    или    одно верное
            res[1] = (a < b) & (d > c);                 //    и      оба верны
            res[2] = (a + 10 < b) || (d - 3 < c);      //    или    одно верное
            res[3] = (a < b) && (d > c);              //    и      оба верны
            res[4] = !(!res[0]);                     //   отрицания   первого выражения
            res[5] = (a > b) ^ (d > c);             //    вычитания     первое верно, второе тоже, значить отрицания
            return res;

        }
    }
}
