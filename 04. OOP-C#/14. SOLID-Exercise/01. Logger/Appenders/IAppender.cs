using ConsoleApp1.Layouts;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get; }

        public int Count { get;}

        public LogLevel ReportLevel { get; set; }
        void Append(string dateTime, LogLevel reportLevel, string message);

        string GetAppenderInfo();
    }
}
