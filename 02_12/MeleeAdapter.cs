using System;

namespace _02_12
{
    class MeleeAdapter : IWeapon
    {
        private IMelee melee;
        // This property is true if weapon is in alternate firing mode, false
        // otherwise
        public bool IsAlternate { get; }

        private MeleeAttacks meleeAttacks;

        private int stamina;

        // Reload the weapon
        public void Reload() {
            stamina = 10;
        }

        // Shoot the weapon, return true if any rounds left to shoot in current
        // firing mode, false otherwise
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

        // Switch between main and alternate firing modes
        public void SwitchFireMode() {
            if(IsAlternate == true) {
                meleeAttacks = MeleeAttacks.HorizontalAttack;
            }
            else {
                meleeAttacks = MeleeAttacks.VerticalAttack;
            }
        }

        public MeleeAdapter(IMelee melee, bool isAlternate) {
            stamina = 10;
            IsAlternate = isAlternate;
            this.melee = melee;
        }
    }
}
