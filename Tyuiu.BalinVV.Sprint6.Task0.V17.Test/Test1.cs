using Tyuiu.BalinVV.Sprint6.Task0.V17.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            Assert.AreEqual(2.718, ds.Calculate(1));
        }
    }
}
