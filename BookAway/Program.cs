using BookAway;
using BookAway.Application.Mapping;
using BookAway.Middleware;

var builder = WebApplication.CreateBuilder(args);
var _corsPolicyName = "DefaultPolicy";

// Add services to the container.
builder.Services.AddDependencyInjection(builder.Configuration);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});


//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(_corsPolicyName,
        builder =>
        {
            builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(AutoMapping));
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

app.UseAuthorization();
app.UseAuthentication();

app.UseMiddleware<ErrorHandleMiddleware>();

app.MapControllers();

app.Run();
