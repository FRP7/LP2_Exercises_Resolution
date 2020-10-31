using System;

namespace NPCS
{
    public abstract class NPC
    {
        // Variável da vida, está vazia porque está numa classe abstract.
        public float HP { get; protected set; }

        // Construtor de vida.
        public NPC(float hp) {
            HP = hp;
        }

        // Método de gameplay
        public void PlayTurn() {
            if (FindEnemies()) {
                AttackEnemies();
            }
            if (FindFood()) {
                EatFood();
            }
            Move();
        }

        /* Método para verificar se encontrou comida.
         * Está vazio porque é abstract. */
        protected abstract bool FindFood();
        /* Método para verificar se encontrou inimigos. 
         * Está vazio porque é abstract. */
        protected abstract bool FindEnemies();
        /* Método para comer. Está vazio porque é abstract.
         * Está vazio porque é abstract. */
        protected abstract void EatFood();
        /* Método para atacar os inimigos. Está vazio porque é abstract. */
        protected abstract void AttackEnemies();

        /* Método para mover.
        * Como é virtual, pode ser ocultado ou escrito por cima. */
        protected virtual void Move() {
            Console.WriteLine(this.GetType() + " has moved!");
        }
    }
}
