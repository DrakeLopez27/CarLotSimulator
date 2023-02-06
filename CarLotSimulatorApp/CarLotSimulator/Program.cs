using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var Lot = new CarLot();
            

            var malibu = new Car();
            malibu.Year = 2017;
            malibu.Make = "Chevy";
            malibu.Model = "Malibu";
            malibu.EngineNoise = "bzzzzz";
            malibu.HonkNoise = "beep beep";
            malibu.IsDriveable = true;
            Lot.cars.Add( malibu );


            var myCar = new Car()
            {

                Year = 2013,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "vroom",
                HonkNoise = "honk honk",
                IsDriveable = true,
                
             };
            Lot.cars.Add( myCar );


            var newCar = new Car("Dodge", "Ram", 2020, "vrrooom", "beep", true);
            Lot.cars.Add ( newCar );


            newCar.MakeEngineNoise(newCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);


            foreach (var car in Lot.cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");

            }

            //TODO

                //Create a seperate class file called Car
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property


                //Now that the Car class is created we can instanciate 3 new cars
                //Set the properties for each of the cars
                //Call each of the methods for each car

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
