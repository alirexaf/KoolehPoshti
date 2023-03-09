using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<KoolehPoshtiContext>(options =>
       options.UseSqlServer(builder.Configuration
    .GetConnectionString("KPConnectionString")));

builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped<ITravelerRepository, TravelerRepository>();
builder.Services.AddScoped<IPackageRepository, PackageRepository>();
builder.Services.AddScoped<IPackageCategoryRepository, PackageCategoryRepository>();
builder.Services.AddScoped<IPackageImageRepository, PackageImageRepository>();
builder.Services.AddScoped<IRequesterRepository, RequesterRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
