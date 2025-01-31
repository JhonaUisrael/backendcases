using Application;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);




// Registrar servicios
builder.Services.AddScoped<ICaseRepository, CaseRepository>();
builder.Services.AddScoped<CreateCaseService>();
builder.Services.AddScoped<GetAllCasesService>();



// Persistencia
builder.Services.AddDbContext<AppDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//interfaz swagger 
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "Version .Net 9.0.x",
        Title = "Swagger UI Personalized .Net 9",
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();


app.Run();


