public class Car : IVehicle
{
    public int Gasoline { get; set; }

    public Car(int gasoline)
    {
        Gasoline = gasoline;
    }
    public void Drive()
    {
        if (Gasoline > 0)
        {
            Console.WriteLine("Driving");
        }
    }
    public bool Refuel(int amount)
    {
        Gasoline += amount;
        return true;
    }
}