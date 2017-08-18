using System;
using System.Diagnostics;

namespace StopwatchTimer
{
    public class CodeStopwatch : IDisposable
    {
        private readonly string _codeUnderTime;
        private readonly Stopwatch _codeStopwatch;

        public CodeStopwatch(string codeUnderTime)
        {
            _codeUnderTime = codeUnderTime;
            _codeStopwatch = new Stopwatch();
            Console.WriteLine($"Starting {_codeUnderTime}");
            _codeStopwatch.Start();
        }
        
        public void Dispose()
        {
            _codeStopwatch.Stop();
            Console.WriteLine($"Finished {_codeUnderTime} in {_codeStopwatch.Elapsed}");
            _codeStopwatch.Reset();
        }
    }
}
