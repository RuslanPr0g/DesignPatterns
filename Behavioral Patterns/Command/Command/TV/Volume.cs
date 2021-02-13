using System;

namespace Command
{
    class Volume
    {
        public const int OFF = 0;
        public const int HIGH = 20;
        private int level;

        public Volume()
        {
            level = OFF;
        }

        public void RaiseLevel()
        {
            if (level < HIGH)
                level++;
            Console.WriteLine("Volume level {0}", level);
        }
        public void DropLevel()
        {
            if (level > OFF)
                level--;
            Console.WriteLine("Volume level {0}", level);
        }
    }
}
