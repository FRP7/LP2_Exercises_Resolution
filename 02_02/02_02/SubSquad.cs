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
        }

        protected override Vector2 Move(float vx, float vy) {
            return new Vector2(vx - Position.X, vy - Position.Y);
        }
    }
}
