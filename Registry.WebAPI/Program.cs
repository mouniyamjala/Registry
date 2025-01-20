using Microsoft.EntityFrameworkCore;
using Registry.Data;
using Registry.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional:false, reloadOnChange: true);

var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultString")
                       ?? builder.Configuration.GetConnectionString("DefaultString");

//DbConnection
builder.Services.AddDbContext<RegistryDbContext>(options =>
options.UseSqlServer(connectionString));


builder.Services.AddScoped(typeof(IRegistryRepository), typeof(RegistryRepository));
builder.Services.AddScoped<IRegistryService, RegistryService>();

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
