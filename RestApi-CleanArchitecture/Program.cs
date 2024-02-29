using FluentValidation;
using Microsoft.EntityFrameworkCore;
using RestApi_CleanArchitecture.App.IServices;
using RestApi_CleanArchitecture.App.Mapping.ProfilerUser;
using RestApi_CleanArchitecture.App.Repositories;
using RestApi_CleanArchitecture.App.UseCases.CreateUser;
using RestApi_CleanArchitecture.App.UseCases.DeleteUser;
using RestApi_CleanArchitecture.App.UseCases.GetById;
using RestApi_CleanArchitecture.App.UseCases.GetUser;
using RestApi_CleanArchitecture.App.UseCases.UpdateUser;
using RestApi_CleanArchitecture.App.Validators;
using RestApi_CleanArchitecture.Domain;
using RestApi_CleanArchitecture.Infra.ContextoBd;
using RestApi_CleanArchitecture.Infra.RepositoryImplementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//DBContext settings
var ConnectionString = builder.Configuration.GetConnectionString("UserDatabase");
builder.Services.AddDbContext<BdContext>(o => o.UseSqlServer(ConnectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Inversion Repository
builder.Services.AddScoped<IRepositorySaveRegister, RepositorySaveRegister>();
builder.Services.AddScoped<IRepositoryUpdateRegister, RepositoryUpdateRegister>();
builder.Services.AddScoped<IRepositoryDeletedRegister, RepositoryDeletedRegister>();
builder.Services.AddScoped<IRepositoryFindAllRegister, RepositoryFindAllRegister>();
builder.Services.AddScoped<IRepositoryFindByIdRegister, RepositoryFindByIdRegister>();

//Dependency Inversion Service
builder.Services.AddScoped<ICreateService, CreateRegister>();
builder.Services.AddScoped<IUpdateService, UpdateRegister>();
builder.Services.AddScoped<IDeleteService, DeleteRegister>();
builder.Services.AddScoped<IGetByIdService, GetByIdRegister>();
builder.Services.AddScoped<IGetService, GetAllRegister>();

//Dependency FluentValidator
builder.Services.AddTransient<IValidator<User>, ValidatorUser>();

//Dependency Automapper
builder.Services.AddAutoMapper(typeof(UserProfile));

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
