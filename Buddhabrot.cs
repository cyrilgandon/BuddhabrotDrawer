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

        private const double XMin = -2;
        private const double XMax = 2;
        private const double YMin = -2;
        private const double Ymax = 2;

        public int[,] Hits { get; }
        private readonly Random Rand = new Random();

        public bool Completed { get; private set; }
        public int Size { get; }
        public long HitsMax { get; }
        public int Iteration { get; }

        public int Completion => (int)(((TotalHits * 1d) / HitsMax) * 100);
        public long TotalHits { get; set; }
        public Buddhabrot(int size, int iteration, long hitsMax)
        {
            if (size <= 0)
            {
                throw new ArgumentException("size must be greater than 0");
            }
            Size = size;
            HitsMax = hitsMax;
            Iteration = iteration;

            Hits = new int[size, size];
        }


        public void Run(IProgress<BuddhabrotReportProgress> progress)
        {
            long previousTotalHits = 0;
            do
            {
                MakeOneOrbit();

                if ((TotalHits - previousTotalHits * 1d) / HitsMax > 1 / 100d)
                {
                    previousTotalHits = TotalHits;
                    progress.Report(new BuddhabrotReportProgress(this));
                }
            }
            while (TotalHits < HitsMax);

            Completed = true;
            progress.Report(new BuddhabrotReportProgress(this, true));

        }

        public long MakeOneOrbit()
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

            bool divergent = false;
            // Iterate.
            for (int i = 1; i <= Iteration; i++)
            {
                y = 2 * x * y + cy;
                x = xx - yy + cx;
                xx = x * x;
                yy = y * y;
                if (xx + yy >= EscapeNorm)
                {
                    divergent = true;
                    break;
                }
            }

            if (divergent)
            {
                // Plot.
                x = cx;
                y = cy;
                xx = x * x;
                yy = y * y;

                // Iterate.
                for (int i = 1; i <= Iteration; i++)
                {
                    int ix = (int)Math.Round((x - XMin) / dx);
                    int iy = (int)Math.Round((y - YMin) / dy);
                    if (0 <= ix && ix < size && 0 <= iy && iy < size)
                    {
                        Hits[iy, ix]++;
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
