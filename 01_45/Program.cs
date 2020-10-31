using System;
using System.Collections;
using System.Collections.Generic;

namespace NPCS
{
    class Program
    {
        // Lista de subclasses de NPC.
        private static List<NPC> classlist = new List<NPC>();

        static void Main(string[] args) {
            // Adicionar as subclasses e as respetivas vidas no construtor.
            classlist.Add(new Warrior(hp: 10f));
            classlist.Add(new Mage(hp: 3f));
            classlist.Add(new Rogue(hp: 5f));

            // Chamar o método PlayTurn de todas as subclasses.
            foreach(NPC item in classlist) {
                item.PlayTurn();
            }
        }
    }
}
