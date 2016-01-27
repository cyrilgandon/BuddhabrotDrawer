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
using System.Collections.Concurrent;

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

            int count = 600; // 600 target
            int maxIteration = 200000; // 200000 target
            int definition = 1080; // Full HD
            long resolution = (long)(1 * 10e8);
            var directory = @"C:\temp\130983631136094658-Buddhabrot-1080x1080-c600-m200000-r1000000000";
            //Path.Combine("C:\\", "temp", $"{DateTime.Now.ToFileTime()}-Buddhabrot-{definition}x{definition}-c{count}-m{maxIteration}-r{resolution}");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var existedIterations = Directory.EnumerateFiles(directory)
                    .Select(f =>
                    {
                        var fileInfo = new FileInfo(f);
                        return int.Parse(fileInfo.Name.Substring(0, 6));
                    }).ToList();

            int completion = 0;
            var reportView = new ConcurrentDictionary<Buddhabrot, DataGridViewRow>();

            var progress = new Progress<BuddhabrotReportProgress>(reportProgress =>
            {
                this.label1.Text = $"{completion}/{count}";
                var buddhabrot = reportProgress.Buddhabrot;

                var dgw = reportView[buddhabrot];
                if (dgw == null)
                {
                    var clone = (DataGridViewRow)dataGridView1.RowTemplate.Clone();
                    lock (dataGridView1)
                    {
                        int i = dataGridView1.Rows.Add(clone);
                        dgw = dataGridView1.Rows[i];
                        reportView[buddhabrot] = dgw;
                    }
                }

                var estimatedDuration = TimeSpan.FromSeconds(reportProgress.Elapsed.TotalSeconds * (100.0 / reportProgress.Buddhabrot.Completion));
                var timeLeft = estimatedDuration - reportProgress.Elapsed;

                dgw.Cells[0].Value = $"{reportProgress.Buddhabrot.Iteration}";
                dgw.Cells[1].Value = $"{reportProgress.Buddhabrot.Completion}%";
                dgw.Cells[2].Value = $"{timeLeft.ToString(@"hh\:mm\:ss")}";
                dgw.Cells[3].Value = $"{(DateTime.Now + estimatedDuration).ToShortTimeString()}";
                if (reportProgress.Completed)
                {
                    completion++;
                    this.dataGridView1.Rows.Remove(dgw);
                }
            });

            var allIterations = Extensions.LogDistribution(count, maxIteration).Select(a => (int)Math.Round(a)).Reverse().ToList();

            List<int> iterations = new List<int>();
            foreach(var it in allIterations)
            {
                if (existedIterations.Contains(it))
                {
                    existedIterations.Remove(it);
                }
                else
                {
                    iterations.Add(it);
                }
            }
            
            await Task.Run(() => Parallel.ForEach(iterations.Shuffle(),
                 new ParallelOptions { MaxDegreeOfParallelism = 5 },
                 iteration =>
                 {
                     var random = new Random(0);
                     var buddhabrot = new Buddhabrot(definition, iteration, resolution, random);

                     reportView.TryAdd(buddhabrot, null);

                     buddhabrot.Run(progress);
                     var drawer = new BuddhabrotMonoColor();
                     var bitmap = drawer.Draw(buddhabrot);
                     var guid = Guid.NewGuid().ToString();
                     string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot_{DateTime.Now.ToFileTime()}_{guid}.jpg";
                     bitmap.Save(Path.Combine(directory, file), ImageFormat.Jpeg);
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
