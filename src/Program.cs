using Rpg.src.Entities;
using static System.Console;

namespace Rpg.src
{
  public class Program
  {
    static void Main(string[] args)
    {

    private static string getPlayerName(string Name)
    {
      while (Name == "")
      {
      WriteLine("Qual o nome da sua personagem?");
        Name = ReadLine();
      }

      return Name;
    }


      Warrior p1 = new Warrior(Name: Name);

      WriteLine(p1.Attack());
    }

  }

}