using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities
{
  public class Wizard : Hero
  {


    public Wizard(string Name, string CharacterClass = "Mago", int Level = 0, string Weapon = "suas mãos") : base(Name, Level, CharacterClass, Weapon)
    {
      this.Name = Name;
      this.Level = Level;
      this.CharacterClass = CharacterClass;
      this.Weapon = Weapon;
    }


  }
}