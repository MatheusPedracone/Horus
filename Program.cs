using Horus.Business;
using Horus.Business.Implementations;
using Horus.Data;
using Horus.Repository;
using Horus.Repository.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();

builder.Services.AddApiVersioning();

builder.Services.AddScoped<IEventRepository, EventRepositoryImplementation>();
builder.Services.AddScoped<IModuleRepository, ModuleRepositoryImplementation>();
builder.Services.AddScoped<IClientRepository, ClientRepositoryImplementation>();
builder.Services.AddScoped<ISystemModuleRepository, SystemModuleRepositoryImplementation>();
builder.Services.AddScoped<ISystemEventRepository, SystemEventRepositoryImplementation>();

builder.Services.AddScoped<IEventBusiness, EventBusinessImplementation>();
builder.Services.AddScoped<IModuleBusiness, ModuleBusinessImplementation>();
builder.Services.AddScoped<IClientBusiness, ClientBusinessImplementation>();
builder.Services.AddScoped<ISystemEventBusiness, SystemEventBusinessImplementation>();
builder.Services.AddScoped<ISystemModuleBusiness, SystemModuleEventBusinessImplementation>();



builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo { Title = "Horus", Version = "v1" });
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config => config.SwaggerEndpoint("/swagger/v1/swagger.json", "Horus v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.UseCors(config =>
            {
                config.AllowAnyHeader();
                config.AllowAnyMethod();
                config.AllowAnyOrigin();
            });
