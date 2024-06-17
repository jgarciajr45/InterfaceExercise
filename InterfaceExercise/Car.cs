using System;
using Microsoft.VisualBasic.FileIO;

namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
        public bool HasTrunk { get; set; }
        public string BodyStyle { get; set; }
        public string Logo { get ; set ; }
        public string CompanyName { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int MaxSpeed { get ; set ; }
        public string Color { get ; set ; }


        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details:\nNumber of Wheels: {NumberOfWheels}\nNumber of Doors: {NumberOfDoors}\nMax Speed: {MaxSpeed} km/h\nColor: {Color}\nHas Trunk: {HasTrunk}\nBody Style: {BodyStyle}\nCompany Name: {CompanyName}\nLogo: {Logo}\n");
        }

    }
}

