using ConsoleApp1.Layouts;
using ConsoleApp1.LogFiles;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.Appenders
{
    public class FileAppender : Appender
    {
        private const string FilePath = "../../../Output/result.txt";
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            LogFile = logFile;
        }

        public ILogFile LogFile { get; }

        public override void Append(string dateTime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(Layout.Format, dateTime, reportLevel, message);

            Count++;

            LogFile.Write(appendMessage);

            File.AppendAllText(FilePath, appendMessage + Environment.NewLine);
        }

        public override string GetAppenderInfo()
        {
            return  $"{base.GetAppenderInfo()}, File size: {LogFile.Size}";
        }
    }
}
