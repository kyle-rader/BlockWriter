using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace BlockWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLineApplication app = new CommandLineApplication();

            var additionalServices = new ServiceCollection()
                .AddSingleton<IConsole>(PhysicalConsole.Singleton)
                .AddSingleton<IBlockWriter, Writer>()
                .BuildServiceProvider();

            app.Conventions.UseConstructorInjection(additionalServices);
            
            app.AddName("bw");
            app.Description = "An app for printing block text!";
            app.HelpOption("-h|--help");

            var inputArg = app.Argument("Input", "Text to print", multipleValues: true);

            app.OnExecute(() =>
            {
                var writer = app.GetRequiredService<IBlockWriter>();
                writer.Write(string.Join(" ", inputArg.Values));
            });

            app.Execute(args);

        }
    }
}
