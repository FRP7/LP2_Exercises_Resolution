using System;
using System.Collections.Generic;
using System.Text;

namespace _02_12
{
    class Pistol : Weapon, IWeapon
    {
        // This property is true if weapon is in alternate firing mode, false
        // otherwise
        public bool IsAlternate { get; }

        // Reload the weapon
        public void Reload() {

        }

        // Shoot the weapon, return true if any rounds left to shoot in current
        // firing mode, false otherwise
        public bool Shoot() {
            return true;
        }

        // Switch between main and alternate firing modes
        public void SwitchFireMode() {

        }
    }
}
