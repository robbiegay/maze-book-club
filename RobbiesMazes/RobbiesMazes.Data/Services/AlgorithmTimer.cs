using System;
using System.Diagnostics;

namespace RobbiesMazes.Data.Services
{
    public class AlgorithmTimer
    {
        private Stopwatch watch;

        public AlgorithmTimer()
        {
            watch = new Stopwatch();
        }

        public void Start()
        {
            watch.Start();
        }

        public void Stop()
        {
            watch.Stop();
        }

        public long ElapsedTimeMilliseconds()
        {
            return watch.ElapsedMilliseconds;
        }

        public long ElapsedTimeTicks()
        {
            return watch.ElapsedTicks;
        }
    }
}
