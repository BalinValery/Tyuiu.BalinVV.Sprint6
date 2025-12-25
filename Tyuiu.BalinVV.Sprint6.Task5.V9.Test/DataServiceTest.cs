namespace Tyuiu.BalinVV.Sprint6.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint6\Tyuiu.BalinVV.Sprint6.Task5.V9\bin\Debug\InPutDataFileTask5V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
      
