namespace BlockWriter
{
    internal interface IBlockWriter
    {
        void Write(string input);
        void Write(string input, int delay);
    }
}