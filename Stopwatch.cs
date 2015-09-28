using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    class Stopwatch
    {
        private DateTime time;
        private bool started = false;

        public TimeSpan Duration { get; set; }

        public void Start()
        {
            if (!started)
            {
                time = DateTime.Now;
                started = true;
            }
            else
                throw new InvalidOperationException();            
        }

        public void Stop()
        {
            Duration = DateTime.Now - time;
            started = false;
        }
    }
}
