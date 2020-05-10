using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace BlockWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLineApplication app = new CommandLineApplication<WriterCommand>();

            var additionalServices = new ServiceCollection()
                .AddSingleton<IConsole>(PhysicalConsole.Singleton)
                .AddSingleton<IBlockWriter, Writer>()
                .BuildServiceProvider();

            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(additionalServices);

            app.Execute(args);

        }
    }
}
