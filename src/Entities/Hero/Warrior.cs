using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities
{
  public class Warrior : Hero
  {


    public Warrior(string Name, string CharacterClass = "Guerreiro", int Level = 0, string Weapon = "Espada") : base(Name, Level, CharacterClass, Weapon)
    {
      this.Name = Name;
      this.Level = Level;
      this.CharacterClass = CharacterClass;
      this.Weapon = Weapon;
    }


  }
}