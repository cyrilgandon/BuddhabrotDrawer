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
        public BuddhabrotReportProgress(Buddhabrot buddhabrot, bool completed = false )
        {
            Buddhabrot = buddhabrot.ThrowIfNull(nameof(buddhabrot));
            Completed = completed;
        }
    }
}
