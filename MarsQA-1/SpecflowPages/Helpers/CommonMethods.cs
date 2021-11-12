using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;

namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) 
                // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        internal static object CreateTest(string v)
        {
            throw new NotImplementedException();
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        public static void ExtentReports()
        {
            //creating html file with tag of the scenario
            var folderLocation = (ConstantHelpers.ReportsPath);

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }
            var tag = ScenarioContext.Current.ScenarioInfo.Title;
            Console.WriteLine(tag);
            var fileName1 = new StringBuilder(folderLocation);
          //  Console.WriteLine(fileName1+"eeeeeeee");
            fileName1.Append(tag.ToString());
            fileName1.Append(DateTime.Now.ToString("_mss"));
            fileName1.Append(".html");
           // Console.WriteLine(fileName1);
            Extent = new ExtentReports(fileName1.ToString(), true, DisplayOrder.NewestFirst);

            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
            
            test = Extent.StartTest(ScenarioContext.Current.ScenarioInfo.Title);

        }

        
    }
    #endregion


}


