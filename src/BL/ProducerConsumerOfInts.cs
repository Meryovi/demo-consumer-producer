using System;
using System.Threading;

namespace ProdCons.BL
{
    public class ProducerConsumerOfInts : IProducerConsumer<int>
    {
        public int Produce()
        {
            Thread.Sleep(200); // Un trabajito bien pesao.

            int value = (new Random()).Next(1000);
                
            Console.WriteLine($"Produced {value:000}!");		
            return value;
        }

        public void Consume(int value)
        {
            Thread.Sleep(100); // Un trabajito menos pesao.

            Console.WriteLine($"Consumed {value:000}!");
        }
    }
}