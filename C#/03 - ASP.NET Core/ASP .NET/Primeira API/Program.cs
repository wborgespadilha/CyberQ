// Adicionar contexto e o EntityFrameworkCore
using Primeira_API.Config;
using Microsoft.EntityFrameworkCore;

// String de conexão
var stringConexao = "DATA SOURCE = (DESCRIPTION ="
    + "(ADDRESS = (PROTOCOL = TCP)(HOST=192.168.15.18)(PORT=1521))"
    + "(CONNECT_DATA =(SERVER = DEDICATED)"
    + "(SERVICE_NAME = TREINAMENTO))));"
    + "User Id=aluno18;Password=aluno18;";


// Objeto contendo a classe que inicializa a nossa aplicação
var builder = WebApplication.CreateBuilder(args);

// Gera suporte para utilizar APIs
builder.Services.AddEndpointsApiExplorer();

// Adicionar o acesso ao banco de dados
builder.Services.AddDbContext<Contexto>(options => options.UseOracle(stringConexao));

// Adicionar o serviço que libera o uso dos controles
builder.Services.AddControllers();

// Adicionar o serviço do Swagger na API
builder.Services.AddSwaggerGen();

// Variável para receber a configuração do Cors
var ConfigurarCors = "";

// Configurar acesso a API
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: ConfigurarCors, policy =>
    {
        policy.WithOrigins("http://localhost:8080")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });

});

// Criando objeto app para termos acesso as funcionalidades de APIs
var app = builder.Build();

// Rota contendo Hello World
app.MapGet("/", () => "Hello World!");

// Rota para testar a conexão com o banco de dados
app.MapGet("/conexao", (Contexto obj) =>
{
    return obj.Treinamento.ToList();
});

// Adicionar configuração do Cors na API
app.UseCors(ConfigurarCors);

// Mapeia a aplicação para procurar todos os controles
app.MapControllers();

// Implementa o Swagger na aplicação e gera a estrutura HTML/CSS exibida
app.UseSwagger();
app.UseSwaggerUI();

// Executar aplicação
app.Run();
