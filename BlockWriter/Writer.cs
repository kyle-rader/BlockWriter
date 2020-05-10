using McMaster.Extensions.CommandLineUtils;

namespace BlockWriter
{
    public class Writer : IBlockWriter
    {
        private IConsole console;

        public Writer(IConsole console)
        {
            this.console = console;
        }

        public void Write(string input)
        {
            var figletText = new WenceyWang.FIGlet.AsciiArt(input);
            foreach (var line in figletText.Result)
            {
                console.WriteLine(line);
            }
        }

        public void Write(string input, int delay)
        {
            var figletText = new WenceyWang.FIGlet.AsciiArt(input);
            foreach (var line in figletText.Result)
            {
                console.WriteLine(line);
                System.Threading.Thread.Sleep(delay);
            }
        }
    }
}