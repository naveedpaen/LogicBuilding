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
    public partial class Service1 : ServiceBase
    {
        private readonly Functions _functions;
        private readonly Timer _timer;
        public Service1()
        {
            InitializeComponent();
            _functions = new Functions();
            _timer = new Timer();
        }


        public void Start()
        {
            try
            {
                //timer.Interval = Functions.StartTime;              
                // timer.Interval = 86450000;

                //timer.Interval = tableproperty.Interval;
                //timer.Elapsed += Timer_Elapsed;
                //timer.Start();
            }
            catch (Exception ex)
            {
               // _iLoggingHelper.Save(ex);
            }
        }







        protected override void OnStop()
        {

        }




        // Irshad
        public void OnDebug()
        {
            //StartUp(null,null);
            OnStart(null);
        }


        protected override void OnStart(string[] args)
        {
            _timer.Interval = _functions.Interval;
            _timer.Elapsed += (sender, elapsedArgs) => Doit();
            _timer.Start();
           //  _timer.Elapsed += (sender, elapsedArgs) =>


            //_ilogManager.Save("Service Started", true);
            //_timer.Interval = _timeTableManager.Interval;
            //_timer.Elapsed += (sender, elapsedArgs) => TimeTableCheck();
            //_timer.Start();
        }


        public void Doit()
        {
            try
            {
                _timer.Stop();
                string message = "i am in the Doit method";
               // File.AppendAllText("LogFile.txt", message);
                File.WriteAllText("Logfile2.txt", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }




    }
}
