using System;
using System.Collections.Generic;


namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {

      var game = new Game.Game();
      game.Setup();
      game.Room();
      game.Items();

      Boolean playing = true;
      while (playing)
      {
        var userInput = Console.ReadLine();
        var userChoice = userInput.Split(' ');

        if(userInput.ToLower() =="north" || userInput.ToLower()== "n")
        {
            Console.WriteLine("north");
        }

        else if(userInput.ToLower() =="south" || userInput.ToLower()== "s")
        {
            Console.WriteLine("south");
        }
        else if(userInput.ToLower() =="west" || userInput.ToLower()== "w")
        {
            Console.WriteLine("west");
        }
        
        else if(userInput.ToLower() =="east" || userInput.ToLower()== "e")
        {
            Console.WriteLine("east");
        }
        else if(userInput.ToLower() =="help" || userInput.ToLower()== "h")
        {
            Console.WriteLine("help");
        }
        else if(userInput.ToLower() =="quit" || userInput.ToLower()== "q")
        {
            Console.WriteLine("quit");
        }
        else if(userInput.ToLower() =="inventory" || userInput.ToLower()== "i")
        {
            Console.WriteLine("inventory");
        }
        else if(userInput.ToLower() =="take" || userInput.ToLower()== "t")
        {
            Console.WriteLine("take");
        }
        else if (userInput.ToLower() =="use" || userInput.ToLower() == "use")
        {
            Console.WriteLine("use");
        }
        else
        {
            
        }
                



        Console.WriteLine("Castle-Grimtol!!!");
        Console.WriteLine("Welcome to the Castle-Grimtol!");
        Console.Read();
      }
    }
  }
}
