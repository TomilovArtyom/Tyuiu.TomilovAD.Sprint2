using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovAD.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y >= 3) && (y <= 4) && (((x >= 3) && (x <= 5)) || (((x >= 9) && (x <= 12)))) || ((y >= 5) && (y <= 6) && (x >= 2) && (x <= 12)) || ((y == 6) && (x == 13)) || ((y == 7) && (x >= 3) && (x <= 5)) || ((y >= 7) && (y <= 8) && (x >= 6) && (x <= 13)) || ((y >= 9) && (y <= 10) && (((x >= 5) && (x <= 6)) || ((x >= 11) && (x <= 12)))) || ((y == 11) && ((x == 6) || ((x >= 11) && (x <= 12)))) || ((y == 12) && (((x >= 4) && (x <= 6)) || ((x >= 12) && (x <= 13)))) || ((y == 13) && ((x == 2) || (x ==3))))
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
