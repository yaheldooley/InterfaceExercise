namespace InterfaceExercise
{
	partial class Program
    {
		public class SUV : ICompany, IVehicle
        {
			public int CargoHeightInInches { get; set; }
			public int CargoWidthInInches { get; set; }
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
				specString += $"-> Cargo Size: {CargoWidthInInches} W x {CargoHeightInInches} H\n";
				return specString;
			}
        }
    }
}
