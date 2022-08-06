namespace DesignPatterns.BuilderPattern.CarExample;

public class Car
{
    private int _numOfSeats;
    private ICarEngine _carEngine;
    private bool _isGpsEnabled;
    private bool _isTripComputerEnabled;

    public void SetNumOfSeats(int numOfSeats)
    {
        _numOfSeats = numOfSeats;
    }

    public void SetEngine(ICarEngine carEngine)
    {
        _carEngine = carEngine;
    }

    public void SetGPS(bool isGpsEnabled)
    {
        _isGpsEnabled = isGpsEnabled;
    }

    public void SetTripComputer(bool isTripComputerEnabled)
    {
        _isTripComputerEnabled = isTripComputerEnabled;
    }

    public override string ToString()
    {
        return $"Car with {_numOfSeats} seats, {_carEngine.GetType().Name}, {(_isGpsEnabled ? "with" : "without")} GPS, {(_isTripComputerEnabled ? "with" : "without")} trip computer";
    }
}
