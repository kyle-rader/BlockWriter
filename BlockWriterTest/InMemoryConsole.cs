using McMaster.Extensions.CommandLineUtils;
using System;
using System.IO;
using System.Text;

namespace BlockWriterTest
{
    internal class InMemoryConsole : IConsole
    {
        public StringBuilder OutStream = new StringBuilder();
        public string Output() => OutStream.ToString();

        public StringBuilder ErrorStream = new StringBuilder();
        public string ErrorOutput() => ErrorStream.ToString();

        internal TextWriter outStreamWriter;
        internal TextWriter errorStreamWriter;
        internal StringReader inReader;

        public InMemoryConsole()
        {
            outStreamWriter = new StringWriter(OutStream);
            errorStreamWriter = new StringWriter(ErrorStream);
            inReader = new StringReader(string.Empty);
        }

        public InMemoryConsole(string stdIn)
        {
            outStreamWriter = new StringWriter(OutStream);
            errorStreamWriter = new StringWriter(ErrorStream);
            inReader = new StringReader(stdIn);
        }

        public TextWriter Out => outStreamWriter;

        public TextWriter Error => errorStreamWriter;

        public TextReader In => inReader;

        public bool IsInputRedirected => false;
        public bool IsOutputRedirected => false;
        public bool IsErrorRedirected => false;

        public ConsoleColor ForegroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ConsoleColor BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event ConsoleCancelEventHandler CancelKeyPress;

        public void ResetColor()
        {
            throw new NotImplementedException();
        }
    }
}
