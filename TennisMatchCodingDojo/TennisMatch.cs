using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo
{
    public class TennisMatch
    {
        private readonly IDictionary<Speler, SpelerScore> _spelerScores =
            new Dictionary<Speler, SpelerScore>
            {
                {Speler.Een, new SpelerScore()},
                {Speler.Twee, new SpelerScore()}
            };

        private readonly IDictionary<Speler, Speler> _andereSpelerLookup =
            new Dictionary<Speler, Speler>
            {
                {Speler.Een, Speler.Twee},
                {Speler.Twee, Speler.Een}
            };

        public string BerekenScore()
        {
            SpelerScore scoreSpelerEen = GetSpelerScore(Speler.Een);
            SpelerScore scoreSpelerTwee = GetSpelerScore(Speler.Twee);

            string spelerEenTotaleGameScore = scoreSpelerEen.GeefTotaleGameScoreAlsTekst();
            string spelerTweeTotaleGameScore = scoreSpelerTwee.GeefTotaleGameScoreAlsTekst();
            string spelerEenHuidigeGameScore = scoreSpelerEen.GeefHuidigeGameScoreAlsTekst();
            string spelerTweeHuidigeGameScore = scoreSpelerTwee.GeefHuidigeGameScoreAlsTekst();

            return string.Format("{0} {1} {2} {3}", spelerEenTotaleGameScore, spelerTweeTotaleGameScore, spelerEenHuidigeGameScore, spelerTweeHuidigeGameScore);
        }

        public void ScorePuntVoor(Speler speler)
        {
            Speler andereSpeler = GeefAndereSpeler(speler);

            SpelerScore huidigeSpelerScore = GetSpelerScore(speler);
            SpelerScore andereSpelerScore = GetSpelerScore(andereSpeler);

            huidigeSpelerScore.VoegPuntToe(andereSpelerScore);
        }

        private Speler GeefAndereSpeler(Speler speler)
        {
            return _andereSpelerLookup[speler];
        }

        private SpelerScore GetSpelerScore(Speler speler)
        {
            return _spelerScores[speler];
        }
    }
}
