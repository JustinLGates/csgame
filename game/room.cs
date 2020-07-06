using System;
using System.Collections.Generic;
using game.models;
namespace game.models
{
  class Room
  {

    List<Item> roomItems = new List<Item>();
    public Vector2 location { get; set; }
    public Room(int x, int y)
    {
      Vector2 location = new Vector2(x, y);
      Console.WriteLine("created room at: " + location.x + " " + location.y);
    }
    static public string getPaths()
    {
      return "test";
    }


  }




}