using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BridgeProblem
{
    class Simulation
    {
        private int numberOfRightCars = 2;
        private int numberOfLeftCars = 3;

        ArrayList waitingCars = new ArrayList();
        Random rnd = new Random();

        //Runs the simulation with the number of cars
        public void RunSim(int rightCars, int leftCars)
        {
            this.numberOfRightCars = rightCars;
            this.numberOfLeftCars = leftCars;

            //Threads for produce cars and for manage them in the bridge
            Thread producerThread = new Thread(new ThreadStart(this.CarCreatorTS));
            Thread bridgeThread = new Thread(new ThreadStart(this.BridgeManagerTS));
            producerThread.Start();
            bridgeThread.Start();

        }

        //Manages the waiting cars to let them cross or wait
        private void BridgeManagerTS()
        {
            while (true)
            {
                if (waitingCars.Count > 0)
                {
                    int rndNum = rnd.Next(0, waitingCars.Count);
                    bool cross = Bridge.Instance.CrossCar((waitingCars[rndNum] as Car));
                    if (cross)
                    {
                        waitingCars.RemoveAt(rndNum);
                    }
                }
            }
        }

        //Constantly creates cars in a separated thread
        private void CarCreatorTS()
        {
            CarProducer producer = new CarProducer(numberOfRightCars, numberOfLeftCars);

            Car c = producer.produce();

            while (c != null)
            {
                Console.WriteLine(c.ToString());
                waitingCars.Add(c);
                c = producer.produce();
            }
        }
    }
}
