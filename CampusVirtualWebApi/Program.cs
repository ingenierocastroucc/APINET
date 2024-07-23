#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# API REST>                                                                      
* DescripciÓn   : <Logica de negocio para realizar el llamado de los servicios y la conexion a base de datos>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>                                                                             
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWeb.Context;
using CampusVirtualWebApi.Middlewares;
using CampusVirtualWebApi.Services;
using CampusVirtualWebApi.ServicesCampus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<AsignaturaContext>("Data Source=LAPTOP-PH1R9POH;Initial Catalog=CampusVirtualApi;Integrated Security=True;");

builder.Services.AddScoped<IServicesCampusVirtual, ServicesCampus>();
builder.Services.AddScoped<IAsignaturaService, AsignaturaService>();
builder.Services.AddScoped<IMatriculasService, MatriculasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.MapControllers();

app.Run();
