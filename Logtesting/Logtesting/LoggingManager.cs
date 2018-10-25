using System;
using System.IO;
using System.Data.SqlClient;





namespace log.Logtesting

{
    public class CustomLoggArgs : EventArgs
    {
        public Exception Exception { get; set; }
    }

    public class LoggingHelper : ILoggingHelper
    {
        public LoggingHelper()
        {
            var logFile = "Loggs.txt";
            if (!new FileInfo(logFile).Exists) File.Create(logFile);
        }

        public bool Save(string message)
        {
            try
            {
                File.AppendAllText("Loggs.txt", message);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                OnNewLog?.Invoke(this, new CustomLoggArgs {Exception = new Exception(message)});
            }
        }

        public bool Save(Exception exception)
        {
            try
            {
                Save(FormatLogg(ToFriendlyError(exception)));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                OnNewLog?.Invoke(this, new CustomLoggArgs {Exception = exception});
            }
        }

        public event EventHandler OnNewLog;

        private string FormatLogg(string logg)
        {
            return $@"{Environment.NewLine}{Environment.NewLine} 
                      --------------{DateTime.Now}-------------- 
                                 {Environment.NewLine}
                                        {logg}";
        }


        public  string ToFriendlyError(Exception ex)
        {
            var msg = new System.Text.StringBuilder();
            msg.Append("Exception Message: " + ex.Message);
            msg.Append("Exception Src : " + ex.Source);
            msg.Append("Exception StackTrace : " + ex.StackTrace);
            var innerExecption = ex.InnerException;
            while (innerExecption != null)
            {
                msg.Append("InnerException Msg : " + innerExecption.Message);
                msg.Append("InnerException Src : " + innerExecption.Source);
                msg.Append("InnerException StackTrace : " + innerExecption.StackTrace);
                innerExecption = innerExecption.InnerException;
            }






            //SqlException
            var exception = ex as SqlException;
            if (exception == null) return msg.ToString();
            var dbEx = exception;
            msg.Append("Sql Exceptions: ");
            msg.Append("Exceptions Error Number: " + exception.Number);
            msg.Append("Exceptions Message: " + exception.Message);





            // / Enable it for EntityFramework
            //var exception = ex as DbEntityValidationException;
            //if (exception == null) return msg.ToString();
            //var dbEx = exception;
            //msg.Append("EntityFramework Errors: ");
            //foreach (var exItems in dbEx.EntityValidationErrors)
            //{
            //    foreach (var validationError in exItems.ValidationErrors)
            //    {
            //        msg.Append(" PropertyName" + validationError.PropertyName + $"Error msg : " + validationError.ErrorMessage);
            //    }
            //}


            return msg.ToString();

        }
    }
}