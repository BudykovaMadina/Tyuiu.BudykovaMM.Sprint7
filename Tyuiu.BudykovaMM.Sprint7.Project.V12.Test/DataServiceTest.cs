using System.IO;
using Tyuiu.BudykovaMM.Sprint7.Project.V12.Lib;
namespace Tyuiu.BudykovaMM.Sprint7.Project.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
            public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint7\HUAWEIInPutFile.csv";

            string row = "BoDe-WDH9";
            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);


            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalcInt()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint7\HUAWEIInPutFile.csv";

            int row = 1;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);


            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }
    }
    
}
