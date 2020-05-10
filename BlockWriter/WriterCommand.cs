using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Abstractions;

namespace BlockWriter
{
    [Command(
        Name = "bw",
        Description = "Block Writer. Print Figlet block text")]
    class WriterCommand
    {
        private IBlockWriter writer;
        private IFileSystem fs;

        [Argument(0, Name = "InputText")]
        public string[] Input { get; }

        [Option("-f|--file", CommandOptionType.SingleValue)]
        [FileExists]
        public string InputFile { get; }

        [Option(
            "-d|--delay",
            "Number of milliseconds to delay between printing individual lines of characters.",
            optionType: CommandOptionType.SingleValue)]
        [Range(0, 500)]
        public int Delay { get; } = 0;

        public WriterCommand(IBlockWriter writer, IFileSystem fs)
        {
            this.writer = writer;
            this.fs = fs;
        }

        public void OnExecute()
        {
            foreach (string line in LinesToPrint())
            {
                writer.Write(line, Delay);
            }
        }

        private IEnumerable<string> LinesToPrint()
        {
            if (InputFile != null)
            {
                return fs.File.ReadAllLines(InputFile);
            }
            return new[] { string.Join(" ", Input) };
        }
    }
}
