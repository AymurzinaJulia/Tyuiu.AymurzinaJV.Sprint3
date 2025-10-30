using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AymurzinaJV.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double constsin = Math.Sin(1);
            double sinpow = Math.Pow(constsin, -7);

            double res = 1.0;

            for (int i = startValue; i <= stopValue; i++)
            {
                double a = Math.Pow(i / sinpow, -2);
                res *= a;
            }

            return Math.Round(res, 3);
        }
    }
}
