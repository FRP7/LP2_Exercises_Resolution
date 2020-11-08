using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_02
{
    public class SubSquad : Squad
    {
        public Stack<object> subsquadstack = new Stack<object>();
        protected override string Name {
            get => $"Group of {subsquadstack.Count} units";
        }
        protected override Vector2 Position {
            get {
                float sumX = 0;
                float sumY = 0;

                foreach (Unit item in subsquadstack) {
                    sumX += item.Position.X;
                }
                foreach (Unit item in subsquadstack) {
                    sumY += item.Position.Y;
                }

                return new Vector2(sumX, sumY);
            }
        }

        protected override float Health {
            get {
                float sum = 0;
                foreach (Unit item in subsquadstack) {
                    sum += item.Health;
                }
                return sum;
            }
        }

        public void TesteSubsquad() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position X: {Position.X}");
            Console.WriteLine($"Position Y: {Position.Y}");
            Console.WriteLine($"Health: {Health}");
            Move(new Vector2(2, 2));
            Console.WriteLine($"New X: {Position.X}");
            Console.WriteLine($"New Y Y: {Position.Y}");
        }

        protected override void Move(Vector2 newposition) {
            Vector2 finalmovement = new Vector2(newposition.X - Position.X,
                newposition.Y - Position.Y);

            foreach (Unit item in subsquadstack) {
                item.Move(new Vector2(Position.X + finalmovement.X,
                    Position.Y + finalmovement.Y));
            }
        }
    }
}
