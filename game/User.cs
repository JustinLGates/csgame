using System.Collections.Generic;
using System;
namespace game.models
{
  class User
  {

    List<Item> inventory = new List<Item>();
    public string name { get; set; }
    public User(string Name)
    {
      name = Name;

    }
    public void addItem(Item item)
    {
      inventory.Add(item);
      Console.WriteLine("adding" + item);
    }
    public void removeItem(Item item)
    {
      inventory.Remove(item);
      Console.WriteLine("adding" + item);
    }
  }
}