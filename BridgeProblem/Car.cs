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

        //Time to simulate car crossing the bridge
        private int sleepTime = 500;

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
                startPoint = "izquierda";
                endPoint = "derecha";
            }
            else
            {
                startPoint = "derecha";
                endPoint = "izquierda";
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
            Form1.AddToLog( "Vehiculo " + id + " entra por " + startPoint);
            //Simulate Travel
            Thread.Sleep (sleepTime);
            Form1.AddToLog("Vehiculo " + id + " pasa puente");
            Thread.Sleep (sleepTime);
            Form1.AddToLog("Vehiculo " + id + " sale por " + endPoint);

            Bridge.Instance.CarReachedEnd();
        }
    }
}
