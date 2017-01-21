using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BridgeProblem
{
    
    /// <summary>
    /// Object representing the car and it's properties
    /// </summary>
    public class Car
    {
        public enum Direction
        {
            LeftToRight,
            RightToLeft
        }

        //Car properties
        private int id;
        private string startPoint;
        private string endPoint;
        private Direction direction;

        public Car()
        {
        }

        //Inits car's properties
        public Car(int id, Direction dir)
        {
            this.id = id;
            this.direction = dir;
            if (dir == Direction.LeftToRight)
            {
                startPoint = "Left";
                endPoint = "Right";
            }
            else
            {
                startPoint = "Righ";
                endPoint = "Left";
            }
        }

        public Direction GetDirection() { return this.direction; }

        public string ToString()
        {
            return "Car id : " + this.id + ", From : " + startPoint + ", To : " + endPoint;
        }

        //Cross method,print the status of the car in the bridge
        public void Cross()
        {
            Console.WriteLine("Vehiculo " + id + "entra por " + startPoint);
            //Simulate Travel
            Thread.Sleep (100);
			Console.WriteLine ("Vehiculo " + id + " pasa puente");
			Thread.Sleep (100);
			Console.WriteLine("Vehiculo " + id + " sale por " + endPoint);
            Bridge.Instance.CarReachedEnd();
        }
    }
}
