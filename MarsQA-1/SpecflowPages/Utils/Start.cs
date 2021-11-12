using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Dell\Documents\mars\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
           

            Thread.Sleep(3000);
            
            SignIn.SigninStep();
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");


            CommonMethods.ExtentReports();
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

        }

        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(3000);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            
            //
           //CommonMethods.ExtentReports();
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();
             
             //endtest.(Reports)
             CommonMethods.Extent.EndTest(test);
            
            
           // calling Flush writes everything to the log file (Reports)
             CommonMethods.Extent.Flush();
           

        }
    }
}
