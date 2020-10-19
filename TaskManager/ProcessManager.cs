using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TaskManager
{
    class ProcessManager
    {
        public Process[] processes = Process.GetProcesses();
    }
}
