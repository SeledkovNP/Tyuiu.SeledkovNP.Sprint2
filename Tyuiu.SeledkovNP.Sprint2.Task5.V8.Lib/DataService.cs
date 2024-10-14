using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SeledkovNP.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            
           
                string res;
                switch (n)
                {
                    case 1:
                        switch (m)
                        {
                            case 1:
                                n = 31;
                                m = 12;
                                break;
                            default:
                                m = m - 1;
                                switch (m)
                                {
                                    case 1:
                                    case 3:
                                    case 5:
                                    case 7:
                                    case 8:
                                    case 10:
                                        n = 31;
                                        break;
                                    case 2:
                                        n = 28;
                                        break;
                                    default:
                                        n = 30;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        n = n - 1;
                        break;
                }
                res = ($"{n}.{m}");  //сам ответь
                return res;

            

        }
    }
}
