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
        private void btnDraw_Click(object sender, EventArgs e)
        {
            int count = 100;
            int maxIteration = 2000;
            var directory = Path.Combine("C:\\", "temp", $"{DateTime.Now.ToFileTime()}-Buddhabrot-c{count}-m{maxIteration}");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            Parallel.ForEach(Enumerable.Range(0, count)
                                    .Select(i =>
                                    {
                                        // will generate 'count' numbers between 1 and 'maxIteration' logarithmic distribution
                                        return Math.Exp(i * Math.Log(maxIteration) / count);
                                    }), new ParallelOptions { MaxDegreeOfParallelism = 1 }, diteration =>
                                        {
                                            int iteration = (int)Math.Round(diteration);
                                            var buddha = new Buddhabrot(500, iteration, 10000000);
                                            buddha.Run();
                                            var drawer = new BuddhabrotMonoColor(buddha);
                                            string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot.jpg";
                                            using (var bitmap = drawer.Draw())
                                            using (var scaled = bitmap.AdjustContrast())
                                            {
                                                scaled.Save(Path.Combine(directory, file), ImageFormat.Jpeg);
                                            }
                                        });
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
                using (var contrasted = bitmap.AdjustContrast())
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
