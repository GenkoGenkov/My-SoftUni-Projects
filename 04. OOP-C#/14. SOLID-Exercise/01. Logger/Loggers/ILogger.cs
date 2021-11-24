using ConsoleApp1.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loggers
{
    public interface ILogger
    {
        public List<IAppender> Appenders { get; }

        string GetLoggerInfo();

        void Info(string dateTime, string message);
        void Warning(string dateTime, string message);
        void Error(string dateTime, string message);
        void Critical(string dateTime, string message);
        void Fatal(string dateTime, string message);

    }
}
