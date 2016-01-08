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
        public BuddhabrotUserControl()
        {
            InitializeComponent();
        }

        public BuddhabrotUserControl(Buddhabrot Buddhabot)
        {
            InitializeComponent();
        }


        async public Task DrawBrot(Buddhabrot buddha, int reportEveryPercent)
        {
            var progress = new Progress<BuddhabrotReportProgress>(reportProgress =>
            {
                int lastDraw = 0;
                var buddhabrot = reportProgress.Buddhabrot;
                this.label1.Text = $"Completion: {buddhabrot.Completion}%";
                if (buddhabrot.Completion - lastDraw > reportEveryPercent)
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

        public int Iteration => (int)numericUpDown1.Value;

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
