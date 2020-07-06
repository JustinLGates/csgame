using System;
using System.Collections.Generic;
namespace game.models
{
  class Map
  {
    List<Room> rooms = new List<Room>();
    private Map()
    {
      Room r1 = new Room(0, 0);
      Room r2 = new Room(1, 0);
      Room r3 = new Room(2, 0);
      Room r4 = new Room(3, 0);
      rooms.Add(r1);
      rooms.Add(r2);
      rooms.Add(r3);
      rooms.Add(r4);

    }
    public string getRooms(int x, int y)
    {
      if (ro)
        return $"{rooms[2].x },{ rooms[2].y}";
    }
    private static Map instance = null;
    public static Map Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new Map();
        }
        return instance;
      }
    }
  }

}