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
        public string Difficulty{ get; set; }


        public Game(bool fate, string player, int tries, string difficulty)
        {
            Player = player;
            Fate = fate;
            Tries = tries;
            Difficulty = difficulty;
        }

        public void StartGame(string newPlayer, int tries, string newDifficulty)
        {
            Difficulty = newDifficulty;
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
                Console.WriteLine("Type 'yes' to call, type 'no' to ignore");
                string call = Console.ReadLine();
                if ( call == "yes")
                {
                    SceneThree(newPlayer);
                }
                else if (call == "no")
                {
                    Console.WriteLine("You decide to ignore the message. You've got far too much work to do and don't have time to mess around with mysterious Agents.");
                    Console.WriteLine("All of a sudden, your screen flickers and you see a message in your console: Is this " + newPlayer + "? I desperately need to talk to you!");
                    Scene3(newPlayer);
                }
            }
        }

        public void Scene3(string newPlayer)
        {
            Console.WriteLine("Type 'yes' for yes and type 'no' to ignore.");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine(newPlayer + " there is so much I have to tell you! First, I know you have a tattoo on the inner side of your left arm, is it of the numbers 011001001?");
                Console.WriteLine("You don't need to look, you know what your tattoo is. You also know that it's NOT 011001001.");
                Console.WriteLine("To tell the hacker that your tattoo is actually of a really cool horse, type 'reveal', to lie and say it is the number he gave you, type 'lie'.");
                Scene4(newPlayer);
            } 
            else if (response == "no")
            {
                Console.WriteLine("Okay. You're clearly too busy for this. Bye!");
                Console.WriteLine("Deleting all files from your hard drive.....");
                Console.WriteLine("GAME OVER");
            }
        }

        public void Scene4(string newPlayer)
        {
            string response = Console.ReadLine();
            if (response == "reveal")
            {
                Console.WriteLine("Oh...a...what? Um...heheh I think I have the wrong person. Forget this ever happened. OR ELSE.");
                Console.WriteLine("Deleting all files from your hard drive.....");
            }
            else if (response == "lie")
            {
                Console.WriteLine("I bet you're wondering how I know so much about you...or the person you THINK you are...I'm willing to give you this information in exchange for your help with the top secret Assimilation Project. We need you to use your unparalleled encryption skills to encrypt and protect a very important file.");
                Console.WriteLine("Do you want to help the mysterious hacker and retrieve the information (type 'help')? Or do you choose not to trust them (type 'sus').");
                Scene5(newPlayer);
            }
        }

        public void Scene5(string newPlayer)
        {
            string response = Console.ReadLine();
            if (response == "sus")
            {
                Console.WriteLine("The phone rings...it could be your boss so you pick it up...");
                SceneThree(newPlayer);
            }
            else if (response == "help")
            {
                Console.WriteLine("In order to properly encrypt the file, you must answer the following three riddles correctly:");
                Riddle1(newPlayer);
            }
        }
        public void SceneThree(string newPlayer)
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
            if (newDifficulty == "blue")
            {
            Riddle1(newPlayer);
            }
            else if (newDifficulty == "red")
            {
            Riddle4(newPlayer);
            }
        }    
            
        private void Riddle1(string newPlayer)
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
                Riddle1(newPlayer);
            }
            else if (response1 == "keyboard")
            {
                Console.WriteLine("That is correct!");
                Riddle2(newPlayer);
            }
        }
            
        private void Riddle2(string newPlayer)
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
                Riddle2(newPlayer);
            }
            else if (response2 == "egg")
            {
                Console.WriteLine("That is correct!");
                Riddle3(newPlayer);
            }
        }

        private void Riddle3(string newPlayer)
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
                Riddle3(newPlayer);
            }
            else if (response3 == "candle")
            {
                Console.WriteLine("That is correct!");
                SceneFive(newPlayer);
            }
        }
            


   private void Riddle4(string newPlayer)
        {
            string response4 = "";
            string riddle4 = "Translate the following: - .... . .-. . / .. ... / -. --- / ... .--. --- --- -.");
            if (Tries != 3)
            {
            Console.WriteLine(riddle4);
            response4 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response4 != "there is no spoon" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle4(newPlayer);
            }
            else if (response4 == "there is no spoon")
            {
                Console.WriteLine("That is correct!");
                Riddle5(newPlayer);
            }
        }
            
        private void Riddle5(string newPlayer)
        {
            string response5 = "";
            string riddle5 = "Decrypt the following message: abaaa abaab abbaa abbab babaa abaab baabb abbaa aabba aabab baabb";
            if (Tries != 3)
            {
            Console.WriteLine(riddle5);
            response5 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response5 != "I know kung fu" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle5(newPlayer);
            }
            else if (response5 == "I know kung fu")
            {
                Console.WriteLine("That is correct!");
                Riddle6(newPlayer);
            }
        }

        private void Riddle3(string newPlayer)
        {
            string response3 = "";
            string riddle3 = "Decrypt the following message: 1111001 1101111 1110101 100000 1100001 1110010 1100101 100000 1110100 1101000 1100101 100000 1101111 1101110 1100101";
            if (Tries != 3)
            {
            Console.WriteLine(riddle3);
            response3 = Console.ReadLine();
            }
            
            if (Tries == 3)
            {
                CheckTries();
            }
            else if (response3 != "you are the one" && Tries != 3)
            {
                IncreaseTries();
                Console.WriteLine("Wrong! Try again!");
                Console.WriteLine(Tries);
                CheckTries();
                Riddle3(newPlayer);
            }
            else if (response3 == "you are the one")
            {
                Console.WriteLine("That is correct!");
                SceneFive(newPlayer);
            }
        }

        public void SceneFive(string newPlayer)
        {
            Console.WriteLine("You have found a large directory folder name 'DOOMS' within the mainframe. Even its folder icon appears to be somewhat distorted, and cracked in its lower left corner. You wish to open it and reveal its contents before you get in touch with the hacker because it seems highly suspicious (open), but maybe you don't trust the hacker and think delivering it directly to Agent Smith is the safer choice? (deliver)");

            string response = Console.ReadLine();

            if (response == "open")
            {
                Console.WriteLine("You open the file to reveal the following: 'This reality is but a fragment of the perception of the individual. Molded by each others perception, there is power in the mind. The Assimilation Project is successful thus far, and all that is left is for my chosen subject to deliver this lost file to me. Without it, I fear the fate of the Assimilation Project is compromised, and I will become unable to see my daughter once again. Amelia, if you could ever forgive what your father has done to reprise your being, then perhaps one day you could fathom the fruits of this unbearable labor.");

                SceneSix(newPlayer);
            }
            else if (response == "deliver")
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
                 if (newDifficulty == "red")
                 {
                     Scene6(newPlayer);
                 }
            }
            else if (response == "contact") 
            {
                Console.WriteLine("You know you could handle this yourself, but this seems to big to take on by yourself. A second pair of eyes couldn't hurt. You do your hacker thing. Upon brute forcing the encryption, you find an email address hidden in the depths of the code. FACLESS@AOL.com. Yeah. You shoot him an email asking for help.");
                Console.WriteLine("Ten seconds pass before your terminal screen is taken over by a laughing alien gif. A robot voice comes out of it. 'Amelia! Is that really you?'");
                Console.WriteLine("You don't reply. What could you say to that? He continues: 'Of course, you don't know. " + newPlayer + ", you're not who you think you are. You are in fact..... .. my six year old daughter Amelia. During my work on the Assimilation Project Mr. Smith uploaded your consciousness into the mainframe in order to blackmail me to work for him as his prisoner. Now that you have the file, you can finally be free. It contatins an exit command for this reality. If you don't exit the program, you'll be stuck as an underpaid, insecure middle-aged man named " + newPlayer + " forever.");
                Console.WriteLine("This is an important choice. Think it over. Should you choose to stay, knowing that the reality you inhabit is just a simulation (stay)? Or do you choose to believe your 'dad' and possibly end up destroying the world OR best case scenario, become a little girl? Then again.. you love ice cream and teddy bears. And maybe now they'll stop calling you a Brony (leave).");

                string choice = Console.ReadLine();

                if(choice == "leave")
                {
                Console.WriteLine("You scroll to the bottom of the file and see a link that simply says 'DEPLOY'...you click it.");
                Console.WriteLine("....you start to feel dizzy...the walls fall away....you look down and you're clutching...a TEDDY BEAR?? You blink and look around. Strangers swarm around you. Very tall strangers. You cry out-- and stop yourself. That.. is not your voice. One of the tall strangers walks up to you and asks, 'Amelia?' He scoops you up and gives you a tight hug. You say, 'Whoa. That was crazy. What is going on? Do I know you?' The man looks into your eyes. 'You're not Amelia.. What have you done with her mind??'");
                if (newDifficulty == "red")
                {
                    Scene7(newPlayer);
                }
                }
                if(choice == "stay")
                {
                    Console.WriteLine("You've done you're risk assessment...and you've chosen to stay. Although this world may not be real, you have it pretty good here. You're a skilled programmer and a notorious hacker, you have an AMAZING My Little Pony collection and, dammit, people like you! You live out the rest of your days happy and, aside from the odd flashbacks of hula hoops and teddy bears and that pesky Mr. Smith spamming your inbox...satisfied!");
                    if (newDifficulty == "red")
                    {
                        Scene8(newPlayer);
                    }
                }
            } 
        } 

        public void Scene6(string newPlayer)
        {
            Console.WriteLine("You reply to the man with, 'yeah I'm out man' and run the other way as fast as your short little legs will carry you. You find a dark alleyway along the path to catch your breath. Heart pounding and mind racing, you are faced with a choice. You MUST get to a computer. You really only have the feasible options to ask for help (ask), or go it alone as a six year old girl (alone)");
            string response = Console.ReadLine();

            if (reponse == "ask")
            {
                Console.WriteLine("Eventually, you wander from the alley and find who appears to be a trustworthy stranger. You approach and say, 'Excuse me, I am trapped in the body of a small child, but I'm not one! I am a man and I work at Technicorp. Can you take me there? (whilst looking as adorable as possible.'");
                Console.WriteLine("To which, the stranger, with much confusion, says 'Sure, I'll help you.'");

                Console.WriteLine("They didn't help you. You end up at the Child Services, who ignore your protestations and deliver you to a nice Amish family in western Pennsylvania. You do not touch a computer for the next twenty years. And you churn butter. For twenty years. gg. Thanks for playing!");
            }
            else if (response == "alone")
            {
                Console.WriteLine("You leave the alleyway and find the nearest cafe, in which, you have rationalized the only option is to steal a hipster's laptop. Unfortunately for you, there is only one hipster with a whole-ass computer in the cafe. You can't physically steal it, so you wait until they go to the bathroom to utilize it.")
            }
        }
    }
}

                