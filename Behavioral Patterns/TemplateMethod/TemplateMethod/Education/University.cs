using System;

namespace TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Pass enter exams and go to university");
        }

        public override void Study()
        {
            Console.WriteLine("Attend lessons");
            Console.WriteLine("Do practice");
        }

        public override void PassExams()
        {
            Console.WriteLine("Pass exam about specialization");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get high education diploma");
        }
    }
}
