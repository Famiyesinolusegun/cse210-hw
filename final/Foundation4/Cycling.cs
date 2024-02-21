public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        _speed = speed;
    }
    
    public override double GetSpeed()
    {
        return _speed;
    }
     

    public override double GetDistance()
    {
        return (_speed * _speed) / 60.0;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    
    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():F1} miles, Speed: {_speed} mph, Pace: {GetPace()} min/mile";
    }
} 