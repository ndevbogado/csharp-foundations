namespace _01_InheritanceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO:    create 3 classes: Car, Plane & Vehicle.
            // TODO:    common methods between classes: StartEngine & StopEngine.
            // TODO:    virtual method: Drive.

            

            Vehicle[] vehicles = new Vehicle[2];

            vehicles[0] = new Car();
            vehicles[1] = new Plane();

            foreach(Vehicle vehicle in vehicles)
            {   
                vehicle.StartEngine();
                vehicle.Drive();
                vehicle.StopEngine();

                Console.WriteLine();
            }
        }
 
    }
}