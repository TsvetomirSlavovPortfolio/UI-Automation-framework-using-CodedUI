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
    class KeyboardActions
    {
        
        
        private static String Errormessage;
        
        public static void SendKeys(UITestControl Element, String text, BrowserWindow browser)
        {
            try
            {
                Keyboard.SendKeys(Element, text);
                SaveScreenshots.GetScreenShot(browser);


            }

            catch (Exception e)
            {
                Errormessage= e.Message;
                SaveScreenshots.GetScreenShot(browser);
                
            }


        }
    }
}
