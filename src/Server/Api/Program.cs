using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>options.UseNpgsql()); 
var app = builder.Build();

app.MapControllers();

app.Run();
