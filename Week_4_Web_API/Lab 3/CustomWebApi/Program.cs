using CustomWebApi.Filters;

var builder = WebApplication.CreateBuilder(args);

// 1. Add controllers and global exception filter
builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});

// 2. Swagger setup
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Register custom filters if needed elsewhere
builder.Services.AddScoped<CustomAuthFilter>();

var app = builder.Build();

// 4. Use Swagger only in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization(); // [AllowAnonymous] still works

app.MapControllers();

app.Run();
