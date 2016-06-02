using BenchmarkDotNet.Running;
using LoggersBenchmarks.NLog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoggersBenchmarks
{
    [TestClass]
    public class NLogTest
    {
        [TestMethod]
        public void FileLogTest()
        {
            BenchmarkRunner.Run<NLogFile>();
        }
    }
}
