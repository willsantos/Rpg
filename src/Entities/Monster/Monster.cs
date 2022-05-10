using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities.Monster
{
  public abstract class Monster
  {
    public Monster(string name, int Level, string weapon = "suas garras")
    {
      this.Name = name;
      this.Level = Level;
      this.Weapon = weapon;

    }

    public string Name { get; set; }
    public int Level { get; set; }
    public string Weapon { get; set; }

    public virtual string Attack()
    {
      return $"{this.Name} atacou com {this.Weapon}";
    }

  }
}