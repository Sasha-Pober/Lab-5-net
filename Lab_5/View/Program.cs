using System;
using Controller;
using Microsoft.Extensions.DependencyInjection;

namespace View
{
    class Program
    {
        private static IServiceProvider ConfigServices()
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IProgramRunner, ProgramRunner>();

            return collection.BuildServiceProvider();
        }
        static void Main(string[] args)
        {
            ConfigServices().GetService<IProgramRunner>().Run();
        }
    }
}
