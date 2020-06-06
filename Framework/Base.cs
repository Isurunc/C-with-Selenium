using System;
using System.IO;
using Framework.Logging;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Framework {

//this class is to create logs
    public class Base {

        public static string WORKSPACE_DIRECTORY = Path.GetFullPath(@"../../../../");

        public static Logger Log => _logger ?? throw new NullReferenceException("_logger is null. SetLogger() first.");


        public static frameworkConfig Config =>_configuration ?? throw new NullReferenceException ("config is null. Call Base.SetConfig() first"); 


     
     [ThreadStatic]
    public static DirectoryInfo CurrentTestDirectory;

    [ThreadStatic]
    private static Logger _logger;

    private static frameworkConfig  _configuration;


public static DirectoryInfo CreateTestResultsDirectory()
        {
            var testDirectory = WORKSPACE_DIRECTORY + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, recursive: true);
            }

            return Directory.CreateDirectory(testDirectory);
        }


        public static void SetConfig (){

            if (_configuration ==null) {

                var jsonStr = File.ReadAllText(WORKSPACE_DIRECTORY + "/framework_config.json") ;
                _configuration = JsonConvert.DeserializeObject<frameworkConfig>(jsonStr);
            }
        }

        public static void SetLogger()
    {

         lock (_setLoggerLock){

            var testResultsDir = WORKSPACE_DIRECTORY + "TestResults";
            var testName = TestContext.CurrentContext.Test.Name;
            var fullPath = $"{testResultsDir}/{testName}";



          if (Directory.Exists(fullPath))
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath + TestContext.CurrentContext.Test.ID);
                }
                else
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath);
                }

            CurrentTestDirectory = Directory.CreateDirectory(fullPath);
            _logger = new Logger(testName, CurrentTestDirectory.FullName + "/log.txt");
        }
    }

        private static object _setLoggerLock = new object();
        
        
    }
}