using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bagagesorteringssystems_opgave
{
    public class Program
    {
        static Queue<Baggage> baggageQueue = new Queue<Baggage>();
        static Queue<Baggage> terminal1 = new Queue<Baggage>();
        static Queue<Baggage> terminal2 = new Queue<Baggage>();
        static Queue<Baggage> terminal3 = new Queue<Baggage>();

        static Queue<Reservation> reservations = new Queue<Reservation>();

        static void Main(string[] args)
        {
            Skranke skranke = new Skranke(baggageQueue);
            Sortering sortering = new Sortering();
            Terminal terminal = new Terminal();

            Thread sorteringTråd = new Thread(sortering.SorteringBaggage);
            Thread skrank1Tråd = new Thread(skranke.SkrankSAS);
            Thread skrank2Tråd = new Thread(skranke.SkrankEmirates);
            Thread skrank3Tråd = new Thread(skranke.SkrankRyanAir);
            Thread terminal1Tråd = new Thread(terminal.Terminal1);
            Thread terminal2Tråd = new Thread(terminal.Terminal2);
            Thread terminal3Tråd = new Thread(terminal.Terminal3);

            sorteringTråd.Start();
            skrank1Tråd.Start();
            skrank2Tråd.Start();
            skrank3Tråd.Start();
            terminal1Tråd.Start();
            terminal2Tråd.Start();
            terminal3Tråd.Start();

            

        }
    }
}