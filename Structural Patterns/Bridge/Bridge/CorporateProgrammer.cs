using System;

namespace Bridge
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
            : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Earn money as a enterprise maaanQ");
        }
    }
}
