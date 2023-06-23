using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car -- DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -- DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() -- DONE
            //The methods should take one string parameter: the respective noise property -- DONE


            //Now that the Car class is created we can instanciate 3 new cars -- DONE
            //Set the properties for each of the cars -- DONE
            //Call each of the methods for each car -- DONE
            

            var lot = new CarLot();

            var carOne = new Car();
            carOne.Year = 2008;
            carOne.Make = "Ford";
            carOne.Model = "Focus";
            carOne.EngineNoise = "Vroom";
            carOne.HonkNoise = "Beep";
            carOne.IsDriveable = true;

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);

            lot.Cars.Add(carOne);

            Console.WriteLine(CarLot.numberOfCars);


            var carTwo = new Car()
            {
                Year = 2012,
                Make = "Dodge",
                Model = "Ram",
                EngineNoise = "VROOM",
                HonkNoise = "BEEP",
                IsDriveable = true
            };
            

            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);

            lot.Cars.Add(carTwo);

            Console.WriteLine(CarLot.numberOfCars);

            var carThree = new Car(2023, "Tesla", "Model 3", "humm", "Beep", true);

            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);

            lot.Cars.Add(carThree);
            
            Console.WriteLine(CarLot.numberOfCars);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car -- DONE

            //*************BONUS X 2*************//

            //Create a CarLot class -- DONE
            //It should have at least one property: a List of cars -- DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. -- Done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console -- DONE

            foreach (var car in lot.Cars )
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }


        }
    }
}
