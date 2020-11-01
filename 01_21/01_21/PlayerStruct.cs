using System;
using System.Collections.Generic;
using System.Text;

namespace _01_21
{
    public struct PlayerStruct
    {
        private int health;
        private int shield;
        private List<Power> powers;

        public PlayerStruct(int health, int shield) {
            this.health = health;
            this.shield = shield;
            powers = new List<Power>();
        }

        public void AddPower(Power p) {
            powers.Add(p);
        }
    }
}
