using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BuddhabrotDrawer
{
    public partial class BuddhabrotUserControl : UserControl
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Buddhabrot _buddha;

        public BuddhabrotUserControl()
        {
            InitializeComponent();
        }
        

        async public Task DrawBrot()
        {
            var buddha = new Buddhabrot(SizePixel, Iteration, Hits);
            var progress = new Progress<BuddhabrotReportProgress>(reportProgress =>
            {
                int lastDraw = 0;
                var buddhabrot = reportProgress.Buddhabrot;
                this.completionLabel.Text = $"Completion: {buddhabrot.Completion}%";
                if (buddhabrot.Completion - lastDraw > 1)
                {
                    lastDraw = buddhabrot.Completion;
                    var drawer = new BuddhabrotMonoColor(buddhabrot);
                    var bitmap = drawer.Draw();
                    this.picCanvas.Image = bitmap;
                    this.picCanvas.Refresh();
                }

                if (reportProgress.Completed)
                {
                    var drawer = new BuddhabrotMonoColor(buddhabrot);
                    var bitmap = drawer.Draw();
                    bitmap.Save(Buddhabrot.GetSavePath(buddhabrot.Iteration), ImageFormat.Bmp);
                }
            });

            await Task.Run(() =>
            {
                buddha.Run(progress);
            });
        }

        public int Iteration => (int)iterationNumericUpDown.Value;
        public int SizePixel => (int)sizeNumericUpDown.Value;
        public int Hits => (int)pointsCountNumericUpDown.Value;
        async private void button1_Click(object sender, EventArgs e)
        {
            await DrawBrot();
        }
    }
}
