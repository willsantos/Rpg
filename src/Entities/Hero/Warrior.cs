using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities
{
  public class Warrior : Hero
  {


    public Warrior(string name, string characterClass = "Guerreiro", int level = 0, int life = 15, string weapon = "Espada") : base(name, level, characterClass, life, weapon)
    {
      this.Name = name;
      this.Level = level;
      this.CharacterClass = characterClass;
      this.Weapon = weapon;
      this.Life = life;

    }


  }
}