using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TomilovAD.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(Math.Pow(x * ((x + 1) / (x - 1)), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    return Math.Round((Math.Pow(x, 4) - Math.Pow(Math.Cos(x), 5) + 3) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12), 3);
                }
                else
                {
                    if ((-7 < x) && (x < 0))
                    {
                        return Math.Round((1 + (Math.Sqrt(x + 3) / Math.Pow(x, 2))), 3);
                    }
                    else
                    {
                        if (x < -7)
                        {
                            return Math.Round(Math.Pow(x, 2) + 10 * x - (1 / x), 3);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            }    
        }
    }

