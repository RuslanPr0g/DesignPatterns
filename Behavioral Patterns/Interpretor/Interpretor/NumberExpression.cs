namespace Interpretor
{
    class NumberExpression : IExpression
    {
        string name; 
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
