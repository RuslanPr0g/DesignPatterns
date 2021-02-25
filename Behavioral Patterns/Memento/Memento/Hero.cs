using System;

namespace Memento
{
    class Hero
    {
        private int patrons = 10;
        private int lives = 5;

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Shoot!. Remained {0} patrons", patrons);
            }
            else
                Console.WriteLine("No patrons,,,,");
        }
        public HeroMemento SaveState()
        {
            Console.WriteLine("Save game. Parameters: {0} patrons, {1} lives", patrons, lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Load game. Parameters: {0} patrons, {1} lives", patrons, lives);
        }
    }
}
