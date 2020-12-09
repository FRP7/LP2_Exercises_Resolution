using System;

namespace _02_12
{
    /// <summary>
    /// Adaptador de Melee
    /// </summary>
    class MeleeAdapter : IWeapon
    {
        // Interface IMelee.
        private IMelee melee;

        // Enum dos tipos de ataque.
        private MeleeAttacks meleeAttacks;

        // Indicar se o jogador faz ataques horizontais ou verticais.
        public bool IsAlternate { get; }

        // Stamina necessária para realizar os ataques.
        private int stamina;

        // Recarregar a stamina.
        public void Reload() {
            stamina = 10;
        }

        /// <summary>
        /// Atacar caso tenha stamina suficiente.
        /// </summary>
        /// <returns> Retorna falso se não tiver stamina suficiente. </returns>
        public bool Shoot() {
            if(stamina >= 10) {
                if (meleeAttacks == MeleeAttacks.HorizontalAttack) {
                    melee.AttackFromTheLeft();
                    melee.AttackFromTheRight();
                    stamina -= 10;
                } else if (meleeAttacks == MeleeAttacks.VerticalAttack) {
                    melee.AttackFromAbove();
                    melee.AttackFromBelow();
                    stamina -= 10;
                }
                return true;
            } else {
                Console.WriteLine("Not enough stamina.");
                return false;
            }
        }

        // Mudar o tipo de ataque.
        public void SwitchFireMode() {
            if(IsAlternate == true) {
                meleeAttacks = MeleeAttacks.HorizontalAttack;
            }
            else {
                meleeAttacks = MeleeAttacks.VerticalAttack;
            }
        }

        // Inicializar o adaptador.
        public MeleeAdapter(IMelee melee, bool isAlternate) {
            stamina = 10;
            IsAlternate = isAlternate;
            this.melee = melee;
        }
    }
}
