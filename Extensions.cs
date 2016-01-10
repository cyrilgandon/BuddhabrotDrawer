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
        /// Return count element between 0 and max, with a logarithmic distribution
        /// </summary>
        /// <param name="count"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<double> LogDistribution(int count, double max)
        {
            return Enumerable.Range(0, count)
                                     .Select(i =>
                                     {
                                         return Math.Exp(i * Math.Log(max) / count);
                                     });
        }

        public static Bitmap AdjustContrast(this Bitmap bitmap, double black = 0.05,  double white = 0.95)
        {
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            var length = bitmapData.Stride * bitmapData.Height;

            byte[] bytes = new byte[length];

            // Copy bitmap to byte[]
            Marshal.Copy(bitmapData.Scan0, bytes, 0, length);
            bitmap.UnlockBits(bitmapData);

            var greys = bytes.Where((by, i) => i % 3 == 0).Select(by => (int)by).ToList();
            var histo = new int[256];
            for (int i = 0; i < greys.Count; i++)
            {
                histo[greys[i]]++;
            }
            var total = histo.Sum();

            double cumulPercent = 0;
            double? blackLimit = null, whiteLimit = null;
            for (int i = 0; i < histo.Length; i++)
            {
                cumulPercent += (histo[i] * 1d) / total;
                if (cumulPercent > black && blackLimit == null)
                {
                    blackLimit = i;
                }
                if (cumulPercent > white && whiteLimit == null)
                {
                    whiteLimit = i;
                }
            }
            if (black <= 0) blackLimit = 0;
            if (white >= 1) whiteLimit = 255;
            double a, b;
            if (blackLimit == 0)
            {
                if (whiteLimit == 0)
                {
                    whiteLimit = 1;
                }
                b = 0;
                a = 255 / whiteLimit.Value;
            }
            else {
                b = 255 / (1 - whiteLimit.Value / blackLimit.Value);
                a = (255 - b) / whiteLimit.Value;
            }

            var news = greys.Select(g =>
            {
                int gp = (int)(a * g + b);
                gp = Math.Min(gp, 255);
                gp = Math.Max(gp, 0);

                return (byte)gp;
            }).SelectMany(g => new[] { g, g, g }).ToArray();


            var scaled = new Bitmap(bitmap.Width, bitmap.Height);

            var data = scaled.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            Marshal.Copy(news, 0, data.Scan0, news.Length);

            scaled.UnlockBits(data);

            return scaled;
        }

        public static Bitmap SetMean(this Bitmap bitmap, int newMean)
        {
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            var length = bitmapData.Stride * bitmapData.Height;

            byte[] bytes = new byte[length];

            // Copy bitmap to byte[]
            Marshal.Copy(bitmapData.Scan0, bytes, 0, length);
            bitmap.UnlockBits(bitmapData);

            var oldMean = bytes.Average(b => b);

            var news = bytes.Select(by =>
            {
                return by * (newMean / oldMean );

            }).Select(bb => (byte)bb).ToArray();

            var truc = news.Average(b => b);
            var scaled = new Bitmap(bitmap.Width, bitmap.Height);

            var data = scaled.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            Marshal.Copy(news, 0, data.Scan0, news.Length);

            scaled.UnlockBits(data);

            return scaled;
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
