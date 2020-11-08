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
        protected virtual float Position {
            get {
                float sum = 0;
                foreach (Unit item in squadstack) {
                    sum += item.Position.X + item.Position.Y;
                }
                return sum / squadstack.Count;
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

        public void Teste() {
            Console.WriteLine($"Average position: {Position}");
            Console.WriteLine($"Average health: {Health}");
        }
       

        protected virtual void Move() {

        }
    }
}
