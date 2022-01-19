
using ConfigurationModel.Interfaces;
using ConfigurationModel.Models;

namespace WebApiApp.Middlewares
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly string _environmentName;
        private readonly string? _currentDirectory;
        private readonly IConfiguration _configuration;

        public ConfigurationService()
        {
            _currentDirectory = AppContext.BaseDirectory;
            _environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty;

            _configuration = new ConfigurationBuilder()
                .SetBasePath(_currentDirectory)
                .AddJsonFile($"appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{_environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
        public IAppSettings GetAppSettings()
        {
            var appsettings = new AppSettings
            {
                Environment = _configuration.GetSection("AppSettings:Environment").Get<string>(),
                AWS = new AwsSetting
                {
                    S3 = new S3Setting
                    {
                        BucketName = GetConfigurationValue<string>("AWS:S3:BucketName"),
                        Path = new S3PathSetting
                        {
                            Root = GetConfigurationValue<string>("AWS:S3:Path:Root"),
                            Images = GetConfigurationValue<string>("AWS:S3:Path:Images"),
                            Thumbnails = GetConfigurationValue<string>("AWS:S3:Path:Thumbnails"),
                            Videos = GetConfigurationValue<string>("AWS:S3:Path:Videos"),
                            Sounds = GetConfigurationValue<string>("AWS:S3:Path:Sounds"),
                            Boards = GetConfigurationValue<string>("AWS:S3:Path:Boards"),
                            Profiles = GetConfigurationValue<string>("AWS:S3:Path:Profiles"),
                            ListThumbnail = GetConfigurationValue<string>("AWS:S3:Path:ListThumbnail"),
                            ViewThumbnail = GetConfigurationValue<string>("AWS:S3:Path:ViewThumbnail"),
                        }
                    },
                    Rds = new RdsSetting
                    {
                        ConnectionString = GetConfigurationValue<string>("AWS:Rds:ConnectionString"),
                        DbVersion = GetConfigurationValue<string>("AWS:Rds:DbVersion"),
                    },
                    Cognito = new CognitoSetting
                    {
                        RegionId = GetConfigurationValue<string>("AWS:Cognito:RegionId"),
                        UserPoolName = GetConfigurationValue<string>("AWS:Cognito:UserPoolName"),
                        UserPoolId = GetConfigurationValue<string>("AWS:Cognito:UserPoolId"),
                        AppClientId = GetConfigurationValue<string>("AWS:Cognito:AppClientId"),
                        TokenValidIssuer = GetConfigurationValue<string>("AWS:Cognito:TokenValidIssuer"),
                        HostingUiUri = GetConfigurationValue<string>("AWS:Cognito:HostingUiUri"),
                    },
                    AdminCognito = new CognitoSetting
                    {
                        RegionId = GetConfigurationValue<string>("AWS:AdminCognito:RegionId"),
                        UserPoolName = GetConfigurationValue<string>("AWS:AdminCognito:UserPoolName"),
                        UserPoolId = GetConfigurationValue<string>("AWS:AdminCognito:UserPoolId"),
                        AppClientId = GetConfigurationValue<string>("AWS:AdminCognito:AppClientId"),
                        TokenValidIssuer = GetConfigurationValue<string>("AWS:AdminCognito:TokenValidIssuer"),
                        HostingUiUri = GetConfigurationValue<string>("AWS:AdminCognito:HostingUiUri"),
                    },
                },
                CorsOrigins = _configuration.GetSection("AppSettings:CorsOrigins").Get<IEnumerable<string>>(),
                Swagger = new SwaggerSetting
                {
                    Title = GetConfigurationValue<string>("Swagger:Title"),
                    Version = GetConfigurationValue<string>("Swagger:Version"),
                    Description = GetConfigurationValue<string>("Swagger:Description"),
                    Link = GetConfigurationValue<string>("Swagger:Link"),
                },
            };

            return appsettings;
        }

        private T GetConfigurationValue<T>(string key, bool isAppSettings = true)
        {
            if (isAppSettings)
            {
                return _configuration.GetSection($"AppSettings:{key}").Get<T>();

            }
            return _configuration.GetSection($"Serilog:{key}").Get<T>();

        }
    }
}
