using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_02
{
    /// <summary>
    /// Subclasse de Squad.
    /// </summary>
    public class SubSquad : Squad
    {
        // Stack das units da subsquad.
        public Stack<object> subsquadstack = new Stack<object>();
        //

       /* Variável string de leitura de exposição do número de units na
        * subsquad.*/
        protected override string Name {
            get => $"Group of {subsquadstack.Count} units";
        }
        //

        // Variável Vector2 da posição da subsquad.
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
        //

        // Variável float de leitura da vida da subsquad.
        protected override float Health {
            get {
                float sum = 0;
                foreach (Unit item in subsquadstack) {
                    sum += item.Health;
                }
                return sum;
            }
        }
        //

        /// <summary>
        /// Método de adicionar movimento à subsquad.
        /// </summary>
        /// <param name="newposition"> Novo movimento. </param>
        public override void Move(Vector2 newposition) {
            Vector2 finalmovement = new Vector2(newposition.X - Position.X,
                newposition.Y - Position.Y);

            foreach (Unit item in subsquadstack) {
                item.Move(new Vector2(Position.X + finalmovement.X,
                    Position.Y + finalmovement.Y));
            }
        }
        //
    }
    //
}
