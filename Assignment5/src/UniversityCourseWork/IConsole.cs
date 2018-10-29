using System;

namespace Assignment5
{
    public interface IConsole
    {
        void WriteLine(string str);
        void Write(string str);
        string ReadLine();
    }
}
