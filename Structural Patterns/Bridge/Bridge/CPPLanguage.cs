using System;

namespace Bridge
{
    class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("C++ build");
        }

        public void Execute()
        {
            Console.WriteLine("Execute application");
        }
    }
}
