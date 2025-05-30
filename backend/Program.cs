using Microsoft.EntityFrameworkCore;
using backend.Model;

SQLitePCL.Batteries_V2.Init();

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PhoneDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("sqlite")));
    
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();