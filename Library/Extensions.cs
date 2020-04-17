using System.Diagnostics;

namespace WinKeyRecorder
{
    public static class Extensions
    {
        private const long Billion = 1_000_000_000L;
        private const long Million = 1_000_000L;

        public static long ElapsedNanoseconds(this Stopwatch watch)
        {
            var conversion = ((double)watch.ElapsedTicks / Stopwatch.Frequency);
            return (long)(conversion * Billion);
        }

        public static long ElapsedMicroseconds(this Stopwatch watch)
        {
            var conversion = ((double)watch.ElapsedTicks / Stopwatch.Frequency);
            return (long)(conversion * Million);
        }
    }
}
