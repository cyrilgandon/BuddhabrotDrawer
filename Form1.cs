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



        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            /*   if (sfdBrot.ShowDialog() == DialogResult.OK)
               {
                   string file_name = sfdBrot.FileName;
                   if (!file_name.Contains(".")) file_name += ".bmp";
                   string ext = file_name.Substring(file_name.LastIndexOf(".")).ToLower();

                   switch (ext)
                   {
                       case ".bmp":
                           BrotBitmap.Save(file_name, ImageFormat.Bmp);
                           break;
                       case ".bmgif":
                           BrotBitmap.Save(file_name, ImageFormat.Gif);
                           break;
                       case ".jpg":
                       case ".jpeg":
                           BrotBitmap.Save(file_name, ImageFormat.Jpeg);
                           break;
                       case ".png":
                           BrotBitmap.Save(file_name, ImageFormat.Png);
                           break;
                       case ".tif":
                       case ".tiff":
                           BrotBitmap.Save(file_name, ImageFormat.Tiff);
                           break;
                       default:
                           MessageBox.Show("Unknown file type " + ext);
                           break;
                   }
               }*/
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
        }

        // Draw the Buddhabrot until stopped or
        // we plot the desired number of points.
        async private Task DrawBrots()
        {
            await Task.WhenAll(
              DrawBrot(picCanvas, completionLabel1, drawingCompletionLabel1, Color.Red),
              DrawBrot(pictureBox1, completionLabel2, drawingCompletionLabel2, Color.Green),
              DrawBrot(pictureBox2, completionLabel3 ,drawingCompletionLabel3, Color.Blue));
        }

        async private Task DrawBrot(PictureBox pictureBox, Label completetionLabel, Label drawingCompletetionLabel, Color color)
        {
            // Get parameters.
            int size = int.Parse(txtWidth.Text);
            int cutoff = int.Parse(txtRedCutoff.Text);
            int hitsMax = int.Parse(txtStopAfter.Text);
            int reportEvery = int.Parse(txtDrawEvery.Text);

            if (size <= 0)
            {
                MessageBox.Show("Invalid parameter", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var budda = new Buddhabrot(size, hitsMax);

            var drawingProgress = new Progress<int>(percent =>
            {
                drawingCompletetionLabel.Text = $"Rendering... {percent}%";
            });

            bool drawing = false;
            var progress = new Progress<Buddhabrot>(async (value) =>
            {
                completetionLabel.Text= $"Completion: {value.Completion}%";
                if (!drawing)
                {
                    drawing = true;
                    var bitmap = await Task.Run(() => value.DisplayBrot(drawingProgress, color));
                    pictureBox.Image = bitmap;
                    pictureBox.Refresh();
                    drawing = false;
                }

                if (value.Completed)
                {
                    IsRunning = false;
                }
            });

            await Task.Run(() =>
            {
                budda.Run(progress, cutoff, reportEvery);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawingCompletionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void drawingCompletionLabel2_Click(object sender, EventArgs e)
        {

        }

        private void drawingCompletionLabel4_Click(object sender, EventArgs e)
        {

        }

        private void drawingCompletionLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
