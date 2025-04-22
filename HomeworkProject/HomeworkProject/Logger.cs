using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkProject
{
    public static class Logger
    {
        public static async Task LoggerAsync(string methodName, bool isSuccess)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string logFileName = $"Logs_{date}.txt";
            string logMessage = $"{DateTime.Now:G} / {methodName} / {(isSuccess ? "success" : "failure")}";

            try
            {
                using (StreamWriter write = new StreamWriter(logFileName, true, Encoding.UTF8))
                {
                    await write.WriteLineAsync(logMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houston we have a problem: " + ex.Message);
            }
        }
    }
}
