using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Console2ASP.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

    public interface IRunner
    {
        string DoAction(string name);
    }

    public class Runner : IRunner
    {
        public string DoAction(string name)
        {
            return $"Doing hard work! {name}";
        }
    }

    public class YowkoRunner : IRunner
    {
        public string DoAction(string name)
        {
            return $"YowkoRunner : Doing hard work! {name}";
        }
    }
}