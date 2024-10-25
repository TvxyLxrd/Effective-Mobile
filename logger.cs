using System;
using System.IO;

        namespace DeliveryService
        {
            public class Logger
            {
                    private string logFilePath;

                    public Logger(string path)
                        {
                            logFilePath = path;
                        }

            public void Log(string message)
                {
                    using (StreamWriter sw = new StreamWriter(logFilePath, true))
                        {
                            sw.WriteLine($"{DateTime.Now}: {message}");
                        }
                }
            }
        }
