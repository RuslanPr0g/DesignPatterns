namespace Strategy
{
    partial class Program
    {
        public class Context
        {
            public IStrategy ContextStrategy { get; set; }

            public Context(IStrategy _strategy)
            {
                ContextStrategy = _strategy;
            }

            public void ExecuteAlgorithm()
            {
                ContextStrategy.Algorithm();
            }
        }
    }
}
