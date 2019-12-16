using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    using static System.Console;
    class Program
    {
        static string[] answers = { "Stinky", "Smelly", "Ucky", "Fresh", "Fragrant", "Clean" };
        static Random random = new Random();
        static int index = random.Next(answers.Length);
        static void Main(string[] args)
        {
            bool wrong = true;
           
            Write("Welcome to Hangman! Would you like to play a game? ");

            while (wrong)
            {
                string userChoice;
                userChoice = Convert.ToString(ReadLine());

                if (userChoice == "yes" || userChoice == "Yes")
                {
                    if (userChoice == "yes" || userChoice == "Yes")
                    {
                        Write("Very well then! Let's commence the action! ");
                        WriteLine("Give your best guests and don't let our guy die!");

                        DisplayHangman();
                    }
                }
                else if (userChoice == "no" || userChoice == "No")
                {
                    Write("You're straight up kind of a buzzkill bro, not cool. ");
                    return;
                }
                else if (userChoice == "exit" || userChoice == "Exit" || userChoice == "done" || userChoice == "Done")
                {
                    WriteLine("Thanks for playing!");
                    return;
                }
            }
        }
        public static void DisplayHangman()
        {
            List<char> userChoice = new List<char>();
            int wrong = 0;
            int right = 0;
            string word = answers[index].ToLower();
            WriteLine("Give your best guest at these, because after 6 tries you lose!");
            WriteLine(word);
            while (wrong != 6)
            {
                Write("Guess: ");
                string guessS =" ";
                try
                {
                    guessS = ReadLine().ToLower();
                }
                catch (Exception)
                { }
                if (guessS == " ")
                {
                    WriteLine("Please enter a valid character");
                }
                else if (guessS.Length > 1)
                {
                    WriteLine("Enter only a single character!");
                }
                else
                {
                    char guess = Convert.ToChar(guessS);
                    userChoice.Add(guess);

                    for (int j = 0; j < word.Length; ++j)
                    {
                        bool found = false;
                        foreach (char c in userChoice)
                        {
                            if (c == word[j])
                            {
                                Write(c);
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Write("_");
                            ++wrong;
                        }


                    }
                    
                    
                }
                
                Write(" Sorry buddy, better luck next time.");
            }



            //WriteLine($"The word is {answers[index]}"); Keep this in mind, this is how you can generate the answer and show it, so don't forget it!
        }
    }
}
