using EntityFrameworkCoreSample.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreSample.Program
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IHost _host;
        private readonly AdventureWorks2019Context _dbContext;

        public Worker(ILogger<Worker> logger, IHost host, AdventureWorks2019Context dbContext)
        {
            _logger = logger;
            _host = host;
            _dbContext = dbContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Test the database for data
            var people = _dbContext.People.Take(10).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            _host.StopAsync();
        }
    }
}
