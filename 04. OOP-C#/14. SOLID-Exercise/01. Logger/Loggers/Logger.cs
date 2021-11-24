using ConsoleApp1.Appenders;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Loggers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            Appenders = new List<IAppender>();
            Appenders.AddRange(appenders);
        }

        public List<IAppender> Appenders { get; }

        public void Critical(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Critical, message);
        }

        public void Error(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Error, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Fatal, message);
        }

        public void Info(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Info, message);
        }

        public void Warning(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Warning, message);
        }

        public string GetLoggerInfo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Appenders)
            {
                sb.AppendLine(item.GetAppenderInfo());
            }

            return sb.ToString().TrimEnd();
        }

        private void Log(string dateTime, LogLevel logLevel, string message)
        {
            foreach (var item in Appenders)
            {
                if (logLevel >= item.ReportLevel)
                {
                    item.Append(dateTime, logLevel, message);
                }
            }
        }
    }
}
