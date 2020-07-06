using System;
using System.Collections.Generic;
using game.models;
namespace game.models
{
  class Room
  {

    List<Item> roomItems = new List<Item>();
    public int x { get; }
    public int y { get; }
    public Room(int X, int Y)
    {
      x = X;
      y = Y;
      Console.WriteLine("created room at: " + x + " " + y);
    }
    static public string getPaths()
    {
      return "test";
    }


  }




}