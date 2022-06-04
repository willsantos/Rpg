using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities
{
  public class Wizard : Hero
  {


    public Wizard(string name, string characterClass = "Mago", int level = 0, int life = 15, string weapon = "Cajado") : base(name, level, characterClass, life, weapon)
    {
      this.Name = name;
      this.Level = level;
      this.CharacterClass = characterClass;
      this.Life = life - 5;
      this.Weapon = weapon;
    }


  }
}