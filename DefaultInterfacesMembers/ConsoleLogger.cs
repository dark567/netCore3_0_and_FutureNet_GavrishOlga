using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfacesMembers
{
    class ConsoleLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            throw new NotImplementedException();
        }
    }
}
