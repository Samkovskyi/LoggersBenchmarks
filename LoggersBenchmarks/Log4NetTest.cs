using BenchmarkDotNet.Running;
using LoggersBenchmarks.log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoggersBenchmarks
{
    [TestClass]
    public class Log4NetTest
    {
        [TestMethod]
        public void FileLogTest()
        {
            BenchmarkRunner.Run<Log4netFile>();
        }
    }
}
