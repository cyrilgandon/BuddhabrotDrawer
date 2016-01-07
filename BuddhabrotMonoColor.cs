using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class BuddhabrotMonoColor
    {
        public Buddhabrot Buddhabrot { get; }

        public BuddhabrotMonoColor(Buddhabrot buddhabrot)
        {
            Buddhabrot = buddhabrot.ThrowIfNull(nameof(buddhabrot));
        }

        public Bitmap Draw()
        {
            var hits = Buddhabrot.Hits;
            var size = Buddhabrot.Size;
            double largest = double.MinValue;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Buddhabrot.Hits[i, j] > largest)
                        largest = hits[i, j];
                }

            }
            if (largest > 0)
            {
                //http://stackoverflow.com/questions/7768711/setpixel-is-too-slow-is-there-a-faster-way-to-draw-to-bitmap
                double scaleR = 255 / largest;
                var bitmap = new Bitmap(Buddhabrot.Size, Buddhabrot.Size);
                var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                int stride = data.Stride;
                unsafe
                {
                    byte* ptr = (byte*)data.Scan0;

                    for (int y = 0; y < size; y++)
                    {
                        for (int x = 0; x < size; x++)
                        {
                            byte r = (byte)Math.Min(255, Math.Round(hits[x, y] * scaleR));

                            ptr[(x * 3) + y * stride] = r;
                            ptr[(x * 3) + y * stride + 1] = r;
                            ptr[(x * 3) + y * stride + 2] = r;
                        }
                    }
                }
                bitmap.UnlockBits(data);
                return bitmap;
            }
            else
            {
                return null;
            }
        }
    }
}
