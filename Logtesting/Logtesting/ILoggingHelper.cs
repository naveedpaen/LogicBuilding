using System;

namespace log.Logtesting
{
    public interface ILoggingHelper
    {
        bool Save(Exception exception);
        bool Save(string message);


    }
}