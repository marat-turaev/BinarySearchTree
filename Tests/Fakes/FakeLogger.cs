using System.Collections.Generic;
using Domain;

namespace Tests.Fakes {
    public class FakeLogger : ILogger {
        private readonly List<string> logs = new List<string>();

        public void Log(string logString) {
            logs.Add(logString);
        }

        public bool WasLogged(string logString) {
            return logs.Contains(logString);
        }
    }
}