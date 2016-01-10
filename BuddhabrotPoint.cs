using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class BuddhabrotPoint
    {
        public float X { get; }
        public float Y { get; }
        public long Iteration { get; }
        public List<PointF> Orbit { get; } = new List<PointF>();
        public int DivergenceIndex => Orbit.Count;
        public BuddhabrotPoint(float cx, float cy, long iteration)
        {
            Iteration = iteration;
            X = cx;
            Y = cy;

            if (Extensions.IsInBulb(cx, cy) || Extensions.IsInCardiod(cx, cy))
            {
                // convergent
                return;
            }
            else {
                const float EscapeNorm = 4;
                float x = cx, y = cy, xx = x * x, yy = y * y;
                
                for (int i = 1; i <= Iteration; i++)
                {
                    Orbit.Add(new PointF(x, y));
                    y = 2 * x * y + cy;
                    x = xx - yy + cx;
                    xx = x * x;
                    yy = y * y;
                    if (xx + yy >= EscapeNorm)
                    {
                        break;
                    }
                }
            }
        }

    }
}
