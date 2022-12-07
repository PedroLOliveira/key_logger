using System;

namespace key_logger.Services
{
    public class LogService
    {
        private readonly Configuration _configuration;
        private readonly FileService _fileService;
        private readonly TextBuffer _buffer;

        public LogService(Configuration configuration)
        {
            _configuration = configuration;
            _fileService = new FileService(configuration.Log);

            _buffer = new TextBuffer(configuration.QtdCharBeforeLog);
            _buffer.BufferOverflowed += _buffer_BufferOverflowed;
        }

        public void AddEntryToLog(string text)
        {
            _buffer.Add(text);

            Console.WriteLine(text);
        }

        private void _buffer_BufferOverflowed(string text)
        {
            if (_configuration.Log.EnableFileLog)
                _fileService.LogToFile(text);
        }
    }
}
