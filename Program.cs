using System;

namespace csharp_rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, paper, or scissors?");
            Random choice = new Random();

            string[] cpuChoice = { "rock", "paper", "scissors" };

            int mIndex = choice.Next(cpuChoice.Length);


            string myChoice = Console.ReadLine();

            // Console.WriteLine($"Are you sure you want to choose {myChoice}");

            // Console.WriteLine(" I choose: {0}", cpuChoice[mIndex]);



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