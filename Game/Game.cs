using System;
using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset()
    {

    }

    internal void Room()
    {
      throw new NotImplementedException();
    }

    internal void Items()
    {
      throw new NotImplementedException();
    }

    public void Setup()
    {
      Console.WriteLine("Brave Young Warrior our forces are failing and the enemy grows stronger everyday. I fear if we don't act now our people will be driven from their homes. These dark times have left us with one final course of action. We must cut the head off of the snake by assasinating the Dark Lord of Grimtol... Our sources have identified a small tunnel that leads into the rear of the castle.");

      Console.WriteLine("Once you `sneak` through the tunnel you will need to find a way to disguise yourself and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and cunning to think of something.");

      Console.WriteLine("Good Luck brave one.");
    }

    public void UseItem(string itemName)
    {

    }
  }
}