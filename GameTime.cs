namespace Monolith
{
    
    public readonly struct GameTime
    {

        public readonly float Delta;
        public readonly float FixedDelta;
        public readonly long UtcTimestamp;
        
        public GameTime(float delta, float fixedDelta, long utcTimestamp)
        {
            Delta = delta;
            FixedDelta = fixedDelta;
            UtcTimestamp = utcTimestamp;
        }
        
    }
    
}