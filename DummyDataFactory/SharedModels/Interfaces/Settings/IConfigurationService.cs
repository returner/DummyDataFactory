namespace SharedModel.Interfaces.Configuration
{
    public interface IConfigurationService
    {
        //IConfiguration GetConfiguration();
        IAppSettings GetAppSettings();
    }
}