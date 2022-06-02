﻿using projeto_devops07.Extensao;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
namespace projeto_devops07;
public class Program
{
    public static void Main(string[] args)
    {
        //criamos o método de extensão CreateAdminRole
        CreateHostBuilder(args)
           .Build()
           .CreateAdminRole()
           .Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
