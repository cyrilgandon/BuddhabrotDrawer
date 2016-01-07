using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class Buddhabrot
    {

        private const double XMin = -1.5;
        private const double XMax = 1.5;
        private const double YMin = -1.5;
        private const double Ymax = 1.5;

        private readonly int[,] _hits;
        private readonly Random Rand = new Random();

        public bool Completed { get; private set; }
        public int Size { get; }
        public int HitsMax { get; }

        public int Completion => (int)(((TotalHits * 1d) / HitsMax) * 100);
        public int TotalHits { get; set; }
        public Buddhabrot(int size, int hitsMax)
        {
            Size = size;
            HitsMax = hitsMax;

            _hits = new int[size, size];
        }


        // Draw the current image.
        public Bitmap DisplayBrot(IProgress<int> progress, Color color)
        {
            var bitmap = new Bitmap(Size, Size);
            using (var gr = Graphics.FromImage(bitmap))
            {
                gr.Clear(Color.Black);
            }

            double largest = double.MinValue;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (_hits[i, j] > largest)
                        largest = _hits[i, j];
                }

            }
            if (largest > 0)
            {
                double scaleR = color.R * 2.5 / largest;
                double scaleG = color.G * 2.5 / largest;
                double scaleB = color.B * 2.5 / largest;

                for (int y = 0; y < Size; y++)
                {
                    for (int x = 0; x < Size; x++)
                    {
                        double r = Math.Min(255, Math.Round(_hits[x, y] * scaleR));
                        double g = Math.Min(255, Math.Round(_hits[x, y] * scaleG));
                        double b = Math.Min(255, Math.Round(_hits[x, y] * scaleB));

                        bitmap.SetPixel(x, y, Color.FromArgb(255, (int)r, (int)g, (int)b));
                    }

                    progress.Report((int)((100.0 * y) / Size));
                }
            }
            return bitmap;
        }
        public void Run(IProgress<Buddhabrot> progress, int cutoff, int reportEvery)
        {
            int previousTotalHits = 0;
            do
            {
                MakeOneOrbit(cutoff);

                if (TotalHits - previousTotalHits > reportEvery)
                {
                    previousTotalHits = TotalHits;
                    progress.Report(this);
                }
            }
            while (TotalHits < HitsMax);

            Completed = true;
            progress.Report(this);

        }

        public int MakeOneOrbit(int cutoff)
        {
            int size = Size;
            double dx = (XMax - XMin) / size;
            double dy = (Ymax - YMin) / size;
            double cx = XMin + Rand.NextDouble() * (XMax - XMin);
            double cy = YMin + Rand.NextDouble() * (Ymax - YMin);

            if (IsInBulb(cx, cy) || IsInCardiod(cx, cy))
            {
                return TotalHits;
            }

            const double EscapeNorm = 4;

            // Zet Z0.
            double x, xx, y, yy;
            x = cx;
            y = cy;
            xx = x * x;
            yy = y * y;

            // Iterate.
            for (int i = 1; i <= cutoff; i++)
            {
                y = 2 * x * y + cy;
                x = xx - yy + cx;
                xx = x * x;
                yy = y * y;
                if (xx + yy >= EscapeNorm) break;
            }

            // See if we escaped.
            if (xx + yy >= EscapeNorm)
            {
                // Plot.
                x = cx;
                y = cy;
                xx = x * x;
                yy = y * y;

                // Iterate.
                for (int i = 1; i <= cutoff; i++)
                {
                    int ix = (int)Math.Round((x - XMin) / dx);
                    int iy = (int)Math.Round((y - YMin) / dy);
                    if (0 <= ix && ix < size && 0 <= iy && iy < size)
                    {
                        _hits[iy, ix]++;
                        TotalHits++;
                    }
                    else
                    {
                        break;
                    }

                    y = 2 * x * y + cy;
                    x = xx - yy + cx;
                    xx = x * x;
                    yy = y * y;
                    if (xx + yy >= EscapeNorm) break;
                }

            }

            return TotalHits;
        }

        /// <summary>
        /// https://en.wikipedia.org/wiki/Mandelbrot_set#Optimizations
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsInCardiod(double x, double y)
        {
            double yy = y * y;
            double xMinusQuarter = x - 0.25;
            double q = xMinusQuarter * xMinusQuarter + yy;
            return q * (q + xMinusQuarter) < 0.25 * yy;
        }

        public bool IsInBulb(double x, double y)
        {
            return (x + 1) * (x + 1) + y * y < 0.0625; // 1/16
        }
    }
}
