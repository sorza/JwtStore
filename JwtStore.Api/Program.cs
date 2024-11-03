using JwtStore.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
builder.AddConfiguration();
builder.AddDatabase();
builder.AddJwtAuthentication();

app.MapGet("/", () => "Hello World!");

app.Run();
