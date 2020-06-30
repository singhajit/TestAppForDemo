using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestDemoWebApiCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //Commented line need to configure the IIS that need to check importent.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(webBuilder =>
        //    {
        //        webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
        //        webBuilder.UseStartup<Startup>();
        //        webBuilder.UseIIS();
        //        webBuilder.UseIISIntegration();
        //        webBuilder.UseKestrel();
        //        webBuilder.ConfigureKestrel((context, options) =>
        //         {
        //             // Set properties and call methods on options
        //         });
        //    });
    }
}
