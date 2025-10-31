using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AymurzinaJV.Sprint3.Task6.V2.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
