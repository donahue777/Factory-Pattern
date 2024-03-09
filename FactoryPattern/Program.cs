namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires for the vehicle do you want?");
            int wheelCount;
            bool input = false;
            do
            {
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while(!input);
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
