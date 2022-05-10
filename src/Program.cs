using Rpg.src.Entities;
using static System.Console;

namespace Rpg.src
{
  public class Program
  {
    static void Main(string[] args)
    {
      string Name = "";
      string CharacterClass = "";

      Name = getPlayerName(Name);
      CharacterClass = getPlayerClass();


      Hero Player = CreatePlayer(Name, CharacterClass);

      WriteLine(Demo());

      WriteLine(Player.Attack());

    }

    private static string Demo()
    {
      string mensagem = "Apareceu uma geleca assustadora";
      int Hp = 5;
      int Attack = 1;
      return mensagem;

    }

    private static string getPlayerName(string Name)
    {
      while (Name == "")
      {
        WriteLine("Qual o nome da sua personagem?");
        Name = ReadLine();
      }

      return Name;
    }

    private static string getPlayerClass(string CharacterClass = "")
    {
      int options = 0;

      while (options == 0)
      {
        WriteLine("Com qual Classe você quer jogar?");
        Write("1- Guerreiro ");
        WriteLine("2- Mago");
        WriteLine("Digite o numero da Classe");
        CharacterClass = ReadLine();

        switch (CharacterClass)
        {
          case "1":
            options = 1;
            break;
          case "2":
            options = 2;
            break;
          default:
            options = 0;
            break;
        }

      }
      return CharacterClass;
    }

    private static Hero CreatePlayer(string Name, string CharacterClass)
    {

      Hero p1;
      switch (CharacterClass)
      {
        case "1":
          p1 = new Warrior(Name: Name);
          break;

        case "2":
          p1 = new Wizard(Name: Name);
          break;

        default:
          throw new Exception("Falha interna");

      }

      return p1;

    }
  }

}