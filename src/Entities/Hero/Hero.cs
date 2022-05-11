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
      }else{
        return $"{this.Name} atacou com {this.Weapon} e errou vergonhosamente";
      }



    }
  }
}