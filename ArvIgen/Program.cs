using System.Collections.Generic;
using System;

namespace ArvIgen
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Player p1 = new Player("Ralf");

      // Potion thing = new VerySmallPotion();

      // List<Potion> potions = new List<Potion>();

      // potions.Add(new Potion());
      // potions.Add(new SmallPotion());
      // potions.Add(new VerySmallPotion());

      // potions[1].Use(p1);


      // Potion largePotion = new Potion();
      // SmallPotion smallPotion = new SmallPotion();

      Potion p = new RandomPotion();
      

      Console.WriteLine(p1.name + " HP: " + p1.hp);
      
      p.Use(p1);

      Console.WriteLine(p1.name + " HP: " + p1.hp);

      Console.ReadLine();
    }
  }
}