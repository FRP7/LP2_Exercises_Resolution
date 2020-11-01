using System;
using System.Collections.Generic;
using System.Text;

namespace _01_20
{
    public class Enemy
    {
        public static int NumberOfEnemies { get; private set; }
        public int Health { get; set; }

        public Enemy(int health) {
            NumberOfEnemies++;
            Health = health;
        }

        public void Die() {
            NumberOfEnemies--;
            Health = 0;
        }
    }
}
