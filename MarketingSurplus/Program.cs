using MarketingSurplus.Data;
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

using Microsoft.EntityFrameworkCore;

using System.Text.Json.Serialization;
using MarketingSurplus.Helper;
using Microsoft.ML;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(config => {
    config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    config.JsonSerializerOptions.Converters.Add(new ByteArrayConverter());
    config.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MarketingSurplusDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServer")));
builder.Services.AddTransient<ICompany, CompanyRepo>();
builder.Services.AddTransient<IAuth, AuthRepo>();
builder.Services.AddTransient<IUser, UserRepo>();
builder.Services.AddTransient<ICompanyType, CompanyTypeRepo>();
builder.Services.AddTransient<IOrder, OrderRepo>();
builder.Services.AddTransient<ICharity, CharityRepo>();
builder.Services.AddTransient<IMain, MainRepo>();
builder.Services.AddTransient<IPayMethod, PayMethodRepo>();
builder.Services.AddTransient<IOrderType, OrderTypeRepo>();
builder.Services.AddTransient<IRate, RateRepo>();
builder.Services.AddTransient<ISubscription, SubscriptionRepo>();

//builder.Services.AddSingleton<MLContext>(new MLContext(seed: 0));
//builder.Services.AddScoped<RestaurantRatingService>(); 

var app = builder.Build();
//builder.Services.Configure<ForwardedHeadersOptions>(options =>
//{
//    options.KnownProxies.Add(IPAddress.Parse("10.0.0.100"));
//});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseForwardedHeaders(new ForwardedHeadersOptions
//{
//    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
//});

app.UseCors(builder =>
    builder
        .WithOrigins("http://37.60.251.74:5000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed(_ => true)
        .AllowCredentials());
app.UseAuthorization();

app.MapControllers();
app.Run();
