using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
}
