using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfacesMembers
{
    interface ILogger
    {
        void Log(LogLevel level, string message);
        void Log(Exception ex) => Log(LogLevel.Error, ex.ToString()); //new overload
    }

}
