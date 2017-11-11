using System;
using System.Collections.Generic;

namespace uTorrentNotifier
{
    class Utilities
    {
        private Utilities()
        {
        }

        public static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            var orders = new[] { "PiB", "TiB", "GiB", "MiB", "KiB", "B" };
            var max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (var order in orders)
            {
                if (bytes > max) return $"{decimal.Divide(bytes, max):##.##} {order}";
                max /= scale;
            }
            return "0 B";
        }
    }
}

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static List<(string, string)> Merge(this List<(string, string)> major, List<(string, string)> defaults)
        {
            var merged  = new List<(string, string)>();
            var updated = new List<(string, string)>();

            updated.AddRange(defaults);

            foreach (var kv in defaults)
            {
                var found = major.Find(item => item.Item1 == kv.Item1);

                if (found.Item1 != null)
                {
                    updated.Remove(kv);
                }
            }

            merged.AddRange(major);
            merged.AddRange(updated);

            return merged;
        }
    }
}