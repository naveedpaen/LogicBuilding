using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
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


        public void OnDebug()
        {
            Start();
        }




        protected override void OnStop()
        {
        }




        // Irshad
        public void OnDebug2()
        {
            //StartUp(null,null);
            OnStart(null);
        }


        protected override void OnStart(string[] args)
        {
            //_ilogManager.Save("Service Started", true);
            //_timer.Interval = _timeTableManager.Interval;
            //_timer.Elapsed += (sender, elapsedArgs) => TimeTableCheck();
            //_timer.Start();
        }


    }
}
