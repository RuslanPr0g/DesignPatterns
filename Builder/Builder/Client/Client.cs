using System;
using System.Text;

namespace Builder
{
    class Client
    {
        void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
    }
}
