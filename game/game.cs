using System;
using game.models;
using System.Collections.Generic;
namespace game.run
{
  class Game
  {
    //this is the only map 
    Map map = Map.Instance;
    Room currentRoom;
    Vector2 playerLocation = new Vector2(0, 0);
    // Room currentRoom;
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

      Console.WriteLine($"ah yes, {userName} i remember you.");
      Console.WriteLine($"your journey starts here in the forest of doom. I hear its lovely this time of year.");
      Console.WriteLine("press enter to continue...");
      Console.ReadLine();
      while (running)
      {
        Console.Clear();
        Console.WriteLine(@"
     
             (lookaround)={l}  (move)={m}  (pickup) {p + item name}  (quit) {q}
      ------------------------------------------------------------------------------- ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
          case "l":
            description();
            break;
          case "m":
            move();
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
    
              (lookaround)={l}       (move)={n,s,e,w}      (pickup) {itemname}
      ------------------------------------------------------------------------------- ");
            break;
        }
      }
      Console.WriteLine("you died...");
    }

    void description()
    {
      Console.Clear();
      Console.WriteLine("this area is coverd in sand there is not much here. It looks like we can go west or north...");
      Console.WriteLine(playerLocation.x + " " + playerLocation.y);



      Console.WriteLine(@"
        (move)={m}    (pickup) {p + item name}    (exit) {}
      -------------------------------------------------------");
      string userInput = Console.ReadLine();
      switch (userInput)
      {
        case "m":
          move();
          break;
      }

    }
    void move()
    {
      Console.Clear();
      bool validInput = false;
      Console.WriteLine(@"
                              Where would you like to go?
                --------------------------------------------------------
                (north){n}  (south){s}  (east){e}  (west){w} (cancel) {}");
      while (!validInput)
      {

        string userInput = Console.ReadLine();
        switch (userInput)
        {
          case "n":
            validInput = true;
            break;
          case "e":
            break;
          case "s":
            break;
          case "w":
            break;
        }
        Console.Clear();
        Console.WriteLine(@"
                      that is not an option try again. 
         --------------------------------------------------------
         (north){n}  (south){s}  (east){e}  (west){w} (cancel) {}");
      }

    }





  }

};