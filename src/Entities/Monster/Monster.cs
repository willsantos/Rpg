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

    public virtual string Attack(int Damage)
    {

      if (Damage > 1 && Damage < 6)
      {
        return $"{this.Name} atacou com {this.Weapon} e causou {Damage} de dano.";
      }
      else if (Damage > 5)
      {
        int damage = Damage + 3;
        return $"{this.Name} atacou com {this.Weapon} e causou  {Damage} de dano, Foi Critico!";
      }
      else
      {
        return $"{this.Name} atacou com {this.Weapon} e errooou!";
      }



    }

    public virtual string Apperad()
    {
      return $"O inimigo {this.Name} apareceu";
    }

  }
}