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

            var mean = bytes.Average(b => b);

            var news = bytes.Select(b => (byte)(b * (128 / mean))).ToArray();

            var scaled = new Bitmap(bitmap.Width, bitmap.Height);
            var data = scaled.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;

                for (int y = 0; y < news.Length; y++)
                {
                    ptr[y] = news[y];
                }
            }
            scaled.UnlockBits(data);
            return scaled;
        }
    }
}
