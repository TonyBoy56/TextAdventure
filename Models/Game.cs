using System;

namespace TextGame.Models
{
    public class Game
    {
        // public string Difficulty{ get; set; }
        public bool Fate{ get; set; }
        public string Player{ get; set; }
        public string Items{ get; set; }
        public int Tries{ get; set; }


        public Game(bool fate, string player, int tries)
        {
            Player = player;
            Fate = fate;
            Tries = tries;
        }

        public void StartGame(string newPlayer, int tries)
        {
            // Difficulty = newDifficulty;
            Player = newPlayer;
        }

        private void IncreaseTries()
        {
            Tries++;
        }

        private void CheckTries()
        {
            if (Tries == 3)
            {
                Console.WriteLine("GAME OVER");
            }
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
            Console.WriteLine("Hello " + newPlayer + ". My name is Agent Smith. I desperately need your help in the fight against Facless, Destroyer of Worlds. We need you to help us hack into Facless's MAINFRAME and uncover his evil plan! Whatever you do, DO NOT open what it is you find. You could trigger a drastic chain of events.");
            Console.WriteLine("*Enter: 'hack' to aid Agent Smith in his battle against Facless*");
            string hack = Console.ReadLine();
            if (hack == "hack")
            {
                SceneFour(hack, newPlayer);
            }
        }

        public void SceneFour(string hack, string newPlayer)
        {
            Console.WriteLine("*In order to hack into Facless's MAINFRAME, you must solve the following three riddles correctly.*");
            Riddle1();
        }    
            
        private void Riddle1()
        {
            string response1 = "";
            string riddle1 = "What has keys but no locks, space but no room and you can enter but can't go inside?";
            if (Tries != 3)
            {
            Console.WriteLine(riddle1);
            response1 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response1 != "keyboard" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle1();
            }
            else if (response1 == "keyboard")
            {
                Console.WriteLine("That is correct!");
                Riddle2();
            }
        }
            
        private void Riddle2()
        {
            string response2 = "";
            string riddle2 = "A stone as pale as the moon, break it open and reveal the sun";
            if (Tries != 3)
            {
            Console.WriteLine(riddle2);
            response2 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response2 != "egg" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle2();
            }
            else if (response2 == "egg")
            {
                Console.WriteLine("That is correct!");
                Riddle3();
            }
        }

        private void Riddle3()
        {
            string response3 = "";
            string riddle3 = "I'm tall when I'm young and short when I'm old";
            if (Tries != 3)
            {
            Console.WriteLine(riddle3);
            response3 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response3 != "candle" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle3();
            }
            else if (response3 == "candle")
            {
                Console.WriteLine("That is correct!");
                SceneFive();
            }
        }
            
        public void SceneFive()
        {
            Console.WriteLine("You have found a large directory folder name 'DOOMS' within the mainframe. Even its folder icon appears to be somewhat distorted, and cracked in its lower left corner. Do you wish to open it and reveal its contents (open), or, deliver it directly to Agent Smith? (deliver)");

            string response = Console.ReadLine(string newPlayer);

            if (response == "open")
            {
                Console.WriteLine("You open the file to reveal the following: 'This reality is but a fragment of the perception of the individual. Molded by each others perception, there is power in the mind. The Assimilation Project is successful thus far, and all that is left is for my chosen subject to deliver this lost file to me. Without it, I fear the fate of the Assimilation Project is compromised, and I will become unable to see my daughter once again. Amelia, if you could ever forgive what your father has done to reprise your being, then perhaps one day you could fathom the fruits of this unbearable labor.");

                SceneSix();
            }
            else 
            {
                Console.WriteLine("You contact Agent Smith and send him the file without peering into its contents. He responds immediately, with an evil laugh 'muahahaha'. My dear " + newPlayer + ", a great service you have done for me. Unfortunately for you, your true identity will never be revealed, as you are not who you believe yourself to be... AMELIA");

                Console.WriteLine("FIN");
            }
        }

        private void SceneSix(string newPlayer)
        {
            Console.WriteLine("Now that you possess this information, you have a choice to make: Will you deliver it to Agent Smith (deliver)? Or will you choose to deal with this on your own?");
            Console.WriteLine("You have the skills to deploy this on your own (deploy). Or perhaps, you will choose to contact this mysterious 'Facless' (contact).");
            string response = Console.ReadLine();

            if (response == "deliver")
            {
                Console.WriteLine("You contact Agent Smith and send him the file without peering into its contents. He responds immediately, with an evil laugh 'muahahaha'. My dear " + newPlayer + ", a great service you have done for me. Unfortunately for you, your true identity will never be revealed, as you are not who you believe yourself to be. Now you and Facless will never be reunited.");
            } 
            else if (response == "deploy")
            {
                 Console.WriteLine("Screw it! You know how to do this and you don't need Agent Smith or anyone else to help you. You're tired of being a puppet. You scroll to the bottom of the file and see a link that simply says 'DEPLOY'...you click it.");
                 Console.WriteLine("....you start to feel dizzy...the walls fall away....you look down and you're clutching...a TEDDY BEAR?? You blink and look around. Strangers swarm around you. Very tall strangers. You cry out-- and stop yourself. That.. is not your voice. One of the tall strangers walks up to you and asks, 'Little girl, are you lost?' ");
            }
            else if (response == "contact") 
            {
                Console.WriteLine("You know you could handle this yourself, but this seems to big to take on by yourself. A second pair of eyes couldn't hurt. You do your hacker thing. Upon brute forcing the encryption, you find an email address hidden in the depths of the code. FACLESS@AOL.com. Yeah. You shoot him an email asking for help.");
                Console.WriteLine("Ten seconds pass before your terminal screen is taken over by a laughing alien gif. A robot voice comes out of it. 'Amelia! Is that really you?'");
                Console.WriteLine("You don't reply. What could you say to that? He continues: 'Of course, you don't know. " + newPlayer + ", you're not who you think you are. You are in fact..... .. my six year old daughter Amelia. During my work on the Assimilation Project Mr. Smith uploaded your consciousness into the mainframe in order to blackmail me to work for him as his prisoner. Now that you have the file, you can finally be free. It contatins an exit command for this reality. If you don't exit the program, you'll be stuck as an underpaid, insecure middle-aged man named " + newPlayer + " forever.");
                Console.WriteLine("This is an important choice. Think it over. Should you choose to stay, knowing that the reality you inhabit is just a simulation (stay)? Or do you choose to believe your 'dad' and possibly end up destroying the world OR best case scenario, become a little girl? Then again.. you love ice cream and teddy bears. And maybe now they'll stop calling you a Brony (leave).");

                string response = Console.ReadLine();

                if(response == "leave")
                {
                Console.WriteLine("You scroll to the bottom of the file and see a link that simply says 'DEPLOY'...you click it.");
                 Console.WriteLine("....you start to feel dizzy...the walls fall away....you look down and you're clutching...a TEDDY BEAR?? You blink and look around. Strangers swarm around you. Very tall strangers. You cry out-- and stop yourself. That.. is not your voice. One of the tall strangers walks up to you and asks, 'Amelia?' He scoops you up and gives you a tight hug. You say, 'Whoa. That was crazy. What is going on? Do I know you?' The man looks into your eyes. 'You're not Amelia.. What have you done with her mind??'");
                }
            } 
        } 
    }
}
