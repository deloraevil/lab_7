using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace odintsov
{
    class OdintsovLog: LogAbstract, LogInterface
    {
        public List<string> memory = new List<string>();
        private OdintsovLog() { }

        private static OdintsovLog odintsovLog = null;
        public static OdintsovLog I()
        {
            if (odintsovLog == null)
            {
                odintsovLog = new OdintsovLog();
            }

            return odintsovLog;
        }

        public LogInterface log(string str)
        {
            memory.Add(str);
            return this;
        }

        public LogInterface write()
        {
            foreach (var item in memory)
            {
                writeConsole(item);
            }

            return this;
        }
    }
}
