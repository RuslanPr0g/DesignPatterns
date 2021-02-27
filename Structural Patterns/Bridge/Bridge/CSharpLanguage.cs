using System;

namespace Bridge
{
    class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Roslyn");
        }

        public void Execute()
        {
            Console.WriteLine("JIT compile");
            Console.WriteLine("CLR run code");
        }
    }
}
