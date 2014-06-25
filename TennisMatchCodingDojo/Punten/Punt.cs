namespace TennisMatchCodingDojo.Punten
{
    public abstract class Punt
    {
        public abstract string AlsTekst();

        public bool IsGelijkAan(Punt punt)
        {
            return GetType() == punt.GetType();
        }
    }
}