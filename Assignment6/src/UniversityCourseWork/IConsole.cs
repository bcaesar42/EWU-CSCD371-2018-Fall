using System;

namespace Assignment6
{
    public interface IConsole
    {
        void WriteLine(string str);
        void Write(string str);
        string ReadLine();
    }
}
