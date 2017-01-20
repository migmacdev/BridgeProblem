using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string StartPoint;
        private string EndPoint;

        public Car()
        {
        }

        //Inits car's properties
        public Car(int id, Direction dir)
        {
            this.id = id;
            if (dir == Direction.LeftToRight)
            {
                StartPoint = "Left";
                EndPoint = "Right";
            }
            else
            {
                StartPoint = "Righ";
                EndPoint = "Left";
            }
        }

        public string ToString()
        {
            return "Car id : " + this.id + ", From : " + StartPoint + ", To : " + EndPoint;
        }
    }
}
