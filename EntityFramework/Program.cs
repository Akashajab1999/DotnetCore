using Microsoft.EntityFrameworkCore;
using Transflower.EntityFramework.Repository;
using Transflower.EntityFramework.Services;
using Transflower.Repositories.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<PersonContext>(options=>
        options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new ArgumentNullException(nameof(options))
        )
            .LogTo(Console.WriteLine, LogLevel.Information)
        
        );
builder.Services.AddTransient<IPersonRepository,PersonRepository>();
builder.Services.AddTransient<IPersonService,PersonService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader());


app.UseAuthorization();

app.MapControllers();

app.Run();
