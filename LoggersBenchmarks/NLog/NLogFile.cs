using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using NLog;
using NLog.Config;
using NLog.Targets;


namespace LoggersBenchmarks.NLog
{
    [Config(typeof(Config))]
    public class NLogFile
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                Add(Job.Dry.WithTargetCount(5).WithLaunchCount(3));
            }
        }

        private static Logger _log;

        public NLogFile()
        {
            var config = new LoggingConfiguration();
            var target = new FileTarget
            {
                FileName = "nlog.log"
            };

            config.AddTarget("logfile", target);
            var rule = new LoggingRule("*", LogLevel.Debug, target);
            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;

            _log = LogManager.GetCurrentClassLogger();
        }

        [Benchmark]
        public void FileLog()
        {
            _log.Debug("Test Message");
            _log.Info("Test Message");
            _log.Warn("Test Message");
            _log.Error("Test Message");
            _log.Fatal("Test Message");
        }
    }
}
