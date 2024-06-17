using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
        public double CargoCapacity { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public string Logo { get ; set ; }
        public string CompanyName { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int MaxSpeed { get ; set ; }
        public string Color { get ; set ; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details:\nNumber of Wheels: {NumberOfWheels}\nNumber of Doors: {NumberOfDoors}\nMax Speed: {MaxSpeed} km/h\nColor: {Color}\nCargo Capacity: {CargoCapacity}\nHas Four Wheel Drive: {HasFourWheelDrive}\nCompany Name: {CompanyName}\nLogo: {Logo}\n");
        }
    }
}

