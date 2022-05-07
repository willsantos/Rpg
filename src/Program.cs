using Rpg.src.Entities;
using static System.Console;

namespace Rpg.src
{
  public class Program
  {
    static void Main(string[] args)
    {

      WriteLine("Qual o nome da sua personagem?");
      string Name = ReadLine();


      Warrior p1 = new Warrior(Name: Name);

      WriteLine(p1.Attack());
    }

  }

}