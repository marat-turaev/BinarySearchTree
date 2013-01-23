using System.IO;
using Domain;

namespace Infrastructure {
    public class PlainTextLogger : ILogger {
        public void Log(string logString) {
            using (var writer = new StreamWriter("log.txt", true)) {
                writer.WriteLine(logString);
            }
        }
    }
}