public class Swimming : Activity
{
    private int _laps;
    
    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return base.GetDuration() / GetDistance();
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}