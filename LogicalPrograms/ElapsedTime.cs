using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ElapsedTime
    {
        
           private static void StopWatch()
            {
            //
            ElapsedTime stopwatch = new ElapsedTime();

            //stopwatch started
            stopwatch.Start();


            //stopwatch stoped
            stopwatch.Stop();

            //timespan used to store time intervals
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            
            
        }
    }
}

