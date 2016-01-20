using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace BuddhabrotDrawer
{
    public class ImagePostProcessing
    {
        public static void AutoContrast(string imageDirectory, string outputDirectory)
        {
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            Parallel.ForEach(Directory.EnumerateFiles(imageDirectory), file =>
            {
                var info = new FileInfo(file);
                try
                {
                    using (var bitmap = (Bitmap)Image.FromFile(file))
                    using (var contrasted = bitmap.AdjustContrast(0.05, 0.99))
                    {
                        contrasted.Save(Path.Combine(outputDirectory, info.Name), ImageFormat.Jpeg);
                    }

                }
                catch (OutOfMemoryException)
                {
                    // not a valid image, swallow the exception
                }
            });
        }
    }
}