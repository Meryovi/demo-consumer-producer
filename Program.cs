using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ProdCons.BL;
using ProdCons.Implementation;

namespace ProdCons
{
    /********
        Demostracion de una implementacion del patron Producer-Consumer.
        Utiliza TPL y algunos adicionales para mostrar el concepto.

        @Author: Meryovi De Dios
    ********/
    public class Program
    {	
        public static async Task Main()
        {
            var watch = new Stopwatch();
            watch.Start();
            
            var producerConsumer = new ProducerConsumerOfInts();
            
            var implementation = new ProducerConsumerPatternImpl();
            await implementation.ProduceAndConsume(howMany: 40, producerConsumer);
            
            watch.Stop();
            Console.WriteLine($"Duration: {watch.Elapsed}");
        }
    }
}
