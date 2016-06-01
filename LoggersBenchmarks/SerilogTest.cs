using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using LoggersBenchmarks.Serilog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoggersBenchmarks
{
    [TestClass]
    public class SerilogTest
    {
        [TestMethod]
        public void FileLogTest()
        {
            var summury = BenchmarkRunner.Run<SerilogFile>();
        }

        [TestMethod]
        public void SeqLogTest()
        {
            var summury = BenchmarkRunner.Run<SerilogSeq>();
        }

    }
}
