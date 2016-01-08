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
            int maxIteration = 2000000;
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
                                    }), new ParallelOptions { MaxDegreeOfParallelism = 5 }, diteration =>
                                        {
                                            int iteration = (int)Math.Round(diteration);
                                            var buddha = new Buddhabrot(500, iteration, 100000000);
                                            buddha.Run();
                                            var drawer = new BuddhabrotMonoColor(buddha);
                                            var bitmap = drawer.Draw();

                                            string file = $"{iteration.ToString().PadLeft(maxIteration.ToString().Count(), '0')}_buddhabrot.bmp";

                                            bitmap.Save(Path.Combine(directory, file), ImageFormat.Bmp);
                                        });
        }
    }
}
