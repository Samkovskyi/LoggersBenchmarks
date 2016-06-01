using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Serilog;

namespace LoggersBenchmarks.Serilog
{
    [Config("jobs=Dry")]
    public class SerilogSeq
    {

        [Setup]
        public void Innit()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();
        }

        [Benchmark]
        public void SeqLog()
        {
            Log.Debug("{AppName} Test Message", "SeqLog");
            Log.Information("{AppName} Test Message", "SeqLog");
            Log.Warning("{AppName} Test Message", "SeqLog");
            Log.Error("{AppName} Test Message", "SeqLog");
            Log.Fatal("{AppName} Test Message", "SeqLog");
        }

    }
}
