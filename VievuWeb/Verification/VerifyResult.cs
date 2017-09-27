using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuWeb.Verification
{
    class VerifyResult
    {

        private static String Error;
        private static  List<String> ActualResult = new List<string>();
        public static List<String> Verify(String Output, String ExpectedResult, String actualResult)
        {
            if (Output == ExpectedResult)
            {
                Error = "";
                ActualResult.Add(actualResult);
                ActualResult.Add("Passed");
                ActualResult.Add(Error);


            }
            else
            {
                Error = Output.ToString();
                actualResult = "";
                ActualResult.Add(actualResult);
                ActualResult.Add("Failed");
                ActualResult.Add(Error);
            }


            return ActualResult;
        }
    }
}
