using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }

        void DisplayDetails();
    }
}

