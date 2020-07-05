using System;
using game.models;
namespace game.run
{
  class Game
  {
    bool running = false;
    public Game()
    {
      Console.Clear();
      bool login = false;
      string userName = "";
      while (!login)
      {
        Console.WriteLine("Welcome to the game. Please enter a name to continue...");
        string userInput = Console.ReadLine();
        if (userInput.Length >= 3)
        {
          User user = new User(userInput);
          userName = user.name;
          login = true;
        }
        else
        {
          Console.Clear();
          Console.WriteLine("please enter at least three characters for your name");
        }
      }
      running = true;
      Console.Clear();
      Console.WriteLine($"nice to meet you {userName}");
      Console.WriteLine($"your journy starts here in the forest...");
      Console.WriteLine("press any key to continue...");
      Console.ReadLine();
      Console.WriteLine("ah the forest a great place to get lost.....");
      while (running)
      {
        Console.Clear();
        Console.WriteLine(@"
      -------------------------------------------------------------------------------
        (lookaround)={l}  (move)={n,s,e,w}  (pickup) {p + item name}  (quit) {q}
      ------------------------------------------------------------------------------- ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
          case "l":
            break;
          case "move":
            break;
          case "p":

            break;
          case "q":
            running = false;
            break;
          default:
            Console.Clear();
            Console.WriteLine("that was not a valid option try one of theese commands");
            Console.WriteLine(@"
      -------------------------------------------------------------------------------
        (lookaround)={l}       (move)={n,s,e,w}      (pickup) {itemname}
      ------------------------------------------------------------------------------- ");
            break;
        }
      }
      Console.WriteLine("you died because you are a quiter...");
    }
  }

};