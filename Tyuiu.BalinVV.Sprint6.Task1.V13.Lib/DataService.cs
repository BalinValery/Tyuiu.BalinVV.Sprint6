using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BalinVV.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int ind = 0;
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double z;
            for (int i = startValue; i <= stopValue; i++)
            {
                z = ((3 * Math.Cos(i)) / (4 * i - 0.5)) + Math.Sin(i) - 5 * i - 2;
                z = Math.Round((z), 2);
                if (4 * i - 0.5 == 0)
                {
                    res[ind] = 0;
                }
                res[ind] = z;
                ind++;
            }
            return res;
        }
    }
}
