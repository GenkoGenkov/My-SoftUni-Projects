using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LogFiles
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string message);
    }
}
