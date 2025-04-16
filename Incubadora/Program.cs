using Incubadora.Project.Database;
using Incubadora.Project.Domain.Infrastructure.Facade;
using Incubadora.Project.Domain.Infrastructure.Service;
using Incubadora.Project.Domain.Repository.Interface;
using Incubadora.Project.Domain.Repository;
using Incubadora.Project.Infrastructure.Facade;
using Incubadora.Project.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using Incubadora.Swagger;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfigurator();

// implementar mapper
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IIncubadoraRepository, IncubadoraRepository>();
builder.Services.AddScoped<IIncubadoraStatusRepository, IncubadoraStatusRepository>();
builder.Services.AddScoped<IUsuarioFacade, UsuarioFacade>();
builder.Services.AddScoped<IIncubadoraFacade, IncubadoraFacade>();
builder.Services.AddScoped<ICryptographyService, CryptographyService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProjectContext>(op => op.UseSqlServer(connectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
