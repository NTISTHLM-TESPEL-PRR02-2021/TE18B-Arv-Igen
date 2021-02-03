using System;

namespace ArvIgen
{
  public class Potion
  {
    protected string name = "";

    public int amount = 20;
    // public bool isSmall = false;

    public Potion()
    {
      // Console.WriteLine("Potion!");
    }

    public virtual void Use(Player target)
    {
      target.hp += amount;

      // if (isSmall == true)
      // {
      //   target.hp += 2;
      // }
      // else
      // {
      //   target.hp += 20;
      // }

    }
  }
}
