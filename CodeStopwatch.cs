using System;
using System.Diagnostics;

namespace StopwatchTimer
{
    public class CodeStopWatch : IDisposable
    {
        private readonly string _codeUnderTime;
        private readonly Action<string> _logAction;
        private readonly Stopwatch _codeStopwatch;

        public CodeStopWatch(string codeUnderTime) : this(codeUnderTime, Console.WriteLine)
        {
        }

        public CodeStopWatch(string codeUnderTime, Action<string> logAction)
        {
            _codeUnderTime = codeUnderTime;
            _logAction = logAction;
            _codeStopwatch = new Stopwatch();
            logAction($"Starting {_codeUnderTime}");
            _codeStopwatch.Start();
        }


        public void Dispose()
        {
            _codeStopwatch.Stop();
            _logAction($"Finished {_codeUnderTime} in {_codeStopwatch.Elapsed}");
            _codeStopwatch.Reset();
        }
    }
}