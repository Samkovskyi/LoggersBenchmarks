using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
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
            BenchmarkRunner.Run<SerilogFile>(ManualConfig
                .Create(DefaultConfig.Instance)
                .With(Job.Dry.WithTargetCount(5).WithLaunchCount(3)));
        }

        [TestMethod]
        public void SeqLogTest()
        {
            BenchmarkRunner.Run<SerilogSeq>(ManualConfig
                .Create(DefaultConfig.Instance)
                .With(Job.Dry.WithTargetCount(5).WithLaunchCount(3)));
        }

    }
}
