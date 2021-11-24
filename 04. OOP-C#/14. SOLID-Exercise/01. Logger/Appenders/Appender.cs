using ConsoleApp1.Layouts;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Appenders
{
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get; }
        public LogLevel ReportLevel { get; set; }

        public int Count { get; protected set; }

        public abstract void Append(string dateTime, LogLevel reportLevel, string message);

        public virtual string GetAppenderInfo()
            => $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel}, Messages appended: {Count}";


    }
}
