using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class BuddhabrotReportProgress
    {

        public Buddhabrot Buddhabrot { get; }
        public bool Completed { get; }
        public TimeSpan Elapsed { get; }
        
        public BuddhabrotReportProgress(Buddhabrot buddhabrot, TimeSpan elapsed, bool completed = false )
        {
            Buddhabrot = buddhabrot.ThrowIfNull(nameof(buddhabrot));
            Elapsed = elapsed;
            Completed = completed;
        }
    }
}
