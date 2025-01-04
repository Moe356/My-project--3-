using System;

namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void PrintPosition()
        {
            Console.WriteLine("Position: X = " + X + ", Y = " + Y + ", Z = " + Z);
        }
    }

    public class Character
    {
        public string Name;
        private int _health;
        protected Position Position;

        public int Health
        {
            get => _health;
            set => _health = Math.Clamp(value, 0, 100);
        }

        public Character(string name, int health, Position position)
        {
            Name = name;
            Health = health;
            Position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Position.PrintPosition();
        }
    }
}
