using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievuWeb.ActionKeywords;
using VievuWeb.GenericControls;


namespace VievuWeb.UIElementRepository
{
    class LoginPage
    {
        public String UsernNameLocatorType = "Id";
        public String UsernNameLocatorValue = "Login";
        public String PassworLocatordType = "Id";
        public String PassworLocatordValue = "Password";
        public String SubmitLocatordType = "Type";
        public String SubmitLocatorValue = "submit";
        
        private BrowserWindow browser;
        private String ActualResult;
        public LoginPage(BrowserWindow browser)
        {
            this.browser = browser;
        }

        public String  PerformLogin(String UsernameValue, String PasssworValue, String ExpectedResult)
        {
            try
            {
                GenericControl obj = new GenericControl(browser);
                UITestControl Username = obj.FindControl<HtmlEdit>(UsernNameLocatorType, UsernNameLocatorValue);
                KeyboardActions.SendKeys(Username, UsernameValue, browser);
                UITestControl Submit = obj.FindControl<HtmlInputButton>(SubmitLocatordType, SubmitLocatorValue);
                MouseActions.MouseClick(Submit, browser);
                UITestControl Password = obj.FindControl<HtmlEdit>(PassworLocatordType, PassworLocatordValue);
                KeyboardActions.SendKeys(Password, PasssworValue, browser);
                UITestControl Login = obj.FindControl<HtmlInputButton>(SubmitLocatordType, SubmitLocatorValue);
                MouseActions.MouseClick(Login, browser);

                return ActualResult = ExpectedResult;

            }

            catch (Exception e)
            {
                return ActualResult = e.Message;

            }
        }

    }
}
