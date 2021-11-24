using ConsoleApp1.Layouts;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string dateTime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(Layout.Format, dateTime, reportLevel, message);

            Count++;

            Console.WriteLine(appendMessage);
        }
    }
}
