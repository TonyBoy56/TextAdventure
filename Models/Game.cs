using System;

namespace TextGame.Models
{
    public class Game
    {
        // public string Difficulty{ get; set; }
        public bool Fate{ get; set; }
        public string Player{ get; set; }
        public string Items{ get; set; }


        public Game(bool fate, string player)
        {
            Player = player;
            Fate = fate;
        }

        public void StartGame(string newPlayer)
        {
            // Difficulty = newDifficulty;
            Player = newPlayer;
        }

        // public void EndGame(bool fate)
        // {
        //     Fate = fate;
        //     if (fate == false)
        //     {
        //         Console.WriteLine("GAME OVER");
        //     }
        // }

        public void SceneOne(string newPlayer)
        {
            Console.WriteLine("Hello " + newPlayer + ".");
            Console.WriteLine("Wake up " + newPlayer + ".");
            Console.WriteLine("How would you like to respond?");
            Console.WriteLine("For 'Hello' enter the number 1, for 'Leave me alone!' enter number 2");
            string response1 = Console.ReadLine();
            if (response1 == "1")
            {
                Console.WriteLine("Hi there. There's something in your mailbox " + newPlayer);
                Console.WriteLine("A ZIP file has been sent to you. Type 'open' to read it.");
                string answer2 = Console.ReadLine();
                SceneTwo(answer2, newPlayer);
            }
            else
            {
                Console.WriteLine("Okay. Bye!");
                Console.WriteLine("Deleting all files from your hard drive.....");
                // Fate = false;
                // newGame.EndGame();
                Console.WriteLine("GAME OVER");
            }
        }
        public void SceneTwo(string answer2, string newPlayer)
        {
            if ( answer2 == "open")
            {
                Console.WriteLine("Agent Smith: 281-330-8004");
                Console.WriteLine("Call Agent Smith?");
                string call = Console.ReadLine();
                if ( call == "yes")
                {
                    SceneThree( call, newPlayer);
                }
            }
        }
        public void SceneThree(string call, string newPlayer)
        {
            Console.WriteLine("*Agent Smith answers immediately.");
            Console.WriteLine("Hello " + newPlayer + ". My name is Agent Smith. I desperately need your help in the fight against Facless, Destroyer of Worlds. We need you to help us hack into Facless's MAINFRAME and uncover his evil plan!");
            Console.WriteLine("*Enter: 'hack' to aid Agent Smith in his battle against Facless*");
            string hack = Console.ReadLine();
            if (hack == "hack")
            {
                SceneFour();
            }
        }
        public void SceneFour(string hack, string newPlayer)
        {
            string response2 = "egg";
            string response3 = "candle";
            int tries = 0;
            string riddle1 = "What has keys but no locks, space but no room and you can enter but can't go inside?";
            string riddle2 = "A stone as pale as the moom break it open and reveal the sun. What am I?";
            string riddle3 = "I'm tall when I'm young and I'm short when I'm old. What am I?";
            Console.WriteLine("*In order to hack into Facless's MAINFRAME, you must solve the following three riddles correctly.*");
            Console.WriteLine(riddle1);
            string response1 = Console.ReadLine();

            
            while (tries < 3)
            {
                if (response1 != "keyboard")
                {
                    Console.WriteLine("Wrong! Try again!");
                    tries=+ 1;
                }
                else
                {
                    Console.WriteLine("That is correct!");
                    Console.WriteLine(riddle2);
                    response2 = Console.ReadLine();
                }

                if (response2 != "egg")
                {
                    Console.WriteLine("Wrong! Try again!");
                    tries += 1;
                }
                else 
                {
                    Console.WriteLine("That is correct!");
                    Console.WriteLine(riddle3);
                    response3 = Console.ReadLine();
                }
            }
        }
    }
}
