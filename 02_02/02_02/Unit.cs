using System;
using System.Security.Cryptography.X509Certificates;

namespace _02_02
{
    public class Unit : IUnit
    {
        public string UnitName { get; private set; }
        public Vector2 Position { get; private set; }
        public float Health { get; private set; }

        public Unit(string name, Vector2 position, float health) {
            UnitName = name;
            Position = position;
            Health = health;
            // só para teste, delete later:
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position X: {position.X}");
            Console.WriteLine($"Position Y: {position.Y}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine(Environment.NewLine);
        }

        public void Move(Vector2 newPosition) {
            Position = newPosition;
        }

        public override string ToString() {
            return $"{UnitName} at ({Position.X:f1}, {Position.Y:f1}) " +
                $"with {Health:f1} HP";
        }
    }
}
