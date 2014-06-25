namespace TennisMatchCodingDojo
{
    public class GameScore
    {
        private int _huidigeScore;

        public GameScore(int score)
        {
            _huidigeScore = score;
        }

        public void Verhoog()
        {
            _huidigeScore++;
        }

        public string GeefScoreAlsTekst()
        {
            return _huidigeScore.ToString();
        }
    }
}