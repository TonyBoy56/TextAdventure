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
                SceneFour(hack, newPlayer);
            }
        }
        public void Riddle(string response, string answer, string riddle, string nextRiddle)
        {
            if (response == answer) {
                Console.WriteLine(nextRiddle);
            }
            else
            {
                Console.WriteLine(riddle);
            }
        }
        public void SceneFour(string hack, string newPlayer)
        {
            string answer1 = "keyboard";
            string answer2 = "egg";
            string answer3 = "candle";
            string success = "Congratulations";
            // int tries = 0;
            string riddle1 = "What has keys but no locks, space but no room and you can enter but can't go inside?";
            string riddle2 = "A stone as pale as the moom break it open and reveal the sun. What am I?";
            string riddle3 = "I'm tall when I'm young and I'm short when I'm old. What am I?";
            Console.WriteLine("*In order to hack into Facless's MAINFRAME, you must solve the following three riddles correctly.*");
            Console.WriteLine(riddle1);
            string response1 = Console.ReadLine();
            Riddle(response1, answer1, riddle1, riddle2);
            string response2 = Console.ReadLine();
            Riddle(response2, answer2, riddle2, riddle3);
            string response3 = Console.ReadLine();
            Riddle(response3, answer3, riddle3, success);
            SceneFive();
            
        
            
            // while (tries != 3)
            // {
            //     while (response1 != "keyboard")
            //     {
            //         Console.WriteLine("Wrong! Try again!");
            //         tries = 1;
            //         Console.WriteLine(riddle1);
            //         response1 = Console.ReadLine();
            //         tries = 2;
            //         Console.WriteLine(riddle1);
            //         response1 = Console.ReadLine();
            //         Console.WriteLine("Wrong! Try again!");
            //         tries =3;
            //     }
            //     if (response1 == "keyboard")
            //     {
            //         Console.WriteLine("That is correct!");
            //         Console.WriteLine(riddle2);
            //         response2 = Console.ReadLine();
            //     }

            //     while (response2 != "egg")
            //     {
            //         Console.WriteLine("Wrong! Try again!");
            //         tries += 1;
            //     }
            //     if (response2 == "egg")
            //     {
            //         Console.WriteLine("That is correct!");
            //         Console.WriteLine(riddle3);
            //         response3 = Console.ReadLine();
            //     }
            //     while (response3 != "candle")
            //     {
            //         Console.WriteLine("Wrong! Try again!");
            //         Console.WriteLine("GAME OVER. You have failed in your journey");
            //         tries += 1;
            //     }
            //     if (response3 == "candle")
            //     {
            //         Console.WriteLine("You have successfully hacked the mainframe!");
            //         tries = 3;
            //         SceneFive();
            //     }
            // }
        }

        public void SceneFive()
        {
            Console.WriteLine("You have found a large directory folder name 'DOOMS' within the mainframe. Even its folder icon appears to be somewhat distorted, and cracked in its lower left corner. Do you wish to open it, and reveal its contents?");
        }
    }
}
