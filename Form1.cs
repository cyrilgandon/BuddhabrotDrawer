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

        async private Task DrawBrots()
        {
            await Task.WhenAll(
              buddhabrotUserControl1.DrawBrot(),
              buddhabrotUserControl2.DrawBrot(),
              buddhabrotUserControl3.DrawBrot());
        }
        async private void btnDraw_Click(object sender, EventArgs e)
        {
            int count = 750;
            int maxIteration = 2000;
            int size = 200;
            long resolution = 10000000;
            var directory = Path.Combine("C:\\", "temp", $"{DateTime.Now.ToFileTime()}-Buddhabrot-c{count}-m{maxIteration}");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var m = new MultiBuddhabrot(size, maxIteration, resolution);
            m.Run();
            foreach (int iteration in Extensions.LogDistribution(count, maxIteration).Select(a => (int)a).Distinct())
            {
                var tab = m.GetFor(iteration);
                var drawer = new BuddhabrotMonoColor();
                string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot.jpg";
                using (var bitmap = drawer.Draw(tab, size))
                {
                    bitmap.Save(Path.Combine(directory, file), ImageFormat.Jpeg);
                }
            }
            //await Task.Run(() => Parallel.ForEach(Extensions.LogDistribution(count, maxIteration).Distinct(),
            //    new ParallelOptions { MaxDegreeOfParallelism = 1 },
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

        private void button1_Click(object sender, EventArgs e)
        {
            var directory = @"C:\Buddhabrot\130967322289921676-Buddhabrot-c100-m2000000";
            var contrastDirectory = Path.Combine(directory, "contrast");
            var meanDirectory = Path.Combine(directory, "mean");
            if (!Directory.Exists(contrastDirectory))
            {
                Directory.CreateDirectory(contrastDirectory);
            }
            if (!Directory.Exists(meanDirectory))
            {
                Directory.CreateDirectory(meanDirectory);
            }

            foreach (var file in Directory.EnumerateFiles(directory))
            {
                var info = new FileInfo(file);
                using (var bitmap = (Bitmap)Image.FromFile(file))
                using (var contrasted = bitmap.AdjustContrast(0.1, 0.999))
                {
                    contrasted.Save(Path.Combine(contrastDirectory, info.Name), ImageFormat.Bmp);
                    using (var mean = contrasted.SetMean(128))
                    {
                        mean.Save(Path.Combine(meanDirectory, info.Name), ImageFormat.Bmp);
                    }
                }
            }
        }
    }
}
