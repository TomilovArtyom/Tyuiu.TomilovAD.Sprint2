using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovAD.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res;

            int z;

            z = (k + d - 1) - ((k + d - 1)/7)*7;

                switch (z)
                {
                    case 0:
                        res = "Воскресение";
                        break;

                    case 1:
                        res = "Понедельник";
                        break;

                    case 2:
                        res = "Воскресение";
                        break;

                    case 3:
                        res = "Среда";
                        break;

                    case 4:
                        res = "Четверг";
                        break;

                    case 5:
                        res = "Пятница";
                        break;

                    case 6:
                        res = "Суббота";
                        break;
                    default: throw new NotImplementedException();
                }
                return res;

                
        }
    }
}
