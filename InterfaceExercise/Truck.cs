using System;

namespace InterfaceExercise
{
	partial class Program
    {
		public class Truck : ICompany, IVehicle
		{
			public int BedWidthInInches { get; set; }
            public int BedLengthInInches { get; set; }
            public string CompanyName { get; set; }
            public string HeadquartersAddress { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int AxleCount { get; set; }
            public int WheelCountPerAxle { get; set; }

            public string DisplayVehicleSpecs()
            {
                string specString = "";
                specString += $"Company Name: {CompanyName}\n";
				specString += $"HQ Address: {HeadquartersAddress}\n";
				specString += $"-> Make: {Make}\n";
				specString += $"-> Model: {Model}\n";
				specString += $"-> # of Axels: {AxleCount}\n";
				specString += $"-> # Wheels Per Axle: {WheelCountPerAxle}\n";
				specString += $"-> Bed Size: {BedWidthInInches} W x {BedLengthInInches} L\n";
                return specString;
			}
        }
    }
}
