using BR_Cash.Data;
using BR_Cash.Interfaces.interfaceRepository;
using BR_Cash.Interfaces.interfaceService;
using BR_Cash.Repositorio;
using BR_Cash.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBD.Inicializador();

builder.Services.AddScoped<ICorrenteRepo, correnteRepo>();
builder.Services.AddScoped<IcorrenteService, correnteService>();

builder.Services.AddScoped<IPoupancaRepo, poupancaRepo>();
builder.Services.AddScoped<IpoupancaService, PoupancaService>();

builder.Services.AddScoped<IContaRepo, contaRepo>();
builder.Services.AddScoped<IcontaService, contaService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
