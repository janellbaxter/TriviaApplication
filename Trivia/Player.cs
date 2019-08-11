using static System.Console;

namespace Trivia
{
    class Player
    {
        string name = "Anonymous Person";
        int score = 0;

        public Player()
        {
            WriteLine("Hello! What is your name?");
            name = ReadLine();
        }

        public void IncrementScore()
        {
            score++;
        }

        public string PlayerInformation()
        {
            return $"{name}'s score: {score}";
        }
    }
}
