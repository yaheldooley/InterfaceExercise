namespace InterfaceExercise
{
	public interface IVehicle
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int AxleCount { get; set; }
		public int WheelCountPerAxle { get; set; }

		public string DisplayVehicleSpecs();

	}

}
