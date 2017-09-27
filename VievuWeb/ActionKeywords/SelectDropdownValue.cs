using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using VievuWeb.Utility;

namespace VievuWeb.ActionKeywords
{
    class SelectDropdownValue
    {
        private static String Errormessage;
        public static void SelectValue(UITestControl Element,BrowserWindow browser, string value)
        {
            try
            {
                Element.SetProperty("SelectedItem", value);
            }
            catch(Exception e)
            {
                Errormessage = e.Message;
                SaveScreenshots.GetScreenShot(browser);
            }

        }
    }
}
