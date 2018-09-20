using System;
using System.Collections.Generic;

namespace csharp_rps
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playing = true;
            Console.Clear();

            while (playing)
            {
                Console.WriteLine("Rock, paper, or scissors?");
                Random choice = new Random();

                List<string> cpuChoice = new List<string>(new string[] { "rock", "paper", "scissors" });

                int mIndex = choice.Next(cpuChoice.Count);


                string myChoice = Console.ReadLine();

                // Console.WriteLine($"Are you sure you want to choose {myChoice}");

                // Console.WriteLine(" I choose: {0}", cpuChoice[mIndex]);


                if (!cpuChoice.Contains(myChoice))
                {
                    Console.WriteLine($"Thaaats not a thing!");

                    continue;

                }

                if (myChoice != null && myChoice.ToLower() == "rock" && cpuChoice[mIndex] == "paper")
                {

                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, I beat you sucka!");
                };

                if (myChoice != null && myChoice.ToLower() == "rock" && cpuChoice[mIndex] == "scissors")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, Ahh you got me!");
                };

                if (myChoice != null && myChoice.ToLower() == "rock" && cpuChoice[mIndex] == "rock")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]} too!, We both win!");
                };

                if (myChoice != null && myChoice.ToLower() == "scissors" && cpuChoice[mIndex] == "scissors")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]} too!, We both win!");
                };

                if (myChoice != null && myChoice.ToLower() == "scissors" && cpuChoice[mIndex] == "paper")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, Ahh you got me!");
                };

                if (myChoice != null && myChoice.ToLower() == "scissors" && cpuChoice[mIndex] == "rock")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, I beat you sucka!");
                };

                if (myChoice != null && myChoice.ToLower() == "paper" && cpuChoice[mIndex] == "scissors")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, I beat you sucka!");
                };

                if (myChoice != null && myChoice.ToLower() == "paper" && cpuChoice[mIndex] == "rock")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]}, Ahh you got me!");
                };

                if (myChoice != null && myChoice.ToLower() == "paper" && cpuChoice[mIndex] == "paper")
                {
                    Console.WriteLine($"I chose {cpuChoice[mIndex]} too!, We both win!");
                };



                System.Console.WriteLine("Rematch? (Y/N)");
                string response = Console.ReadLine();
                if (response.ToUpper() != "Y")
                {
                    playing = false;

                }

            };









        }
    }
}

//  string choice = Console.ReadLine();
//             Console.WriteLine($"Are you sure you want to choose {choice}?");

//             string Rock = Console.ReadLine();
//             Console.WriteLine($"You lose, I chose Paper!");

//             string Paper = Console.ReadLine();
//             Console.WriteLine($"You lose, I chose Scissors!");

//             string Scissors = Console.ReadLine();
//             Console.WriteLine($"You lose, I chose Rock!");