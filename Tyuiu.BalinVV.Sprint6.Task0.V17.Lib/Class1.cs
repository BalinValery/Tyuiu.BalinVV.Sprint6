using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BalinVV.Sprint6.Task0.V17.Lib
{
    public class Class1 : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double res = Math.Round(Math.Exp(x) / x, 3);
            return res;
        }
    }
}
