using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.LoopBenchMark
{
    public class LoopBenchMark
    {
        private List<int> numbers;

        [Params(1000)]
        public int Iterations;

        [GlobalSetup]
        public void Setup()
        {
            numbers = new List<int>(Iterations);
            for (int i = 0; i < Iterations; i++)
            {
                numbers.Add(i);
            }
        }

        [Benchmark]
        public void ForLoop()
        {
            int sum = 0;
            for (int i = 0; i < Iterations; i++)
            {
                sum += numbers[i];
            }
        }

        [Benchmark]
        public void ForeachLoop()
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
        }

        [Benchmark]
        public void ParallelFor()
        {
            int sum = 0;

            Parallel.For(0, Iterations, i =>
            {
                sum += numbers[i];
            });
        }

        [Benchmark]
        public void DoLoop()
        {
            int i = 0;
            int sum = 0;

            do
            {
                sum += numbers[i];
                i++;
            } while (i < Iterations);
        }
    }
}
