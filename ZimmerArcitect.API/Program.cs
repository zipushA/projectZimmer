using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;
using ZimmerArcitect.API.Middleware;
using ZimmerArcitect.core;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;
using ZimmerArcitect.core.Services;
using ZimmerArcitect.Data;
using ZimmerArcitect.Data.Repositories;
using ZimmerArcitect.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository,OrderRepository>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
builder.Services.AddScoped<IClenerService, CleanerService>();
builder.Services.AddScoped<ICleanerRepository,CleanerRepository>();
builder.Services.AddScoped<IZimmerService, ZimmerService>();
builder.Services.AddScoped<IZimmerRepository, ZimmerRepository>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            ValidAudience = builder.Configuration["JWT:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
        };
    });

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<ShabbatMiddleware>();
app.MapControllers();

app.Run();
