using System.IO;
using Domain;

namespace Infrastructure {
    public class PlainTextLogger : Logger {
        protected override void WriteLog(string logString) {
            using (var writer = new StreamWriter("log.txt", true)) {
                writer.WriteLine(logString);
            }
        }
    }
}