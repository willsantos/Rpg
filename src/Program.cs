using Rpg.src.Entities;
using Rpg.src.Entities.Monster;
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

      Monster monster1 = new MonsterSlime("Geleca", 2, 2);

      System.Console.WriteLine(monster1.Apperad());
      WriteLine("Aperte qualquer tecla para atacar");
      ReadKey();

      while (monster1.Life > 0)
      {
        int damage = rollDice();
        WriteLine($"Rolou {damage} no dado");
        WriteLine(Player.Attack(damage));

        if (damage != 1)
        {
          monster1.Life = monster1.Life - damage;

        }
        WriteLine("Aperte qualquer tecla para atacar");
        ReadKey();

      }
      WriteLine("Monstro demo foi derrotado");





    }

    private static string Demo()
    {
      int Hp = 8;
      int Attack = 1;
      string mensagem = $"Apareceu uma geleca assustadora com {Hp} de vida";

      return mensagem;
    
    }

    private static int rollDice()
    {
      Random rnd = new Random();
      int DiceValue = 0;

      DiceValue = rnd.Next(1, 6);



      return DiceValue;

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