using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YungChingInterviewQuiz.DataAccess;
using YungChingInterviewQuiz.Repositories;
using YungChingInterviewQuiz.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<NorthwindDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("NorthwindDb")));

// ª`¤J CustomerRepository
builder.Services.AddScoped<CustomerRepository>();

// ª`¤J CustomerService
builder.Services.AddScoped<CustomerService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.MapControllers();

app.Run();