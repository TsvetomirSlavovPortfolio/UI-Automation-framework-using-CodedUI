using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuWeb.Utility
{
    class GetTestData
    {
        public static String GetTestCaseData()
        {
            var client = new RestClient("http://vievuautomationapi.cloudapp.net/api/TestData/394BA378-6299-4DD7-92EB-5454E8FD021A");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var testdata = response.Content;
            var jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return testdata;

        }
    }
}
