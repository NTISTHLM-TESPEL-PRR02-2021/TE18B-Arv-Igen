using System;

namespace ArvIgen
{
  public class Player
  {
    public int hp = 100;
    public int mp = 100;
    public int strength = 25;
    public string name;

    public Player(string name)
    {
      this.name = name;
    }
  }
}
