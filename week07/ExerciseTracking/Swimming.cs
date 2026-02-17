public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceMeters = 50;

    public Swimming(string date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert meters to miles
        double distanceKm = (_laps * LapDistanceMeters) / 1000.0;
        return distanceKm * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
