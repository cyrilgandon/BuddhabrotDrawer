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
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        DateTime _startTime;
        private bool _isRunning;
        private bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                _isRunning = value;
                if (value)
                {
                    _startTime = DateTime.Now;
                    btnDraw.Text = "Stop";
                    timer.Start();
                    DrawBrots();
                }
                else
                {
                    timer.Stop();
                    btnDraw.Text = "Draw";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 40;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - _startTime;
            this.Text = $"{elapsed.TotalSeconds.ToString("0.00")}s";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
        }

        Buddhabrot buddhaRed;
        Buddhabrot buddhaGreen;
        Buddhabrot buddhaBlue;
        async private Task DrawBrots()
        {
            int size = int.Parse(txtWidth.Text);
            long hitsMax = long.Parse(txtStopAfter.Text);

            buddhaRed = new Buddhabrot(size, 2000, hitsMax);
            buddhaGreen = new Buddhabrot(size, 200, hitsMax);
            buddhaBlue = new Buddhabrot(size, 20, hitsMax);

            await Task.WhenAll(
              DrawBrot(buddhaRed, picCanvas, completionLabel1, drawingCompletionLabel1, Color.Red),
              DrawBrot(buddhaGreen, pictureBox1, completionLabel2, drawingCompletionLabel2, Color.Green),
              DrawBrot(buddhaBlue, pictureBox2, completionLabel3, drawingCompletionLabel3, Color.Blue));

        }
        
        async private Task DrawBrot(Buddhabrot buddha, PictureBox pictureBox, Label completetionLabel, Label drawingCompletetionLabel, Color color)
        {
            int reportEveryPercent = int.Parse(txtDrawEvery.Text);
            
            var progress = new Progress<BuddhabrotReportProgress>(reportProgress =>
            {
                int lastDraw = 0;
                var buddhabrot = reportProgress.Buddhabrot;
                completetionLabel.Text = $"Completion: {buddhabrot.Completion}%";
                if (buddhabrot.Completion - lastDraw > reportEveryPercent)
                {
                    lastDraw = buddhabrot.Completion;
                    var drawer = new BuddhabrotMonoColor(buddhabrot);
                    var bitmap = drawer.Draw();
                    pictureBox.Image = bitmap;
                    pictureBox.Refresh();
                }

                if (reportProgress.Completed)
                {
                    var drawer = new BuddhabrotMonoColor(buddhabrot);
                    var bitmap = drawer.Draw();
                    bitmap.Save(GetSavePath(buddhabrot.Iteration), ImageFormat.Bmp);
                }
            });

            await Task.Run(() =>
            {
                buddha.Run(progress);
            });
        }
        
        private string GetSavePath(int iteration)
        {
            var directory = Path.Combine("C:\\", "temp", "buddhabrot");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string file = $"{DateTime.Now.ToFileTime()}_{iteration}k_buddhabrot.bmp";
            
            return Path.Combine(directory, file);
        }
    }
}
