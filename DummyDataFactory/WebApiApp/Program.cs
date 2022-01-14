using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Reflection;
using WebApiApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = new ConfigurationService();
var appSettings = configuration.GetAppSettings();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("default", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
builder.Services.AddResponseCompression(options =>
{
    options.Providers.Add<BrotliCompressionProvider>();
    options.MimeTypes =
        ResponseCompressionDefaults.MimeTypes.Concat(
            new[] { "application/json", "text/plain", "image/svg+xml" });
});
builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Optimal;
});

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = appSettings.Swagger.Title,
        Version = appSettings.Swagger.Version,
        Description = appSettings.Swagger.Description,
        Contact = new OpenApiContact
        {
            Name = "returner",
            Email = "typescripter@gmail.com",
            Url = new Uri(appSettings.Swagger.Link),
        }
    });
    c.EnableAnnotations();
    c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
    });
    c.OperationFilter<AuthorizeCheckOperationFilter>();
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKeyResolver = (s, securityToken, identifier, parameters) =>
                    {
                        using var httpClient = new HttpClient();
                        var jsonWebKeyString = httpClient.GetStringAsync($"{parameters.ValidIssuer}/.well-known/jwks.json").GetAwaiter().GetResult();
                        var keys = JsonConvert.DeserializeObject<JsonWebKeySet>(jsonWebKeyString)?.Keys;
                        return keys;
                    },
                    ValidateIssuer = true,
                    ValidIssuer = appSettings.AWS.Cognito.GetTokenValidIssuer(),
                    ValidateLifetime = true,
                    LifetimeValidator = (before, expires, token, param) => expires > DateTime.UtcNow,
                    ValidateAudience = false,
                    ValidAudience = appSettings.AWS.Cognito.AppClientId,
                };
            });


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseResponseCompression();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DummyDataFactory document");
    //c.RoutePrefix = string.Empty; //if swagger show webroot
});


app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("default");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
