using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //Create 3 classes called Car , Truck , & SUV



            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var galant = new Car();
            galant.CompanyName = "Mitsubishi Motors Co.";
            galant.HeadquartersAddress = "14770 Holy Motors BLVD, West lake, MI";
            galant.Make = "Mitsubishi";
            galant.Model = "Galant";
            galant.TrunkWidthInInches = 50;
            galant.TrunkHeightInInches = 27;
            galant.AxleCount = 2;
            galant.WheelCountPerAxle = 2;

            var s10 = new Truck();
            s10.CompanyName = "Chevrolet Motor Co.";
            s10.HeadquartersAddress = "550 Baldwin Park, Detroit, MI";
            s10.Make = "Chevy";
            s10.Model = "S-10";
            s10.BedWidthInInches = 58;
            s10.BedLengthInInches = 140;
            s10.AxleCount = 2;
            s10.WheelCountPerAxle = 2;

			var escalade = new SUV();
			escalade.CompanyName = "Cadillac Motors Co.";
			escalade.HeadquartersAddress = "780 West Richies Drive, Oakley, CT";
			escalade.Make = "Cadillac";
			escalade.Model = "Escalade";
			escalade.CargoWidthInInches = 65;
			escalade.CargoHeightInInches = 36;
			escalade.AxleCount = 2;
			escalade.WheelCountPerAxle = 2;

			//Creatively display and organize their values
			VisualizeVehicleSpecs(galant.DisplayVehicleSpecs());
			VisualizeVehicleSpecs(s10.DisplayVehicleSpecs());
			VisualizeVehicleSpecs(escalade.DisplayVehicleSpecs());
		}

        public static void VisualizeVehicleSpecs(string specString)
        {
            Console.WriteLine("=======VEHICLE ENTRY=========\n");
            Console.WriteLine(specString);
			Console.WriteLine("============END==============\n");
		}
    }
}
