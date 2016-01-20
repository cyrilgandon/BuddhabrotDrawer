using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace BuddhabrotDrawer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        async private void btnDraw_Click(object sender, EventArgs e)
        {
            int count = 600;
            int maxIteration = 200;
            int size = 500;
            long resolution = 100000000;
            var directory = Path.Combine("C:\\", "temp", $"{DateTime.Now.ToFileTime()}-Buddhabrot-c{count}-m{maxIteration}");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var m = new MultiBuddhabrot(size, maxIteration, resolution);
            m.Run();
            await Task.Run(() => Parallel.ForEach(Extensions.LogDistribution(count, maxIteration).Select(a => (int)Math.Round(a)),
                 new ParallelOptions { MaxDegreeOfParallelism = 5 },
                 iteration =>
                 {
                     var tab = m.GetFor(iteration);
                     var drawer = new BuddhabrotMonoColor();
                     string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot_{DateTime.Now.ToFileTime()}.jpg";
                     using (var bitmap = drawer.Draw(tab, size))
                     {
                         bitmap.Save(Path.Combine(directory, file), ImageFormat.Jpeg);
                     }
                 }));

            //await Task.Run(() => Parallel.ForEach(Extensions.LogDistribution(count, maxIteration).Distinct(),
            //   
            //    diteration =>
            //    {
            //        int iteration = (int)Math.Round(diteration);
            //        var buddha = new Buddhabrot(500, iteration, 10000000);
            //        buddha.Run();
            //        var drawer = new BuddhabrotMonoColor(buddha);
            //        string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot.jpg";
            //        using (var bitmap = drawer.Draw(buddha))
            //        using (var scaled = bitmap.AdjustContrast())
            //        {
            //            scaled.Save(Path.Combine(directory, file), ImageFormat.Jpeg);
            //        }
            //    }));
        }
    }
}
