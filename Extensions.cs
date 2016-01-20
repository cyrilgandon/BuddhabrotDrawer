using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public static class Extensions
    {
        public static TParam ThrowIfNull<TParam>(this TParam param, string paramName) where TParam : class
        {
            if (param == null) throw new ArgumentNullException(paramName);
            return param;
        }

        /// <summary>
        /// Return count element between 1 and max, with a logarithmic distribution
        /// </summary>
        /// <param name="count"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<double> LogDistribution(int count, double max)
        {
            if(count < 2)
            {
                throw new ArgumentException($"The minimum number of elements is 2. You give {count}.", nameof(count));
            }
            if (max <= 0)
            {
                throw new ArgumentException($"The maximum must be strictly positive. You give {max}.", nameof(max));
            }
            return Enumerable.Range(0, count)
                                     .Select(i =>
                                     {
                                         return Math.Exp(i * Math.Log(max) / (count - 1));
                                     });
        }

    


        /// <summary>
        /// https://en.wikipedia.org/wiki/Mandelbrot_set#Optimizations
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsInCardiod(double x, double y)
        {
            double yy = y * y;
            double xMinusQuarter = x - 0.25;
            double q = xMinusQuarter * xMinusQuarter + yy;
            return q * (q + xMinusQuarter) < 0.25 * yy;
        }

        public static bool IsInBulb(double x, double y)
        {
            return (x + 1) * (x + 1) + y * y < 0.0625; // 1/16
        }


        public static string GetSavePath(int iteration)
        {
            var directory = Path.Combine("C:\\", "temp", "buddhabrot");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string file = $"{DateTime.Now.ToFileTime()}_{iteration}_iteration_buddhabrot.bmp";

            return Path.Combine(directory, file);
        }
    }
}
