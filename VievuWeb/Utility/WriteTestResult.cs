using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuWeb.Utility
{
    class WriteTestResult
    {
        private static DateTime now = DateTime.Now;

        public static void WritestResult(String TestSuiteName, String ModuleName, String SubModuleName, String TestCase, String ActionResult, String ExpectedResult, String Status, String Error, String Browser, String SUT, String TestCaseType)
        {
            WriteResultData Result = new WriteResultData();
            Result.ID = Guid.NewGuid();
            Result.TestSuiteName = TestSuiteName;
            Result.ModuleName = ModuleName;
            Result.SubModuleName = SubModuleName;
            Result.TestCase = TestCase;
            Result.ActionResult = ActionResult;
            Result.ExpectedResult = ExpectedResult;
            Result.Status = Status;
            Result.Error = Error;
            Result.Browser = Browser;
            Result.SUT = SUT;
            Result.TestCaseType = TestCaseType;
            Result.CreatedOn = now;
            string JsonString = JsonConvert.SerializeObject(Result);
            var client = new RestClient("http://vievuautomationapi.cloudapp.net/api/TestResults");
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonString, ParameterType.RequestBody);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response);


        }
    }
}
    