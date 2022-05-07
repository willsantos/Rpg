using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities
{
  public abstract class Hero
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public string CharacterClass { get; set; }
    public string Weapon { get; set; }

    public Hero(string Name, int Level, string CharacterClass, string Weapon = "suas mãos")
    {
      this.Name = Name;
      this.Level = Level;
      this.CharacterClass = CharacterClass;
      this.Weapon = Weapon;
    }

    public virtual string Attack()
    {
      return $"{this.Name} atacou com {this.Weapon}!";
    }
  }
}