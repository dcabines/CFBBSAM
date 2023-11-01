var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api", () => "Hello API!");

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();
