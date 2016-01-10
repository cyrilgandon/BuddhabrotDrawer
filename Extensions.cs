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
    public static class Extensions
    {
        public static TParam ThrowIfNull<TParam>(this TParam param, string paramName) where TParam : class
        {
            if (param == null) throw new ArgumentNullException(paramName);
            return param;
        }

        public static Bitmap AdjustContrast(this Bitmap bitmap)
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
            int? _5 = null, _95 = null;
            for (int i = 0; i < histo.Length; i++)
            {
                cumulPercent += (histo[i] * 1d) / total;
                if (cumulPercent > 0.05 && _5 == null)
                {
                    _5 = i;
                }
                if (cumulPercent > 0.95 && _95 == null)
                {
                    _95 = i;
                }
            }
            double a, b;
            if (_5 == 0)
            {
                if (_95 == 0)
                {
                    _95 = 1;
                }
                b = 0;
                a = 255 / _95.Value;
            }
            else {
                b = 255 / (1 - _95.Value / _5.Value);
                a = (255 - b) / _95.Value;
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
    }
}
