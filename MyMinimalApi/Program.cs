var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Prueba de 2da version");

app.Run();

public partial class Program { }