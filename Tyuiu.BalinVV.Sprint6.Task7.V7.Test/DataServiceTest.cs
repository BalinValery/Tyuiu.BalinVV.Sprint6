using Tyuiu.BalinVV.Sprint6.Task7.V7.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7\Tyuiu.BalinVV.Sprint7.Project.V3\bin\Debug\InPutDataFileTask7V7.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
