using FileRepositories;
using LearnWebAPI.Middlewares;
using EfcRepositories;
using RepositoryContracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient <GlobalExceptionHandlerMiddleware>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPostRepository, EfcPostRepository>();
builder.Services.AddScoped<IUserRepository, EfcUserRepository>();
builder.Services.AddScoped<ICommentRepository, EfcCommentRepository>();

builder.Services.AddDbContext<EfcRepositories.AppContext>();

var app = builder.Build();

app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.Run();