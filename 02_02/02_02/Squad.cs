using System;
using System.Collections;
using System.Collections.Generic;


namespace _02_02 
{
    /// <summary>
    /// Classe da Squad.
    /// </summary>
    public class Squad : IUnit
    {

        private ICollection<IUnit> squadUnits;

        public string UnitName { get => $"Group of {squadUnits.Count} units."; }
        //public Vector2 Position { get; }
        public Vector2 Position {
            get {
                float x = 0;
                float y = 0;
                foreach(IUnit item in squadUnits) {
                    x += item.Position.X;
                    y += item.Position.Y;
                }
                return new Vector2(x / squadUnits.Count, y / squadUnits.Count);
            }
        }
        public float Health {
            get {
                float health = 0;
                foreach(IUnit item in squadUnits) {
                    health += item.Health; 
                }
                return health / squadUnits.Count;
            }
        }

        public void Move(Vector2 newPosition) {
            newPosition = new Vector2(newPosition.X - Position.X, 
                newPosition.Y - Position.Y);
        }

        public Squad(ICollection<IUnit> units) {
            //squadUnits = new List<IUnit>();
            squadUnits = units;
        }

        public void Teste() {
            Console.WriteLine(UnitName);
            Console.WriteLine($"X: {Position.X}. Y: {Position.Y}");
            Console.WriteLine("Health: " + Health);
        }
    }
}
