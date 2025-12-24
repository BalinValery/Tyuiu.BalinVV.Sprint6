using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BalinVV.Sprint6.Task0.V17.Lib
{
    public class Class1 : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double y = Math.Pow(2.7182, x) / x;
            y = Math.Round(y, 3);
            return y;
        }
    }
}
