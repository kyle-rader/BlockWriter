using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Abstractions;

namespace BlockWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLineApplication app = new CommandLineApplication<WriterCommand>();

            var additionalServices = new ServiceCollection()
                .AddSingleton<IConsole>(PhysicalConsole.Singleton)
                .AddSingleton<IFileSystem, FileSystem>()
                .AddSingleton<IBlockWriter, Writer>()
                .BuildServiceProvider();

            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(additionalServices);

            app.Execute(args);
        }
    }
}
