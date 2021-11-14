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

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;

        [BeforeFeature]
        public static void ExtentReports()
        {
            //creating html file with tag of the scenario
            var folderLocation = (ConstantHelpers.ReportsPath);

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }
            // var tag = ScenarioContext.Current.ScenarioInfo.Title;
            var tag = FeatureContext.Current.FeatureInfo.Title;
            //  Console.WriteLine(tag);
            var fileName1 = new StringBuilder(folderLocation);
            //  Console.WriteLine(fileName1+"eeeeeeee");
            fileName1.Append(tag.ToString());
            fileName1.Append(DateTime.Now.ToString("_mss"));
            fileName1.Append(".html");
            // Console.WriteLine(fileName1);
            Extent = new ExtentReports(fileName1.ToString(), true, DisplayOrder.NewestFirst);

            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);

            
        }

        #endregion
        [BeforeScenario(Order = 3)]
        public void Setup()
        {
            test = Extent.StartTest(ScenarioContext.Current.ScenarioInfo.Title);

            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Dell\Documents\mars\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class


            Thread.Sleep(3000);

            SignIn.SigninStep();
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");

            // CommonMethods.ExtentReports();

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
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            //endtest.(Reports)
            Extent.EndTest(test);


            // calling Flush writes everything to the log file (Reports)
            Extent.Flush();


        }
        [AfterStep]
        public static void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                test.Log(LogStatus.Pass, context.StepContext.StepInfo.Text);
            }
            else
            {
                test.Log(LogStatus.Pass, context.StepContext.StepInfo.Text);


            }

        }
        
    }
}


