using System;

namespace NPCS
{
    public class Rogue : NPC
    {
        // Variável de vida. O new oculta a herança original.
        public new float HP { get; set; }
        // Variável que gera números aleatórios.
        private Random _random = new Random();

        // Construtor que define a vida
        public Rogue(float hp) : base(hp) {
            HP = hp;
        }

        /* Método que decide de forma aleatória se o Rogue
         * encontra ou não comida.
         * Funciona por cima da herança original através do override.*/
        protected override bool FindFood() {
            int randominput = _random.Next(1, 2);
            if (randominput == 1) {
                return true;
            } else {
                return false;
            }
        }

        /* Método que decide de forma aleatória se o Rogue
         * encontra ou não inimigos.
         * Funciona por cima da herança original através do override.*/
        protected override bool FindEnemies() {
            int randominput = _random.Next(1, 2);
            if(randominput == 1) {
                return true;
            } else {
                return false;
            }
        }

        /* Método que escreve no ecrã que o Rogue está a comer.
         * Funciona por cima da herança original através do override. */
        protected override void EatFood() {
            Console.WriteLine("Rogue eats food");
        }

        /* Método que escreve no ecrã que o Rogue está a atacar os inimigos.
         * Funciona por cima da herança original através do override. */
        protected override void AttackEnemies() {
            Console.WriteLine("Rogue attacks enemies");
        }
    }
}
