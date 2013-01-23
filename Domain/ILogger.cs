using System.Collections.Generic;

namespace Domain {
    public abstract class Logger {
        public readonly List<string> Logs = new List<string>();

        public void Log(string logString) {
            WriteLog(logString);
            Logs.Add(logString);
        }

        protected abstract void WriteLog(string logString);
    }
}