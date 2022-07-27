using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductCatalogAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //first build then seed, and then run
            var host = CreateHostBuilder(args).Build();

            //check on host's services weather the scope of service is running, 
            
            //ask host to give all the services =>give access to services ->scope
            //the memory for scope is huge so using is garantee to destroy when out of using block
            using (var scope = host.Services.CreateScope())
            {
                // ask for all service provider 
                var serviceProviders = scope.ServiceProvider;
                //if the required servic is runningc
                //if it is not running -> startup.cs configureservice is not finished. 
                //it will wait until run and give access to context
                var context = serviceProviders.GetRequiredService<CatalogContext>();
                CatalogSeed.Seed(context);

            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
