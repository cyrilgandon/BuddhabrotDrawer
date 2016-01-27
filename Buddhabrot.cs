using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class Buddhabrot
    {
        const int t = 2;
        private const double XMin = -t;
        private const double XMax = t;
        private const double YMin = -t;
        private const double Ymax = t;

        public int[,] Hits { get; }
        public Random Rand {get;}

        public bool Completed { get; private set; }
        public int Size { get; }
        public long HitsMax { get; }
        public int Iteration { get; }

        private readonly Stopwatch _stopwatch = new Stopwatch();

        public int Completion => (int)(((TotalHits * 1d) / HitsMax) * 100);
        public long TotalHits { get; set; }
        public Buddhabrot(int size, int iteration, long hitsMax, Random rand = null)
        {
            if (size <= 0)
            {
                throw new ArgumentException("size must be greater than 0");
            }
            Rand = rand;
            if(Rand == null)
            {
                Rand = new Random();
            }
            Size = size;
            HitsMax = hitsMax;
            Iteration = iteration;

            Hits = new int[size, size];
        }


        public void Run(IProgress<BuddhabrotReportProgress> progress = null)
        {
            _stopwatch.Start();
            long previousTotalHits = 0;
            do
            {
                MakeOneOrbit();

                if ((TotalHits - previousTotalHits * 1d) / HitsMax > 1 / 100d)
                {
                    previousTotalHits = TotalHits;
                    if (progress != null)
                    {
                        progress.Report(new BuddhabrotReportProgress(this, _stopwatch.Elapsed));
                    }
                }
            }
            while (TotalHits < HitsMax);

            Completed = true;
            if (progress != null)
            {
                progress.Report(new BuddhabrotReportProgress(this, _stopwatch.Elapsed, true));
            }

        }

        public long MakeOneOrbit()
        {
            int size = Size;
            double dx = (XMax - XMin) / size;
            double dy = (Ymax - YMin) / size;
            double cx = XMin + Rand.NextDouble() * (XMax - XMin);
            double cy = YMin + Rand.NextDouble() * (Ymax - YMin);

            if (Extensions.IsInBulb(cx, cy) || Extensions.IsInCardiod(cx, cy))
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
                        // break;
                    }

                    y = 2 * x * y + cy;
                    x = xx - yy + cx;
                    xx = x * x;
                    yy = y * y;
                    if (xx + yy >= EscapeNorm * 10) break;
                }

            }

            return TotalHits;
        }


    }
}
