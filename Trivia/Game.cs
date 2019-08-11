using static System.Console;

namespace Trivia
{
    class Game
    {
        string gameName = "Trivia Game";
        Player player;
        TriviaItem[] Questions = new TriviaItem[2];

        public Game()
        {
            Title = gameName;
            SetUpQuestions();
            player = new Player();
            WriteLine($"Welcome to {gameName}.\n{player.PlayerInformation()}");
            Play();
            EndGame();
        }

        private void Play()
        {
            foreach (TriviaItem triviaItem in Questions)
            {
               Clear();
               WriteLine(player.PlayerInformation());
               WriteLine(triviaItem.Question);
                string input = ReadLine();
                if (triviaItem.CheckAnswer(input))
                {
                    player.IncrementScore();
                }
            }
        }

        private void SetUpQuestions()
        {
            Questions[0] = new TriviaItem("a", "b");
            Questions[1] = new TriviaItem("c", "d");
        }

        private void EndGame()
        {
            Clear();
            WriteLine($"{player.PlayerInformation()}\nThanks for playing! Press enter to quit.");

            ReadKey();
        }
    }
}
