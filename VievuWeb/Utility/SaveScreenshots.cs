using System;

using Microsoft.VisualStudio.TestTools.UITesting;
using System.Drawing;
using System.Drawing.Imaging;

namespace VievuWeb.Utility
{
    class SaveScreenshots
    {
        private static  DateTime now = DateTime.Now;
        private static Image image;
        private static String Folderlocation=@"C:\testpictures\";
        public static void GetScreenShot(BrowserWindow browser)
        {
            try
            {
                image = browser.CaptureImage();
                image.Save(Folderlocation + now.ToString("yyyy-MM-ddss") + ".Jpeg", ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                

            }
        }
    }
}
