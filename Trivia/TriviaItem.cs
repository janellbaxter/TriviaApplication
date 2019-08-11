
namespace Trivia
{
    class TriviaItem
    {
        string question = "";
        string answer = "";

        public TriviaItem(string _question, string _answer)
        {
            //In the future we can get data from another source, like an a text file or database
            //For this version we'll have data passed in to the constructor
            question = _question;
            answer = _answer;
        }

        public string Question { get => question;}

        public bool CheckAnswer(string _input)
        {
            if (_input.ToLower() == answer.ToLower())
            {
                return true;
            }
            return false;
        }

    }
}
