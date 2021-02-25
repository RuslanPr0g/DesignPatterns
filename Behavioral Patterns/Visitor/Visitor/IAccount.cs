namespace Visitor
{
    interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
