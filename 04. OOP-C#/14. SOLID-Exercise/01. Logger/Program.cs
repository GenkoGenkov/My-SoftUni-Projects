using ConsoleApp1.Appenders;
using ConsoleApp1.Factory;
using ConsoleApp1.Layouts;
using ConsoleApp1.LogFiles;
using ConsoleApp1.Loggers;
using ConsoleApp1.ReportLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LayoutFactory layoutFactory = new LayoutFactory();

            ILogger logger = new Logger();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] appenderInfo = Console.ReadLine().Split();

                string type = appenderInfo[0];
                string layoutType = appenderInfo[1];

                IAppender appender = null;
                ILayout layout = layoutFactory.Create(layoutType);

                if (type == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (type == "FileAppender")
                {
                    ILogFile logFile = new LogFile();

                    appender = new FileAppender(layout, logFile);
                }

                if (appenderInfo.Length == 3)
                {
                    bool isValidLogLevel = Enum.TryParse(appenderInfo[2], true, out LogLevel logLevel);

                    if (isValidLogLevel)
                    {
                        appender.ReportLevel = logLevel;
                    }
                }

                logger.Appenders.Add(appender);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] messageInfo = input.Split('|');

                string logLevel = messageInfo[0];
                string date = messageInfo[1];
                string message = messageInfo[2];

                bool isValidLogLevel = Enum.TryParse(logLevel, true, out LogLevel messageLogLevel);

                if (!isValidLogLevel)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (messageLogLevel == LogLevel.Info)
                {
                    logger.Info(date, message);
                }
                else if (messageLogLevel == LogLevel.Warning)
                {
                    logger.Warning(date, message);
                }
                else if (messageLogLevel == LogLevel.Error)
                {
                    logger.Error(date, message);
                }
                else if (messageLogLevel == LogLevel.Critical)
                {
                    logger.Critical(date, message);
                }
                else if (messageLogLevel == LogLevel.Fatal)
                {
                    logger.Fatal(date, message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Logger info");
            Console.WriteLine(logger.GetLoggerInfo());
        }
    }
}
