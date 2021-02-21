namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            if (condition == 2)
            {
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}
