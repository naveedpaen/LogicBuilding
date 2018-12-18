using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.IO;

namespace WindowsService
{
    public partial class MyService : ServiceBase
    {
        private readonly Functions _functions = new Functions();
        private readonly Timer _timer;
        public MyService()
        {
            InitializeComponent();
            _functions = new Functions();
            _timer = new Timer();
          //  _functions.Id = 5;
        }


        protected override void OnStop()
        {

        }


        public void OnDebug()
        {
            OnStart(null);
        }


        protected override void OnStart(string[] args)
        {
            _timer.Interval = _functions.Interval;
            _timer.Elapsed += (sender, elapsedArgs) => TimeTable();
            _timer.Start();
            Functions o = new Functions();
        }


        public void TimeTable()
        {
            try
            {
                _functions.Id = 30;
                _timer.Stop();
                string message = "i am in the Doit method";
                File.AppendAllText("FileName.txt" , "write this text in the file");
                File.WriteAllText("Logfile2.txt", message);
                // if (!DateTime.Now.Equals(DayOfWeek.Tuesday) || !DateTime.Now.Equals(DayOfWeek.Sunday))
                if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Monday) || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    Functionality();
                }


               // File.AppendAllText("LogFile.txt", message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void Functionality()
        {
       


        }






    }
}
