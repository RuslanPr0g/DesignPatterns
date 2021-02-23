using System;

namespace Interpretor
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            int x = 5;
            int y = 8;
            int z = 2;

            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")
                ),
                new NumberExpression("z")
            );

            int result = expression.Interpret(context);
            Console.WriteLine("Result: {0}", result);

            Console.Read();
        }
    }
}
