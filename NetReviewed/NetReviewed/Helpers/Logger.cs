using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NetReviewed.Helpers
{
    public class Logger
    {
        const string LOG_SWITCH = "LinqToSqlLog";
        static BooleanSwitch logSwitch;
        public static void Log(string statement)
        {
            
            logSwitch = new BooleanSwitch(LOG_SWITCH, LOG_SWITCH);
            if (logSwitch.Enabled)
            {
                Trace.Flush();
                var logStatement = string.Format("{0}{1}{2}{1}", DateTime.Now, Environment.NewLine, statement);
                Trace.WriteLine(logStatement);                
                Trace.Close();
            }
        }
    }
}
