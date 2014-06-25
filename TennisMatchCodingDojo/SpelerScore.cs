using System;
using TennisMatchCodingDojo.Punten;

namespace TennisMatchCodingDojo
{
    public class SpelerScore
    {
        private Punt _huidigeGameScore = new StartPunt();
        private readonly GameScore _totaleGameScore = new GameScore(0);

        public void VoegPuntToe(SpelerScore scoreVanAndereSpeler)
        {
            _huidigeGameScore = BepaalVolgendePunt(_huidigeGameScore, scoreVanAndereSpeler);
        }

        public bool ScoreIsGelijkAan(Punt punt)
        {
            return _huidigeGameScore.IsGelijkAan(punt);
        }

        public bool HeeftAdvantage()
        {
            return _huidigeGameScore.IsGelijkAan(new Advantage());
        }

        private Punt BepaalVolgendePunt(Punt vorigePunt, SpelerScore scoreVanAndereSpeler)
        {
            if (vorigePunt.IsGelijkAan(new StartPunt()))
            {
                return new EerstePunt();
            }

            if (vorigePunt.IsGelijkAan(new EerstePunt()))
            {
                return new TweedePunt();
            }

            if (vorigePunt.IsGelijkAan(new TweedePunt()))
            {
                return new DerdePunt();
            }

            if (vorigePunt.IsGelijkAan(new DerdePunt()))
            {
                return BepaalVolgendePuntBijDerdePunt(scoreVanAndereSpeler);
            }

            if (HeeftAdvantage())
            {
                _totaleGameScore.Verhoog();
                scoreVanAndereSpeler.ResetHuidigeGameScore();
                return new StartPunt();
            }

            throw new InvalidOperationException();
        }

        private void ResetHuidigeGameScore()
        {
            _huidigeGameScore = new StartPunt();
        }

        private Punt BepaalVolgendePuntBijDerdePunt(SpelerScore scoreVanAndereSpeler)
        {
            if (scoreVanAndereSpeler.ScoreIsGelijkAan(new DerdePunt()))
            {
                return new Advantage();
            }

            if (scoreVanAndereSpeler.HeeftAdvantage())
            {
                scoreVanAndereSpeler.ZetDeuce();
                return new DerdePunt();
            }

            if (!scoreVanAndereSpeler.HeeftAdvantage())
            {
                _totaleGameScore.Verhoog();
                scoreVanAndereSpeler.ResetHuidigeGameScore();
                return new StartPunt();
            }

            throw new InvalidOperationException();
        }

        private void ZetDeuce()
        {
            _huidigeGameScore = new DerdePunt();
        }

        public string GeefHuidigeGameScoreAlsTekst()
        {
            return GeefHuidigeGameScore().AlsTekst();
        }

        public Punt GeefHuidigeGameScore()
        {
            return _huidigeGameScore;
        }

        public string GeefTotaleGameScoreAlsTekst()
        {
            return _totaleGameScore.GeefScoreAlsTekst();
        }
    }
}