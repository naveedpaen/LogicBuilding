using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Basic_WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyService()
            };
            ServiceBase.Run(ServicesToRun);

#if DEBUG
            MyService myservice = new MyService();
            myservice.TimeTable();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
#endif





        }
    }
}
