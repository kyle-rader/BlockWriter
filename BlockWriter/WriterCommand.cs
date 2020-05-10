using McMaster.Extensions.CommandLineUtils;
using System.ComponentModel.DataAnnotations;

namespace BlockWriter
{
    [Command(
        Name = "bw", 
        Description = "Block Writer. Print Figlet block text")]
    class WriterCommand
    {
        private IBlockWriter writer;

        [Argument(0, Name = "InputText")]
        public string[] Input { get; }

        [Option("-f|--file", CommandOptionType.SingleValue)]
        public string InputFile { get; }

        [Option(
            "-d|--delay", 
            "Number of milliseconds to delay between printing individual lines of characters.",
            optionType: CommandOptionType.SingleValue)]
        [Range(0, 250)]
        public int Delay { get; }

        public WriterCommand(IBlockWriter writer)
        {
            this.writer = writer;
        }

        public void OnExecute()
        {
            writer.Write(string.Join(" ", Input));
        }
    }
}
