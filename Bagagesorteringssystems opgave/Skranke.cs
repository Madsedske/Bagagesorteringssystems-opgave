using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bagagesorteringssystems_opgave
{
    public class Skranke
    {
        Random random = new Random();
        Queue<Baggage> baggageQueue;

        Reservation reservation;

        public Skranke(Queue<Baggage> baggageQueueHolder)
        {
            baggageQueue = baggageQueueHolder;
        }

        public void SkrankSAS()
        {
            int baggageNum = 1;

            while (true)
            {
                Monitor.Enter(baggageQueue);

                if (baggageQueue.Count < 50)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        Baggage baggageSAS = new Baggage(baggageNum, 8,DateTime.Now,DateTime.Now);
                        baggageQueue.Enqueue(baggageSAS);
                        baggageNum++;
                    }
                }
                else if (baggageQueue.Count == 50)
                    Debug.WriteLine("Skrank venter..");
                Thread.Sleep(1000);
                Monitor.PulseAll(baggageQueue);
                Monitor.Exit(baggageQueue);
            }
        }

        public void SkrankEmirates()
        {

        }

        public void SkrankRyanAir()
        {

        }
    }
}
