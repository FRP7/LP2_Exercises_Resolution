using System;
using System.Collections;
using System.Collections.Generic;


namespace _02_02
{
    /// <summary>
    /// Classe da Squad.
    /// </summary>
    public class Squad : IUnit
    {
        // Coleção dos soldados que fazem parte do batalhão.
        private ICollection<IUnit> squadUnits;

        // Descrição do batalhão.
        public string UnitName { get => $"Group of {squadUnits.Count} units."; }

        // Posição do batalhão.
        public Vector2 Position {
            get {
                float x = 0;
                float y = 0;
                foreach (IUnit item in squadUnits) {
                    x += item.Position.X;
                    y += item.Position.Y;
                }
                return new Vector2(x / squadUnits.Count, y / squadUnits.Count);
            }
        }

        // Vida do batalhão.
        public float Health {
            get {
                float health = 0;
                foreach (IUnit item in squadUnits) {
                    health += item.Health;
                }
                return health / squadUnits.Count;
            }
        }

        // Movimento do batalhão.
        public void Move(Vector2 newPosition) {
            newPosition = new Vector2(newPosition.X - Position.X,
                newPosition.Y - Position.Y);
        }

        // Construtor do batalhão.
        public Squad(ICollection<IUnit> units) {
            //squadUnits = new List<IUnit>();
            squadUnits = units;
        }
    }
}
