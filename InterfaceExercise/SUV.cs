using System;
using Microsoft.VisualBasic.FileIO;

namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
        public int NumberOfSeats { get; set; }
        public bool HasSunroof { get; set; }
        public string Logo { get ; set ; }
        public string CompanyName { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int MaxSpeed { get ; set ; }
        public string Color { get ; set ; }

        public void DisplayDetails()
        {
            Console.WriteLine($"SUV Details:\nNumber of Wheels: {NumberOfWheels}\nNumber of Doors: {NumberOfDoors}\nMax Speed: {MaxSpeed} km/h\nColor: {Color}\nNumber of Seats: {NumberOfSeats}\nHas Sunroof: {HasSunroof}\nCompany Name: {CompanyName}\nLogo: {Logo}\n");
        }
    }
}

