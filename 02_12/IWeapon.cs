using System;

namespace _02_12
{
    interface IWeapon
    {
        // This property is true if weapon is in alternate firing mode, false
        // otherwise
        bool IsAlternate { get; }

        // Reload the weapon
        void Reload();

        // Shoot the weapon, return true if any rounds left to shoot in current
        // firing mode, false otherwise
        bool Shoot();

        // Switch between main and alternate firing modes
        void SwitchFireMode();
    }
}
