using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities.Monster
{
  public abstract class Monster
  {
    public Monster(string name, int level, int life, string weapon = "seu corpo")
    {
      this.Name = name;
      this.Level = level;
      this.Life = life;
      this.Weapon = weapon;

    }

    public string Name { get; set; }
    public int Level { get; set; }
    public int Life { get; set; }
    public string Weapon { get; set; }


    public virtual string Attack()
    {
      return $"{this.Name} atacou com {this.Weapon}";
    }

  }
}