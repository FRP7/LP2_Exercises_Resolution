using System;
using System.Collections;
using System.Collections.Generic;


namespace _02_02
{
    public class Squad
    {  
        public Stack<object> squadstack = new Stack<object>();
        protected virtual string Name {
            get => $"Group of {squadstack.Count} units";
        }
        protected virtual Vector2 Position {
            get {
                float sumX = 0;
                float sumY = 0;
                float avgX;
                float avgY;
                foreach (Unit item in squadstack) {
                    sumX += item.Position.X;
                }
                foreach (Unit item in squadstack) {
                    sumY += item.Position.Y;
                }
                avgX = sumX / squadstack.Count;
                avgY = sumY / squadstack.Count;

                return new Vector2(avgX, avgY);
            }
        }
        protected virtual float Health { 
            get {
                float sum = 0;
                foreach (Unit item in squadstack) {
                    sum += item.Health;
                }
                return sum / squadstack.Count;
            }
        }

        public void TesteSquad() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Average position X: {Position.X}");
            Console.WriteLine($"Average position Y: {Position.Y}");
            Console.WriteLine($"Average health: {Health}");
        }
       

        protected virtual void Move() {

        }
    }
}
