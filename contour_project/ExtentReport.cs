using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contour_project
{
  
        public class ExtentReport
        {
            public static ExtentReports extentReports;
            public static ExtentTest exParentTest;
            public static ExtentTest exChildTest;
            public static string dirpath;
            public static void LogReport(string testcase)
            {
                extentReports = new ExtentReports();
                dirpath = @"C:\Users\MRehm\source\repos\contour-project\contour_project\Extend_Report\" + '_' + testcase;

                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

                htmlReporter.Config.Theme = Theme.Standard;

                extentReports.AttachReporter(htmlReporter);
            }
        }
    
}
