using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public static class ImageExtensions
    {
        /// <summary>
        /// Auto contrast feature
        /// Every pixel lower than blackPercentile will became black
        /// Every pixel in the top whitePercentile will became white
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="blackPercentile"></param>
        /// <param name="whitePercentile"></param>
        /// <returns></returns>
        public static Bitmap AdjustContrast(this Bitmap bitmap, double blackPercentile = 0.05, double whitePercentile = 0.95)
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
                if (cumulPercent > blackPercentile && blackLimit == null)
                {
                    blackLimit = i;
                }
                if (cumulPercent > whitePercentile && whiteLimit == null)
                {
                    whiteLimit = i;
                }
            }
            if (blackPercentile <= 0) blackLimit = 0;
            if (whitePercentile >= 1) whiteLimit = 255;
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
    }
}
