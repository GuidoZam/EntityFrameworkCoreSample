using EntityFrameworkCoreSample.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AdventureWorks2019Context>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("CustomConnectionString"));
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}