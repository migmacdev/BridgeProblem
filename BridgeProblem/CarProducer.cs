using System;
using System.Threading;

namespace BridgeProblem
{

    public class CarProducer
    {
        int rightCars;              //Number of cars with right-to-left direction
        int leftCars;               //Number of cars with left-to-right direction
        int currentId = 0;          //Id used to name new cars, increments after creation
        int productionSpeed = 1000; //Time to spawn a new car

        Random rnd;

        //Setting up properties
        public CarProducer(int numOfRightCars, int numOfLeftCars)
        {
            this.rightCars = numOfRightCars;
            this.leftCars = numOfLeftCars;
            rnd = new Random();
        }

        //Creates a car with a random direction if available, otherwise returns null
        public Car produce()
        {
            Car c = null;

            if (rightCars == 0 && leftCars == 0)
            {
                return null;
            }

            int rndNum = rnd.Next(0, 2);

            //Simulates delay
            Thread.Sleep(rnd.Next(productionSpeed));

            //Generates cars if there are space available in both sides
            if (rndNum == 0 && rightCars > 0)
            {
                c = new Car(currentId, Car.Direction.RightToLeft);
                rightCars--;
            }
            else if (rndNum == 1 && leftCars > 0)
            {
                c = new Car(currentId, Car.Direction.LeftToRight);
                leftCars--;
            }
            
            //Generates a different car if the option is not available
            else if (rndNum == 1 && leftCars == 0 && rightCars > 0)
            {
                c = new Car(currentId, Car.Direction.RightToLeft);
                rightCars--;
            }
            else if (rndNum == 0 && rightCars == 0 && leftCars > 0)
            {
                c = new Car(currentId, Car.Direction.LeftToRight);
                leftCars--;
            }

            currentId++;
            return c;
        }

    }

}
