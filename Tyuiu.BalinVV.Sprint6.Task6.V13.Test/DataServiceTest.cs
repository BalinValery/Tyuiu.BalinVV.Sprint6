using Tyuiu.BalinVV.Sprint6.Task6.V13.Lib;
namespace Tyuiu.BalinVV.Sprint6.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint6\Tyuiu.BalinVV.Sprint6.Task5.V9\bin\Debug\InPutDataFileTask6V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
