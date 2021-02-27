using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new UserBuilder().SetName("Tom").SetCompany("Microsoft").SetAge(23).Build();
            User alice = User.CreateBuilder().SetName("Alice").IsMarried.SetAge(25).Build();

            Console.WriteLine(value: tom.Name);
            Console.WriteLine(value: tom.Age);
            Console.WriteLine(value: tom.Company);
            Console.WriteLine(value: tom.IsMarried);

            Console.WriteLine("-___________________-");

            Console.WriteLine(alice.Name);
            Console.WriteLine(alice.Age);
            Console.WriteLine(alice.Company);
            Console.WriteLine(alice.IsMarried);
        }
    }
}
