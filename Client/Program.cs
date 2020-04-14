using BenchmarkDotNet.Running;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}