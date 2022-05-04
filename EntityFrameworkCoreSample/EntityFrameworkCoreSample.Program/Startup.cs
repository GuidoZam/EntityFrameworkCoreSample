using EntityFrameworkCoreSample.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<AdventureWorks2019Context>();

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}