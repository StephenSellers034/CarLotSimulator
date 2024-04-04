using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO


            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car myCar = new Car();

            myCar.Year = 2025;
            myCar.Make = "BMW";
            myCar.Model = "i5";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "Vroom, vrooom, Vrooooooom";
            myCar.HonkNoise = "Beep, Beep";
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise();

            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Car myCar1 = new Car()
            {
                Year = 2000,
                Make = "Toyota",
                Model = "Avalon",
                IsDriveable = false,
                EngineNoise = "DEAD",
                HonkNoise = "No Noise",

            };
            myCar1.MakeEngineNoise(myCar1.EngineNoise);
            myCar1.MakeHonkNoise();


            Car myCar2 = new Car(2019, "Telsa", "Model 3", "Vroom vroom vrooom", "Honkkk", true);

            List<Car> carsList = new List<Car>();

            foreach(Car item in carsList)
            {
                Console.WriteLine(item);
            }



            myCar2.MakeEngineNoise(myCar2.EngineNoise);
            myCar2.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
