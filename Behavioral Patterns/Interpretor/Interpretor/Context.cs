using System.Collections.Generic;

namespace Interpretor
{
    class Context
    {
        Dictionary<string, int> variables;
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        public int GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
}
