using System;
namespace CarLotSimulator
{
	public class Car
	{
        

        public Car()
		{
		}

		public Car(int year, string make, string model, string enginenoise, string honknoise, bool isdriveable )
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = enginenoise;
			HonkNoise = honknoise;
			IsDriveable = isdriveable;
		}


		public int Year { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public string EngineNoise { get; set; }

		public string HonkNoise { get; set; }

		public bool IsDriveable { get; set; }

		public void MakeEngineNoise(string noise)
		{
			Console.WriteLine($"{Make}'s engine noise sounds like: {noise}");
		}

		public void MakeHonkNoise()
		{
			Console.WriteLine($"{Make}'s honk noise sounds like: {HonkNoise}");
		}

	}



}

