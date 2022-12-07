namespace key_logger.Services
{
    public class ConfigurationService
    {
        public ConfigurationService() { }

        public Configuration Load()
        {
            return new Configuration()
            {
                QtdCharBeforeLog = 50,
                Log = new Log()
                {
                    EnableFileLog = true,
                    HideFile = false,
                    Path = ""
                }
            };
        }
    }
}
