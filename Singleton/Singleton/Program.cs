using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }
}
