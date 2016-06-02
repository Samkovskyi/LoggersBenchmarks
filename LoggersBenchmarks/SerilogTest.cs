using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
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
            var summury = BenchmarkRunner.Run<SerilogFile>(ManualConfig
            .Create(DefaultConfig.Instance)
            .With(Job.Dry.WithTargetCount(5).WithLaunchCount(3)));
        }

        [TestMethod]
        public void SeqLogTest()
        {
            var summury = BenchmarkRunner.Run<SerilogSeq>(ManualConfig
            .Create(DefaultConfig.Instance)
            .With(Job.Dry.WithTargetCount(5).WithLaunchCount(3)));
        }

    }
}
