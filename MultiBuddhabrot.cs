using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class MultiBuddhabrot
    {
        const int t = 2;
        private const float XMin = -t;
        private const float XMax = t;
        private const float YMin = -t;
        private const float Ymax = t;

        public List<BuddhabrotPoint> Hits { get; } = new List<BuddhabrotPoint>();
        private readonly Random Rand = new Random();

        public bool Completed { get; private set; }
        public int Size { get; }
        public long HitsMax { get; }
        public int MaxIteration { get; }

        public int Completion => (int)(((TotalHits * 1d) / HitsMax) * 100);
        public long TotalHits { get; set; }
        public MultiBuddhabrot(int size, int maxIteration, long hitsMax)
        {
            if (size <= 0)
            {
                throw new ArgumentException("size must be greater than 0");
            }
            Size = size;
            HitsMax = hitsMax;
            MaxIteration = maxIteration;

        }


        public void Run(IProgress<BuddhabrotReportProgress> progress = null)
        {
            long previousTotalHits = 0;
            do
            {
                float cx = XMin + (float)Rand.NextDouble() * (XMax - XMin);
                float cy = YMin + (float)Rand.NextDouble() * (Ymax - YMin);
                var point = new BuddhabrotPoint(cx, cy, MaxIteration);
                Hits.Add(point);
                if ((TotalHits - previousTotalHits * 1d) / HitsMax > 1 / 100d)
                {
                    previousTotalHits = TotalHits;
                    if (progress != null)
                    {
                        //progress.Report(new BuddhabrotReportProgress(this));
                    }
                }
            }
            while (Hits.Count < HitsMax);

            Completed = true;
            if (progress != null)
            {
                // progress.Report(new BuddhabrotReportProgress(this, true));
            }
        }

        public int[,] GetFor(int iteration)
        {
            var hits = new int[Size, Size];
            double dx = (XMax - XMin) / Size;
            double dy = (Ymax - YMin) / Size;
            // Iterate.
            foreach (var point in this.Hits)
            {
                if (point.DivergenceIndex <= iteration)
                {
                    foreach (var p in point.Orbit.TakeWhile((p, i) => i < iteration))
                    {
                        int ix = (int)Math.Round((p.X - XMin) / dx);
                        int iy = (int)Math.Round((p.Y - YMin) / dy);
                        if (0 <= ix && ix < Size && 0 <= iy && iy < Size)
                        {
                            hits[iy, ix]++;
                        }
                        else
                        {
                            // break;
                        }
                    }
                }
            }
            return hits;
        }

    }
}
