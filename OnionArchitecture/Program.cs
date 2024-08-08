using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.CustomService;
using ServiceLayer.ICustomServices;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//Sql Dependency Injection

// Add services to the container.
string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection_Office");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("OnionArchitecture")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Service Injected
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICustomService<Student>, StudentService>();
builder.Services.AddScoped<ICustomService<Resultss>, ResultssService>();

builder.Services.AddScoped<ICustomService<Departments>, DepartmentService>();
builder.Services.AddScoped<ICustomService<SubjectGpas>, SubjectGpaService>();
#endregion
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