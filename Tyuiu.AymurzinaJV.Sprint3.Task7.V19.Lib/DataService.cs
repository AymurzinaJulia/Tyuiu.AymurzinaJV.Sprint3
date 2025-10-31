using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AymurzinaJV.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) - 2) == 0) res[count] = 0;
                else
                {
                    y = (5 * x + 2.5) / (Math.Sin(x) - 2) + 2;
                    res[count] = Math.Round(y, 2);
                }
                count++;
            }
            return res;
        }
    }
}
