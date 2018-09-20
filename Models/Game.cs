namespace csharp_rps.Models
{

    public class Choice
    {

        public string Rock { get; set; }
        public string Paper { get; set; }
        public string Scissors { get; set; }
        public Choice(string rock, string paper, string scissors)
        {

            Rock = rock;
            Paper = paper;
            Scissors = scissors;
        }
    }





}