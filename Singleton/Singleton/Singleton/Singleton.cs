using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public string Date { get; private set; }

        private Singleton()
        {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
