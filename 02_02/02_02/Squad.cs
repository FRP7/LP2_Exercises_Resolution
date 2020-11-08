using System;
using System.Collections;
using System.Collections.Generic;


namespace _02_02
{
    /// <summary>
    /// Classe da Squad.
    /// </summary>
    public class Squad
    {  
        // Stack das units da squad.
        public Stack<object> squadstack = new Stack<object>();
        //

        // Variável string de leitura de exposição do número de units na squad.
        protected virtual string Name {
            get => $"Group of {squadstack.Count} units";
        }
        //

        // Variável Vector2 da posição da squad.
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
            set {; }
        }
        //

        // Variável float de leitura da vida da squad.
        protected virtual float Health { 
            get {
                float sum = 0;
                foreach (Unit item in squadstack) {
                    sum += item.Health;
                }
                return sum / squadstack.Count;
            }
        }
        //
       
        /// <summary>
        /// Método de adicionar movimento à squad.
        /// </summary>
        /// <param name="newposition"> Novo movimento. </param>
        public virtual void Move(Vector2 newposition) {
            Vector2 finalmovement = new Vector2(newposition.X - Position.X,
                newposition.Y - Position.Y);

            foreach (Unit item in squadstack) {
                item.Move(new Vector2(Position.X + finalmovement.X, 
                    Position.Y + finalmovement.Y));
            }
        }
        //
    }
    //
}
