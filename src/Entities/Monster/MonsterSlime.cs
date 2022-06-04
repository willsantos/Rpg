using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rpg.src.Entities.Monster
{
  public class MonsterSlime : Monster
  {
    public MonsterSlime(string name, int level, int life, string weapon = "com seu corpo") : base(name, level, life, weapon)
    {
      this.Life = (life + 2) * level;
    }

    public override string Apperad()
    {
      return $"Apareceu uma geleca assustadora com {this.Life} de vida";
    }
  }
}