namespace Bridge
{
    abstract class Programmer
    {
        protected ILanguage language;
        public ILanguage Language
        {
            set
            {
                language = value;
            }
        }
        public Programmer(ILanguage lang)
        {
            language = lang;
        }
        public virtual void DoWork()
        {
            language.Build();
            language.Execute();
        }
        public abstract void EarnMoney();
    }
}
