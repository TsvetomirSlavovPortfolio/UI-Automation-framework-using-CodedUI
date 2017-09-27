using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using VievuWeb.BowserFactory;
using VievuWeb.UIElementRepository;
using VievuWeb.Utility;
using VievuWeb.Verification;
namespace VievuWeb
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestCases
    {
        public enum PropertyType
        {
            Id,
            Name,
            ClassName,
            InnerText,
            Type
        }
        private BrowserWindow browser;
        private JArray Inputvalue;
        private static String Output;
        private static List<String> Status;
        private String ActualResult;
        public TestCases()
        {
        }

        [TestInitialize]
        public void Loadtestdata()
        {
            Inputvalue = JArray.Parse(GetTestData.GetTestCaseData());
        }



        [TestMethod]
        public void LoginChrome()
        {
            JArray Inputvalue = JArray.Parse(GetTestData.GetTestCaseData());
            var Module = Inputvalue[0]["ModuleName"].ToString();
            var Submodule = Inputvalue[0]["SubModuleName"].ToString();
            var TestSuiteName = Inputvalue[0]["TestSuiteName"].ToString();
            var Description = Inputvalue[0]["Description"].ToString();
            var ExpectedResult = Inputvalue[0]["ExpectedResult"].ToString();
            var TestCaseType = Inputvalue[0]["TestCaseType"].ToString();
            var members = Inputvalue[0]["Actions"];
            var Password = members[0]["FieldName"].ToString();
            var PasswordValue = members[0]["FieldValue"].ToString();
            var UserName = members[1]["FieldName"].ToString();
            var UsernameValue = members[1]["FieldValue"].ToString();
            ActualResult = ExpectedResult;
            Browser StartBrowser = new Browser();
            browser = StartBrowser.GetBrowser("Chrome", "URL");
            LoginPage login = new LoginPage(browser);
            Output = login.PerformLogin(UsernameValue, PasswordValue, ExpectedResult);
            Status = VerifyResult.Verify(Output, ExpectedResult, ActualResult);
            WriteTestResult.WritestResult(TestSuiteName, Module, Submodule, Description, Status[0].ToString(), ExpectedResult, Status[1].ToString(), Status[2].ToString(), "Chrome", "Desktop", TestCaseType);
        }

        [TestMethod]
        public void LoginIE()
        {
            JArray Inputvalue = JArray.Parse(GetTestData.GetTestCaseData());
            var Module = Inputvalue[0]["ModuleName"].ToString();
            var Submodule = Inputvalue[0]["SubModuleName"].ToString();
            var TestSuiteName = Inputvalue[0]["TestSuiteName"].ToString();
            var Description = Inputvalue[0]["Description"].ToString();
            var ExpectedResult = Inputvalue[0]["ExpectedResult"].ToString();
            var TestCaseType = Inputvalue[0]["TestCaseType"].ToString();
            var members = Inputvalue[0]["Actions"];
            var Password = members[0]["FieldName"].ToString();
            var PasswordValue = members[0]["FieldValue"].ToString();
            var UserName = members[1]["FieldName"].ToString();
            var UsernameValue = members[1]["FieldValue"].ToString();
            ActualResult = ExpectedResult;
            Browser StartBrowser = new Browser();
            browser = StartBrowser.GetBrowser("Ie", "URL");
            LoginPage login = new LoginPage(browser);
            Output = login.PerformLogin(UsernameValue, PasswordValue, ExpectedResult);
            Status = VerifyResult.Verify(Output, ExpectedResult, ActualResult);
            WriteTestResult.WritestResult(TestSuiteName, Module, Submodule, Description, Status[0].ToString(), ExpectedResult, Status[1].ToString(), Status[2].ToString(), "IE", "Desktop", TestCaseType);
        }
        [TestMethod]
        public void LoginChromeNegative()
        {
            JArray Inputvalue = JArray.Parse(GetTestData.GetTestCaseData());
            var Module = Inputvalue[0]["ModuleName"].ToString();
            var Submodule = Inputvalue[0]["SubModuleName"].ToString();
            var TestSuiteName = Inputvalue[0]["TestSuiteName"].ToString();
            var Description = Inputvalue[0]["Description"].ToString();
            var ExpectedResult = Inputvalue[0]["ExpectedResult"].ToString();
            var TestCaseType = Inputvalue[0]["TestCaseType"].ToString();
            var members = Inputvalue[0]["Actions"];
            var Password = members[0]["FieldName"].ToString();
            var PasswordValue = members[0]["FieldValue"].ToString();
            var UserName = members[1]["FieldName"].ToString();
            var UsernameValue = members[1]["FieldValue"].ToString();
            ActualResult = ExpectedResult;
            Browser StartBrowser = new Browser();
            browser = StartBrowser.GetBrowser("Chrome", "https://demo.vievusolution.com/");
            LoginPage login = new LoginPage(browser);
            Output = login.PerformLogin(UsernameValue, PasswordValue, ExpectedResult);
            Status = VerifyResult.Verify("", ExpectedResult, ActualResult);
            WriteTestResult.WritestResult(TestSuiteName, Module, Submodule, Description, Status[0].ToString(), ExpectedResult, Status[1].ToString(), Status[2].ToString(), "Chrome", "Desktop", TestCaseType);
        }


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
