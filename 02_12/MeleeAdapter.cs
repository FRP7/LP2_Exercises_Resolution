using System;
using System.Collections.Generic;
using System.Text;

namespace _02_12
{
    class MeleeAdapter : IWeapon
    {
        // Access the IMelee interface
        IMelee melee;

        // Enums of kinds of attack mode
        public enum FireMode
        {
            above,
            below,
            left,
            right
        }

        private FireMode fireMode;

        // This property is true if weapon is in alternate firing mode, false
        // otherwise
        public bool IsAlternate { get; }

        // Reload the weapon
        public void Reload() {

        }

        // Shoot the weapon, return true if any rounds left to shoot in current
        // firing mode, false otherwise
        public bool Shoot() {
            if(IsAlternate == false) {
                return false;
            }
            else {
                CurrentFireMode();
                return true;
            }
        }

        // Switch between main and alternate firing modes
        public void SwitchFireMode() {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 5);
            if(rndNumber == 1) {
                fireMode = FireMode.above;
            } else if(rndNumber == 2) {
                fireMode = FireMode.below;
            }
            else if(rndNumber == 3) {
                fireMode = FireMode.left;
            } else if(rndNumber == 4) {
                fireMode = FireMode.right;
            }
        }

        public void CurrentFireMode() {
            SwitchFireMode();
            if (fireMode == FireMode.above) {
                melee.AttackFromAbove();
            } else if (fireMode == FireMode.below) {
                melee.AttackFromBelow();
            } else if (fireMode == FireMode.left) {
                melee.AttackFromTheLeft();
            } else if (fireMode == FireMode.right) {
                melee.AttackFromTheRight(); 
            }
            }

        // Constructor of the adapter
        public MeleeAdapter(IMelee melee) {
            this.melee = melee;
            IsAlternate = true;
            Shoot();
        }
    }
}
