using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace zxing
{
    public class Watch
    {
        public static Stopwatch Clock = new Stopwatch();
        public static void Start()
        {
            Clock.Start();
        }
        public static void Pause()
        {
            Clock.Stop();
        }
        public override string ToString()
        {
            return Clock.ElapsedMilliseconds.ToString();
        }
    }
}
