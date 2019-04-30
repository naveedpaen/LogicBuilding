using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Basic_WindowsService
{
   public partial  class MyService : ServiceBase
    {
        public readonly Timer timer;
        public readonly Functions functions;

        public MyService()
        {
            timer = new Timer();
            functions = new Functions();
        }

        public void TimeTable()
        { 
            timer.Start();
            timer.Interval = functions.Interval;
            timer.Elapsed += (sender, elapsedArgs) => Functionality();
        }

        public void Functionality()
        {
            timer.Stop();
            // Functionality
            File.AppendAllText("test.txt", "Windows servic Worked !!");
            timer.Start();
        }

    }
}
