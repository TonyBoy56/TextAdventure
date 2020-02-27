using System;
using System.Collections.Generic;
using TextGame.Models;

public class Program
{
    public static void Main()
    {
            Console.WriteLine("Please enter your name:");
            string newPlayer = Console.ReadLine();
            // Console.WriteLine("Please choose either easy or hard difficulty level:");
            // string newDifficulty = Console.ReadLine();
            // if (newDifficulty == "easy")
      
            Game newGame = new Game(true, newPlayer, 0);
            newGame.StartGame(newPlayer, 0);
            newGame.SceneOne(newPlayer);
        
    }
}