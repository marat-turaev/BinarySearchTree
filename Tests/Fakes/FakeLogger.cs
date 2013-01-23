using System.Collections.Generic;
using Domain;

namespace Tests.Fakes {
    public class FakeLogger : Logger {
        protected override void WriteLog(string logString) {
        }
    }
}