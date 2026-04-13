var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from azure-demo!");
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

app.Run();

// Needed so the test project can reference this assembly
public partial class Program { }
