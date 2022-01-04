namespace svietnamAPI.StartupConfig.AppSettingConfig
{
    public class ServerSetting
    {
        public Jwt Jwt { get; set; }
        public StaticFile StaticFile { get; set; }
        public Host Host { get; set; }
        public Database Database { get; set; }
    }
}