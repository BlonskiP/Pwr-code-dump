using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class RandomSelector
    {
        static int seed = Environment.TickCount;

        static readonly ThreadLocal<Random> random =
            new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        public static int Next()
        {
            return random.Value.Next();
        }
        public static int Next(int min, int max)
        {
            return random.Value.Next(min, max);
        }
        public static double NextDouble()
        {
            return random.Value.NextDouble();
        }
    }
}
