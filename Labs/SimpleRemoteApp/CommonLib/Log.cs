using System;

namespace CommonLib
{
    public class Log
    {
        private Log()
        {
        }

        public static void Print(string text, params object[] args)
        {
            DoLog("", text, args);
        }

        

        private static void DoLog(string prefix, string text, params object[] args)
        {
            
            int threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
            Console.Write("[{0:D4}] [{1}] ",
                threadId,
                DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            Console.Write(prefix);
            Console.WriteLine(text, args);
        }
    } 	
}
