using log.Logtesting;
using System;

namespace Logtesting
{
    public class Student
    {
        private readonly ILoggingHelper _iLoggingHelper;

        public Student()
        {
            _iLoggingHelper = new LoggingHelper();

        }
        public object Sum(int myObj)
        {
            try
            {
                if (myObj ==1)
                {

                        throw new System.ArgumentException("Parameter cannot be one", "original");
                }
                    return myObj;
            }

            catch (Exception ex)
            {
                _iLoggingHelper.Save(ex);
                return null;


            }
        }

    }
}
