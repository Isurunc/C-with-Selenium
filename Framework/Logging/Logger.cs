using System;
using System.IO;

namespace Framework.Logging {

public class Logger {

private readonly string _filepath;

public Logger(string testName, string filepath)
        {
            _filepath = filepath;

            using (var log = File.CreateText(_filepath))
            {
                log.WriteLine($"Starting timestamp: {DateTime.Now.ToLocalTime()}");
                log.WriteLine($"Test: {testName}");
            }
        }

        public void info (string message){
            WriteLine($"[INFO]: {message}");

        }

        public void step(string message)
        {
            WriteLine($"..... [STEP]: {message}");
        }


        public void warning(string message)
        {
            WriteLine($"[WARNING]: {message}");
        }

        public void error(string message)
        {
            WriteLine($"[ERROR]: {message}");
        }

        public void fatal(string message)
        {
            WriteLine($"[FATAL]: {message}");
        }

       public void WriteLine (string text) {

           using (var log = File.AppendText(_filepath)) {

               log.WriteLine(text);
           }
       }


       private void Write (string text) {
           using (var log = File.AppendText(_filepath)) {
              log.Write(text); 
       }

}

 }
}
