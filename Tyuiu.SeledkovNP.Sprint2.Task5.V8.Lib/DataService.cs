using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            // m и n поменаемые местами, из за некоректного написания задаия      incorrect

            string res;
                switch (m)
                {
                    case 1:
                        switch (n)
                        {
                            case 1:
                                m = 31;
                                n = 12;
                                break;
                            default:
                                n = n - 1;
                                switch (n)
                                {
                                    case 1:
                                    case 3:
                                    case 5:
                                    case 7:
                                    case 8:
                                    case 10:
                                        m = 31;
                                        break;
                                    case 2:
                                        m = 28;
                                        break;
                                    default:
                                        m = 30;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        m = m - 1;
                        break;
                }
                res = ($"{m}.0{n}");  //сам ответь
                return res;

            

        }
    }
}
