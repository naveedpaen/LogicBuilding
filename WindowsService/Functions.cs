﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
   public class Functions
    {

        private int interval;

        public int Interval
        {
            get { return Convert.ToInt32(ConfigurationSettings.AppSettings["interval"]); }
            set { interval = value; }
        }

        public int Id { get; set; }



    }

}
