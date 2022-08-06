namespace DesignPatterns.BuilderPattern.CarExample
{
    public class ClientProgram
    {
        public static void Run()
        {
            var carBuilder = new CarBuilder();
            BuildSportsCar(carBuilder);
            
            var sportsCar = carBuilder.Build();

            Console.WriteLine(sportsCar);
        }

        private static void BuildSportsCar(ICarBuilder carBuilder)
        {
            carBuilder.SetSeats(2);
            carBuilder.SetEngine(new SportsEngine());
            carBuilder.SetGPS(true);
            carBuilder.SetTripComputer(true);
        }
    }
}
