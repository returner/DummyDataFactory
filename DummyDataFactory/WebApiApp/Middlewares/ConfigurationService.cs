using ServiceInfrastructure.Models;
using SharedModel.Interfaces.Configuration;

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
                    AccessKey = GetConfigurationValue<string>("AWS:AccessKey"),
                    AccessSecret = GetConfigurationValue<string>("AWS:AccessSecret"),
                    PaymentQueueUri = GetConfigurationValue<string>("AWS:PaymentQueueUri"),
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
                        DatabaseName = GetConfigurationValue<string>("AWS:Rds:DatabaseName"),
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
                    Memcachced = new ServerSetting
                    {
                        Name = GetConfigurationValue<string>("AWS:Memcachced:Name"),
                        Address = GetConfigurationValue<string>("AWS:Memcachced:Address"),
                        Port = GetConfigurationValue<int>("AWS:Memcachced:Port"),
                    },
                    Ses = new SesSetting
                    {
                        CredentialUser = GetConfigurationValue<string>("AWS:Ses:CredentialUser"),
                        UserName = GetConfigurationValue<string>("AWS:Ses:UserName"),
                        Password = GetConfigurationValue<string>("AWS:Ses:Password"),
                        SmtpServer = GetConfigurationValue<string>("AWS:Ses:SmtpServer"),
                        Port = GetConfigurationValue<int>("AWS:Ses:Port"),
                        UseTls = GetConfigurationValue<bool>("AWS:Ses:UseTls"),
                        FromAddress = GetConfigurationValue<string>("AWS:Ses:FromAddress"),
                        FromName = GetConfigurationValue<string>("AWS:Ses:FromName"),
                    },
                    SignalR = new SignalRSetting
                    {
                        Redis = new ServerSetting
                        {
                            Name = GetConfigurationValue<string>("AWS:SignalR:Redis:Name"),
                            Address = GetConfigurationValue<string>("AWS:SignalR:Redis:Address"),
                            Port = GetConfigurationValue<int>("AWS:SignalR:Redis:Port"),
                        },
                        Queue = new ServerSetting
                        {
                            Name = GetConfigurationValue<string>("AWS:SignalR:Queue:Name"),
                            Address = GetConfigurationValue<string>("AWS:SignalR:Queue:Address"),
                            Port = GetConfigurationValue<int>("AWS:SignalR:Queue:Port"),
                        }
                    },
                    ServiceBus = new ServiceBusSetting
                    {
                        SendEmail = GetConfigurationValue<string>("AWS:ServiceBus:SendEmail"),
                    },
                },
                Web3 = new Web3Setting
                {
                    Token = GetConfigurationValue<string>("Web3:Token"),
                    Web3Url = GetConfigurationValue<string>("Web3:Web3Url"),
                    Owner_Address = GetConfigurationValue<string>("Web3:Owner_Address"),
                    Contract_Private_Key = GetConfigurationValue<string>("Web3:Contract_Private_Key"),
                },
                CorsOrigins = _configuration.GetSection("AppSettings:CorsOrigins").Get<IEnumerable<string>>(),
                CorsAdminOrigins = _configuration.GetSection("AppSettings:CorsAdminOrigins").Get<IEnumerable<string>>(),
                Henesis = new HenesisSetting
                {
                    Authorization = GetConfigurationValue<string>("Henesis:Authorization"),
                    X_Henesis_Secret = GetConfigurationValue<string>("Henesis:X_Henesis_Secret"),
                    APIUrl = GetConfigurationValue<string>("Henesis:APIUrl"),
                    BTC_id = GetConfigurationValue<string>("Henesis:BTC_id"),
                    BTC_Address = GetConfigurationValue<string>("Henesis:BTC_Address"),
                    ETH_id = GetConfigurationValue<string>("Henesis:ETH_id"),
                    ETH_Address = GetConfigurationValue<string>("Henesis:ETH_Address"),
                    KLAY_id = GetConfigurationValue<string>("Henesis:KLAY_id"),
                    KLAY_Address = GetConfigurationValue<string>("Henesis:KLAY_Address"),
                    Passphrase = GetConfigurationValue<string>("Henesis:Passphrase"),
                },
                Swagger = new SwaggerSetting
                {
                    Title = GetConfigurationValue<string>("Swagger:Title"),
                    Version = GetConfigurationValue<string>("Swagger:Version"),
                    Description = GetConfigurationValue<string>("Swagger:Description"),
                    Link = GetConfigurationValue<string>("Swagger:Link"),
                },
                AdminSwagger = new SwaggerSetting
                {
                    Title = GetConfigurationValue<string>("AdminSwagger:Title"),
                    Version = GetConfigurationValue<string>("AdminSwagger:Version"),
                    Description = GetConfigurationValue<string>("AdminSwagger:Description"),
                    Link = GetConfigurationValue<string>("AdminSwagger:Link"),
                },
                Admin = new AdminSetting
                {
                    BaseAddress = GetConfigurationValue<string>("Admin:BaseAddress"),
                },
                PayCoin = new PayCoinSetting
                {
                    cp_id = GetConfigurationValue<string>("PayCoin:cp_id"),
                    cp_pwd = GetConfigurationValue<string>("PayCoin:cp_pwd"),
                },

                PaypalUrl = _configuration.GetSection("AppSettings:PaypalUrl").Get<string>(),
                PaypalPDTToken = _configuration.GetSection("AppSettings:PaypalPDTToken").Get<string>(),
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
