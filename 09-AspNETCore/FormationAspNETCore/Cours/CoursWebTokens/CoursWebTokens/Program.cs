using CoursWebTokens.Interfaces;
using CoursWebTokens.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Création du service pour l'authentification
builder.Services.AddAuthentication(a =>
{
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "m2i",
        ValidAudience = "m2i",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto"))
    };
});

// Add JWT Service
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("admin", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "admin");

    });
    options.AddPolicy("user", police =>
    {
        police.RequireClaim(ClaimTypes.Role, "user", "admin");
    });
});

// Injection du service TokenService
builder.Services.AddScoped<ITokenService, TokenService>();


// Ajout du service EntityFrameworkCore (si utilisé)
//builder.Services.AddContext<DataDBContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ajout du service à l'application
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
