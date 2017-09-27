using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievuWeb.Utility;

namespace VievuWeb.ActionKeywords
{
    class MouseActions
    {
        private static String Errormessage;
        /// <summary>
        /// Perform Mouse Click opeartion on Element
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="browser"></param>
        public static void MouseClick(UITestControl Element, BrowserWindow browser)
        {
            try
            {
                Mouse.Click(Element);
                SaveScreenshots.GetScreenShot(browser);
            }


            catch (Exception e)
            {
                Errormessage = e.Message;
                SaveScreenshots.GetScreenShot(browser);
            }
        }
        /// <summary>
        /// Scrolls the mouse wheel on the specified control the specified number of times.
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="browser"></param>
        /// <param name="value"></param>
        public static void MouseScroll(UITestControl Element, BrowserWindow browser, int value)
        {
            try
            {
                Mouse.MoveScrollWheel(Element, value);
                SaveScreenshots.GetScreenShot(browser);
            }


            catch (Exception e)
            {
                Errormessage = e.Message;
                SaveScreenshots.GetScreenShot(browser);
            }
        }


    }
}
