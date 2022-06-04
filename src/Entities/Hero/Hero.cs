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

    public int Life { get; set; }
    public string Weapon { get; set; }

    public Hero(string name, int level, string characterClass, int life = 15, string weapon = "suas mãos")
    {
      this.Name = name;
      this.Level = level;
      this.CharacterClass = characterClass;
      this.Life = life;
      this.Weapon = weapon;
    }

    public virtual string Attack()
    {
      return $"{this.Name} atacou com {this.Weapon}!";
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
        return $"{this.Name} atacou com {this.Weapon} e errou vergonhosamente";
      }



    }
  }
}