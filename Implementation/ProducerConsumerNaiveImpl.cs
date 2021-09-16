using System.Security.AccessControl;
using System;
using System.Threading.Tasks;
using ProdCons.BL;

namespace ProdCons.Implementation
{
    public class ProducerConsumerNaiveImpl
    {		
        public Task ProduceAndConsume<T>(int howMany, IProducerConsumer<T> producerConsumer)
        {
            for (int i = 0; i < howMany; i++)
            {
                T value = producerConsumer.Produce();
                producerConsumer.Consume(value);
            }
            
            return Task.FromResult(0);
        }
    }
}