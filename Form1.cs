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
            int report = int.Parse(txtDrawEvery.Text);

            buddhaRed = new Buddhabrot(size, buddhabrotUserControl1.Iteration, hitsMax);
            buddhaGreen = new Buddhabrot(size, buddhabrotUserControl2.Iteration, hitsMax);
            buddhaBlue = new Buddhabrot(size, buddhabrotUserControl3.Iteration, hitsMax);

            await Task.WhenAll(
              buddhabrotUserControl1.DrawBrot(buddhaRed, report),
              buddhabrotUserControl2.DrawBrot(buddhaGreen, report),
              buddhabrotUserControl3.DrawBrot(buddhaBlue, report));

        }

    }
}
