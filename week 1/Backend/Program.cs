// Program.cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:8080") // Adjust as necessary
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

// Uncomment the following line if you want to use HTTPS redirection
// app.UseHttpsRedirection();

// Use CORS
app.UseCors("AllowVueApp");

// Map controllers
app.MapControllers();

app.Run();
