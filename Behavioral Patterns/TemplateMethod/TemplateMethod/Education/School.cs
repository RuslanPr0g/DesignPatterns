using System;

namespace TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Go to the first class");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lessons, do home works");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Certificate of Secondary Education");
        }
    }
}
