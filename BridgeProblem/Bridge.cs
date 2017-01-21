using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BridgeProblem
{
    //Represents the bridge and executes the cross request in a synchronized block to avoid concurrency issues
    public class Bridge
    {

        Car.Direction currentDirection;         //Direction of the current car in the bridge
        int carsInBridge = 0;                   //The number of cars crossing the bridg at once in the same direction

        //Singleton Setup
        private static Bridge instance;
        private Bridge() { }
        public static Bridge Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bridge();
                }
                return instance;
            }
        }

        //If the car is allowed to cross it start a new Thread to execute the crossing
        public bool CrossCar(Car c)
        {
            lock (this) //Synchronized block
            {
                //If the bridge is empty
                if (carsInBridge == 0)
                {
                    new Thread(new ThreadStart(c.Cross)).Start();
                    carsInBridge++;
                    currentDirection = c.GetDirection();
                    return true;
                }

                //If a car is currently crossing the bridge in the same direction, the c car is started
                if (carsInBridge != 0 && c.GetDirection() == currentDirection)
                {
                    new Thread(new ThreadStart(c.Cross)).Start();
                    carsInBridge++;
                    currentDirection = c.GetDirection();

                    return true;

                }
                //If the car in the bridge has a different direction the c car is not allowed to cross
                if (carsInBridge > 0 && c.GetDirection() != currentDirection)
                {
                    return false;
                }
                return false;
            }

        }

        //To remove the car once it reaches the otherside
        public void CarReachedEnd()
        {
            lock (this)
            {
                carsInBridge--;
            }
        }
    }
}
