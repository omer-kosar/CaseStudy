using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

namespace ConsoleApp.LoopBenchMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var config = ManualConfig.Create(DefaultConfig.Instance);
            //config.Add(new ConsoleLogger()); // Ensures console output

            var summary = BenchmarkRunner.Run<LoopBenchMark>();
        }
    }
}