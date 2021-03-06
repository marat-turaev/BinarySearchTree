﻿using System.IO;
using Domain;

namespace Infrastructure {
    public class HtmlLogger : Logger {
        protected override void WriteLog(string logString) {
            using (var writer = new StreamWriter("log.html", true)) {
                writer.WriteLine("<h1>" + logString + "</h1>");
            }
        }
    }
}