var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("AboutUs", () => "Welcome to Transflower learning");
Thread theThread=Thread.CurrentThread;
Console.WriteLine("Primary thread"+theThread.ManagedThreadId);


app.Run();
