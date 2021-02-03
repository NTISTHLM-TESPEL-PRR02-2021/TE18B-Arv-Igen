using System;

namespace ArvIgen
{
  public class RandomPotion : Potion
  {
    static Random generator = new Random();

    public override void Use(Player target)
    {
      Console.WriteLine("WOHO! RANDOM!");
      target.hp += generator.Next(1, 20);
    }
  }
}
