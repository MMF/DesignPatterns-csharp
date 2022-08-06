using DesignPatterns.BuilderPattern.CarExample;

public interface ICarBuilder
{
    void Reset();
    void SetSeats(int numOfSeats);
    void SetEngine(ICarEngine carEngine);
    void SetTripComputer(bool isTripComputerEnabled);
    void SetGPS(bool isGpsEnabled);
}

public class CarBuilder : ICarBuilder
{
    private Car _car = new();
    public void Reset()
    {
        _car = new Car();
    }

    public void SetEngine(ICarEngine carEngine)
    {
        _car.SetEngine(carEngine);
    }

    public void SetGPS(bool isGpsEnabled)
    {
        _car.SetGPS(isGpsEnabled);
    }

    public void SetSeats(int numOfSeats)
    {
        _car.SetNumOfSeats(numOfSeats);
    }

    public void SetTripComputer(bool isTripComputerEnabled)
    {
        _car.SetTripComputer(isTripComputerEnabled);
    }

    public Car Build()
    {
        var finalCar = _car;
        Reset();
        return finalCar;
    }
}